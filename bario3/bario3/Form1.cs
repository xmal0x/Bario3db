﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario3
{
    public partial class FormMain : Form
    {
        //DBController mainDBController;
        SQLController SQL;
        public FormMain()
        {
            InitializeComponent();
            //mainDBController = new DBController();
            SQL = new SQLController();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SQL.Connect(dataGridViewClassification, dataGridViewInvent);

            //mainDBController.Connect();
            //mainDBController.LoadAll();
            //mainDBController.ShowClassDB(dataGridViewClassification, mainDBController.classificationDB);
            //mainDBController.ShowInventDB(dataGridViewInvent, mainDBController.inventDB);

            //инициализация автокомплитов для name and type
            HelpController.IniAuto(SQL.GetDataFromClass("Name"), textBoxAddName);
            HelpController.IniAuto(SQL.GetDataFromClass("Type"), textBoxAddType);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddPosition_Click(object sender, EventArgs e)
        {
            //добавить позицию в номенклатурный справочник
            try
            {
                string name = textBoxAddName.Text;
                int serial = Int32.Parse(textBoxAddSerial.Text);
                string type = textBoxAddType.Text;
                int weightFull = Int32.Parse(textBoxAddWeightFull.Text);
                int weightEmpty = Int32.Parse(textBoxAddWeightEmpty.Text);
                int weightNow = Int32.Parse(textBoxAddWeightNow.Text);
                int capacityFull = Int32.Parse(textBoxAddCapacityFull.Text);
                int capacityNow = Int32.Parse(textBoxAddCapacityNow.Text);
                int price = Int32.Parse(textBoxAddPrice.Text);
                int portion = Int32.Parse(textBoxAddPortion.Text);

                //mainDBController.AddPosition(name, serial, type, weightFull, weightEmpty, weightNow, capacityFull, capacityNow, price, portion);
                SQL.InsertToClassDb(name, serial, type, weightFull, weightEmpty, weightNow, capacityFull, capacityNow, price, portion);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка, одно из значение не верно\n" + ex.Message);
                return;
            }

            //mainDBController.ShowClassDB(dataGridViewClassification, mainDBController.classificationDB);
            SQL.ShowDB(dataGridViewClassification, SQL.classificationShowDBString);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //mainDBController.SaveAll();
        }

        private void buttonScanPosition_Click(object sender, EventArgs e)
        {
            try
            {
                int weightScan = Int32.Parse(textBoxWeightScan.Text);
                int serialScan = Int32.Parse(textBoxSerialScan.Text);

                SQL.ScanPosition(weightScan, serialScan);
                SQL.ShowDB(dataGridViewInvent, SQL.inventShowDBString);
                
                //mainDBController.ScanPosition(weightScan, serialScan);
                //mainDBController.ShowInventDB(dataGridViewInvent, mainDBController.inventDB);
            }catch(Exception ex)
            {
                MessageBox.Show("Ошибка в сканируемых значениях\n" + ex.Message);
            }

        }

        private void dateTimePickerMoney_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerMoney.Value;

            labelMoneyFull.Text = mathBario.CalculateMoneyForDay(SQL.GetDictionaryFromDate(date)).ToString();
        }

        private void buttonMoneyDifference_Click(object sender, EventArgs e)
        {
            int gain = 0; // выручка

            DateTime day1 = dateTimePickerMoneyDiffDay1.Value;
            DateTime day2 = dateTimePickerMoneyDiffDay2.Value;

            //считаем как Стоимость позиций в 2й день - стоимость позиций в день 1 получаем теоретическую выручку
            gain = mathBario.CalculateMoneyForDay(SQL.GetDictionaryFromDate(day2)) - mathBario.CalculateMoneyForDay(SQL.GetDictionaryFromDate(day1));

            labelMoneyDiff.Text = gain.ToString(); 

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                string tableFrom = "[dbo].[Classification]";
                int id = Int32.Parse(textBoxIdDelClass.Text);
                int serial = Int32.Parse(textBoxSerialDelClass.Text);

                SQL.DeleteRecord(tableFrom, serial, id);

                SQL.ShowDB(dataGridViewClassification, SQL.classificationShowDBString);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка, проверьте правильность значений\n" + ex.Message);
            }

        }

        private void buttonDelInvent_Click(object sender, EventArgs e)
        {
            try
            {
                string tableFrom = "[dbo].[Invent]";
                int id = Int32.Parse(textBoxIdDelInvent.Text);
                int serial = Int32.Parse(textBoxSerialDelInvent.Text);

                SQL.DeleteRecord(tableFrom, serial, id);

                SQL.ShowDB(dataGridViewInvent, SQL.inventShowDBString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка, проверьте правильность значений\n" + ex.Message);
            }
        }
    }
}
