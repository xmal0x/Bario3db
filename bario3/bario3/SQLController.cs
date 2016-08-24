using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace bario3
{
    class SQLController
    {
        //строка подключения к БД
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\mainDB.mdf;Integrated Security=True";
        
        //команда для запроса к БД наименований 
        public string classificationShowDBString = @"SELECT [Id] AS [Номер], [Name] AS [Название], [Serial] AS [Серийный номер], 
                                                    [Type] AS [Тип], [Weight Full] AS [Вес полной бутылки, гр.], [Weight Empty] AS [Вес пустой бутылки, гр.], 
                                                    [Weight Now] AS [Текущий вес бутылки, гр.], [Capacity Full] AS [Полный обьем, мл.], [Capacity Now] AS [Текущий обьем, мл.], 
                                                    [Price] AS [Цена за порцию, руб.], [Portion] AS [Порция, мл] FROM [dbo].[Classification]";
        
        //запрос к БД инвентаризации
        public string inventShowDBString = @"SELECT [Id] AS [Номер], [Date] AS [Дата инвентаризации], [Name] AS [Название], [Serial] AS [Серийный номер], 
                                                    [Type] AS [Тип], [Capacity Full] AS [Полный обьем, мл.], [Capacity Now] AS [Текущий обьем, мл.], 
                                                    [Price] AS [Цена за порцию, руб.], [Portion] AS [Порция, мл], [Full Price] AS [Стоимость полная, руб] 
                                                    FROM [dbo].[Invent]";
        
        //создаем подключение
        private SqlConnection connection = new SqlConnection(connectionString);

        public void Connect(DataGridView _dataGridClass, DataGridView _dataGridInvent)
        {
            //коннект, загружаем данные из таблиц в датаГриды 
            ShowDB(_dataGridClass, classificationShowDBString);
            ShowDB(_dataGridInvent, inventShowDBString);
        }

        public void ShowDB(DataGridView _dataGrid, string typeDBcommand)
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(typeDBcommand, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);



                _dataGrid.DataSource = dataTable;
                _dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выводе БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckSerial(int serial)
        {
            //Проверка наличия серийника в БД номенклатуры
            try
            {
                connection.Open();
                SqlCommand commandCheckSerial = new SqlCommand("SELECT [Serial] FROM [dbo].[Classification] WHERE Serial = @serial", connection);
                commandCheckSerial.Parameters.AddWithValue("@serial", serial);
                using (SqlDataReader dataReader = commandCheckSerial.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка проверки дубликатов в БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public void InsertToClassDb(string name, int serial, string type, int weightFull, int weightEmpty, int weightNow, int capacityFull, int capacityNow, int price, int portion)
        {
            //проверка наличия дубликата
            if(CheckSerial(serial))
            {
                MessageBox.Show("Ошибка, позиция с таким серийным номером уже есть в БД");
                return;
            }
            //добавление позиции
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand(@"INSERT INTO [dbo].[Classification]([Name], [Serial], [Type], [Weight Full], 
                                                            [Weight Empty], [Weight Now], [Capacity Full], [Capacity Now], [Price], [Portion]) 
                                                        VALUES (@name, @serial, @type, @weightFull, @weightEmpty, @weightNow, 
                                                        @capacityFull, @capacityNow, @price, @portion)", connection);
                commandInsert.Parameters.AddWithValue("@name", name);
                commandInsert.Parameters.AddWithValue("@serial", serial);
                commandInsert.Parameters.AddWithValue("@type", type);
                commandInsert.Parameters.AddWithValue("@weightFull", weightFull);
                commandInsert.Parameters.AddWithValue("@weightEmpty", weightEmpty);
                commandInsert.Parameters.AddWithValue("@weightNow", weightNow);
                commandInsert.Parameters.AddWithValue("@capacityFull", capacityFull);
                commandInsert.Parameters.AddWithValue("@capacityNow", capacityNow);
                commandInsert.Parameters.AddWithValue("@price", price);
                commandInsert.Parameters.AddWithValue("@portion", portion);




                commandInsert.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении записи в БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void ScanPosition(int weightScan, int serialScan)
        {

            if (!CheckSerial(serialScan))
            {
                MessageBox.Show("Ошибка, позиция с таким серийным номером не найдена в номенклатурном справочнике");
                return;
            }

            DateTime date;
            string name = "";
            int serial;
            string type;
            int capacityFull;
            int capacityNow;
            int price;
            int portion;
            int fullPrice;

            SqlCommand commandInsertToInventDB = new SqlCommand(@"INSERT INTO [dbo].[Invent] ([Date], [Name], [Serial], [Type], [Capacity Full],
                                                                [Capacity Now], [Price], [Portion], [Full Price]) VALUES (@date, @name, @serial, @type, 
                                                                @capacityFull, @capacityNow, @price, @portion, @fullPrice)", connection);
            //берем обьект типа Боттле из БД наименований по серийнику
            Bottle inventBottle = MakeBottleFromClassDB(serialScan);

            try
            {
                connection.Open();
                SqlCommand commandScan = new SqlCommand(@"SELECT * FROM [dbo].[Classification] WHERE [Serial] = @serialScan", connection);
                commandScan.Parameters.AddWithValue("@serialScan", serialScan);

                using (SqlDataReader dataReader = commandScan.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        date = DateTime.Now;
                        name = dataReader["Name"].ToString();
                        serial = (int)dataReader["Serial"];
                        type = dataReader["Type"].ToString();
                        capacityFull = (int)dataReader["Capacity Full"];
                        capacityNow = (int)mathBario.Calculate(inventBottle, weightScan);
                        price = (int)dataReader["Price"];
                        portion = (int)dataReader["Portion"];

                        //для расчета полной стоимости берем значение текущей емкости
                        inventBottle.capacityNow = capacityNow;
                        fullPrice = (int)mathBario.FullPriceCalculate(inventBottle);


                        commandInsertToInventDB.Parameters.AddWithValue("@date", date);
                        commandInsertToInventDB.Parameters.AddWithValue("@name", name);
                        commandInsertToInventDB.Parameters.AddWithValue("@serial", serial);
                        commandInsertToInventDB.Parameters.AddWithValue("@type", type);
                        commandInsertToInventDB.Parameters.AddWithValue("@capacityFull", capacityFull);
                        commandInsertToInventDB.Parameters.AddWithValue("@capacityNow", capacityNow);
                        commandInsertToInventDB.Parameters.AddWithValue("@price", price);
                        commandInsertToInventDB.Parameters.AddWithValue("@portion", portion);
                        commandInsertToInventDB.Parameters.AddWithValue("@fullPrice", fullPrice);

                        
                    }
                }
                if (name == "")
                {
                    MessageBox.Show("Ошибка, позиции с таким серийным номером не найдено в БД");
                    return;
                }
                commandInsertToInventDB.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сканирования в БД\n" + ex.Message);
                
            }
            finally
            {
                connection.Close();
            }

        }

        public string[] GetDataFromClass(string dataName)
        {
            //получаем список значений определенных столбцов, нужно для автозаполнения текстБоксов Нэйм и Тип
            List<string> dataList = new List<string>();

            try
            {
                connection.Open();
                SqlCommand commandGetData = new SqlCommand("SELECT [Name], [Type] FROM [dbo].[Classification]", connection);
                
                using (SqlDataReader dataReader = commandGetData.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        dataList.Add(dataReader[dataName].ToString());
                        Console.WriteLine(dataReader[dataName].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении данных из БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataList.ToArray();
        }


        public Bottle MakeBottleFromClassDB(int serial)
        {
            Bottle bottle = new Bottle();
            bottle.name = "";
            try
            {
                connection.Open();

                SqlCommand commandGetBottle = new SqlCommand(@"SELECT * FROM [dbo].[Classification] WHERE [Serial] = @serial",connection);
                commandGetBottle.Parameters.AddWithValue("@serial", serial);

                using (SqlDataReader dataReader = commandGetBottle.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        bottle.posNum = (int)dataReader["Id"];
                        bottle.name = dataReader["Name"].ToString();
                        bottle.serial = (int)dataReader["Serial"];
                        bottle.type = dataReader["Type"].ToString();
                        bottle.weightFull = (int)dataReader["Weight full"];
                        bottle.weightEmpty = (int)dataReader["Weight Empty"];
                        bottle.weightNow = (int)dataReader["Weight Now"];
                        bottle.capacityFull = (int)dataReader["Capacity Full"];
                        bottle.capacityNow = (int)dataReader["Capacity Now"];
                        bottle.price = (int)dataReader["Price"];
                        bottle.portion = (int)dataReader["Portion"];
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при преобразовании в БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return bottle;
        }

        public Dictionary<DateTime, Bottle> GetDictionaryFromDate(DateTime date)
        {
            Dictionary<DateTime, Bottle> dict = new Dictionary<DateTime, Bottle>();
            Bottle inventBottle = new Bottle();

            try
            {
                connection.Open();

                SqlCommand commandGetFromDate = new SqlCommand(@"SELECT * FROM [dbo].[Invent]", connection);

                using (SqlDataReader dataReader = commandGetFromDate.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        DateTime dateFromSQl = (DateTime)dataReader["Date"];
                        if (date.Date == dateFromSQl.Date)
                        {
                            inventBottle.posNum = (int)dataReader["Id"];
                            inventBottle.name = dataReader["Name"].ToString();
                            inventBottle.serial = (int)dataReader["Serial"];
                            inventBottle.type = dataReader["Type"].ToString();
                            inventBottle.capacityFull = (int)dataReader["Capacity Full"];
                            inventBottle.capacityNow = (int)dataReader["Capacity Now"];
                            inventBottle.price = (int)dataReader["Price"];
                            inventBottle.portion = (int)dataReader["Portion"];

                            dict.Add(dateFromSQl, inventBottle);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборке по дате из БД\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dict;
        }

        public void DeleteRecord(string tableFromDB, int serial, int id)
        {
            try
            {
                connection.Open();

                SqlCommand commandDelete = new SqlCommand("DELETE FROM " + tableFromDB + " WHERE [Id] = @id AND [Serial] = @serial", connection);
                commandDelete.Parameters.AddWithValue("@id", id);
                commandDelete.Parameters.AddWithValue("@serial", serial);
                commandDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, удаление данных не произошло\n" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
