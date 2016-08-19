namespace bario3
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMoneyDiff = new System.Windows.Forms.Label();
            this.labelMoneyDiffd1d2 = new System.Windows.Forms.Label();
            this.buttonMoneyDifference = new System.Windows.Forms.Button();
            this.dateTimePickerMoneyDiffDay2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerMoneyDiffDay1 = new System.Windows.Forms.DateTimePicker();
            this.labelMoneyDiffDay2 = new System.Windows.Forms.Label();
            this.labelMoneyDiffDay1 = new System.Windows.Forms.Label();
            this.labelMoneyDifference = new System.Windows.Forms.Label();
            this.panelMoney = new System.Windows.Forms.Panel();
            this.labelMoneyFull = new System.Windows.Forms.Label();
            this.labelMoneyGet = new System.Windows.Forms.Label();
            this.labelMoneyDate = new System.Windows.Forms.Label();
            this.dateTimePickerMoney = new System.Windows.Forms.DateTimePicker();
            this.labelMoney = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelScanPosition = new System.Windows.Forms.Panel();
            this.buttonScanPosition = new System.Windows.Forms.Button();
            this.textBoxWeightScan = new System.Windows.Forms.TextBox();
            this.textBoxSerialScan = new System.Windows.Forms.TextBox();
            this.labelWeightScan = new System.Windows.Forms.Label();
            this.labelSerialScan = new System.Windows.Forms.Label();
            this.labelScanposition = new System.Windows.Forms.Label();
            this.dataGridViewInvent = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelAddPosition = new System.Windows.Forms.Panel();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.textBoxAddPortion = new System.Windows.Forms.TextBox();
            this.textBoxAddPrice = new System.Windows.Forms.TextBox();
            this.textBoxAddCapacityNow = new System.Windows.Forms.TextBox();
            this.textBoxAddCapacityFull = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightNow = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightEmpty = new System.Windows.Forms.TextBox();
            this.textBoxAddWeightFull = new System.Windows.Forms.TextBox();
            this.textBoxAddType = new System.Windows.Forms.TextBox();
            this.textBoxAddSerial = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.labelAddPortion = new System.Windows.Forms.Label();
            this.labelAddPrice = new System.Windows.Forms.Label();
            this.labelAddCapacityNow = new System.Windows.Forms.Label();
            this.labelAddCapacityFull = new System.Windows.Forms.Label();
            this.labelAddWeightNow = new System.Windows.Forms.Label();
            this.labelAddWeightEmpty = new System.Windows.Forms.Label();
            this.labelAddWeightFull = new System.Windows.Forms.Label();
            this.labelAddType = new System.Windows.Forms.Label();
            this.labelAddSerial = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.labelAddPosition = new System.Windows.Forms.Label();
            this.dataGridViewClassification = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMoney.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelScanPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvent)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panelAddPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassification)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 667);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panelMoney);
            this.tabPage1.Controls.Add(this.panelMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1154, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMoneyDiff);
            this.panel1.Controls.Add(this.labelMoneyDiffd1d2);
            this.panel1.Controls.Add(this.buttonMoneyDifference);
            this.panel1.Controls.Add(this.dateTimePickerMoneyDiffDay2);
            this.panel1.Controls.Add(this.dateTimePickerMoneyDiffDay1);
            this.panel1.Controls.Add(this.labelMoneyDiffDay2);
            this.panel1.Controls.Add(this.labelMoneyDiffDay1);
            this.panel1.Controls.Add(this.labelMoneyDifference);
            this.panel1.Location = new System.Drawing.Point(7, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 191);
            this.panel1.TabIndex = 2;
            // 
            // labelMoneyDiff
            // 
            this.labelMoneyDiff.AutoSize = true;
            this.labelMoneyDiff.Location = new System.Drawing.Point(220, 131);
            this.labelMoneyDiff.Name = "labelMoneyDiff";
            this.labelMoneyDiff.Size = new System.Drawing.Size(13, 13);
            this.labelMoneyDiff.TabIndex = 7;
            this.labelMoneyDiff.Text = "0";
            // 
            // labelMoneyDiffd1d2
            // 
            this.labelMoneyDiffd1d2.AutoSize = true;
            this.labelMoneyDiffd1d2.Location = new System.Drawing.Point(7, 131);
            this.labelMoneyDiffd1d2.Name = "labelMoneyDiffd1d2";
            this.labelMoneyDiffd1d2.Size = new System.Drawing.Size(207, 13);
            this.labelMoneyDiffd1d2.TabIndex = 6;
            this.labelMoneyDiffd1d2.Text = "Разница между 1 днем и 2м(выручка?):";
            // 
            // buttonMoneyDifference
            // 
            this.buttonMoneyDifference.Location = new System.Drawing.Point(73, 159);
            this.buttonMoneyDifference.Name = "buttonMoneyDifference";
            this.buttonMoneyDifference.Size = new System.Drawing.Size(134, 23);
            this.buttonMoneyDifference.TabIndex = 5;
            this.buttonMoneyDifference.Text = "Расчитать разницу";
            this.buttonMoneyDifference.UseVisualStyleBackColor = true;
            this.buttonMoneyDifference.Click += new System.EventHandler(this.buttonMoneyDifference_Click);
            // 
            // dateTimePickerMoneyDiffDay2
            // 
            this.dateTimePickerMoneyDiffDay2.Location = new System.Drawing.Point(7, 104);
            this.dateTimePickerMoneyDiffDay2.Name = "dateTimePickerMoneyDiffDay2";
            this.dateTimePickerMoneyDiffDay2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMoneyDiffDay2.TabIndex = 4;
            // 
            // dateTimePickerMoneyDiffDay1
            // 
            this.dateTimePickerMoneyDiffDay1.Location = new System.Drawing.Point(7, 55);
            this.dateTimePickerMoneyDiffDay1.Name = "dateTimePickerMoneyDiffDay1";
            this.dateTimePickerMoneyDiffDay1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMoneyDiffDay1.TabIndex = 3;
            // 
            // labelMoneyDiffDay2
            // 
            this.labelMoneyDiffDay2.AutoSize = true;
            this.labelMoneyDiffDay2.Location = new System.Drawing.Point(4, 88);
            this.labelMoneyDiffDay2.Name = "labelMoneyDiffDay2";
            this.labelMoneyDiffDay2.Size = new System.Drawing.Size(96, 13);
            this.labelMoneyDiffDay2.TabIndex = 2;
            this.labelMoneyDiffDay2.Text = "Выберите 2 день:";
            // 
            // labelMoneyDiffDay1
            // 
            this.labelMoneyDiffDay1.AutoSize = true;
            this.labelMoneyDiffDay1.Location = new System.Drawing.Point(4, 39);
            this.labelMoneyDiffDay1.Name = "labelMoneyDiffDay1";
            this.labelMoneyDiffDay1.Size = new System.Drawing.Size(143, 13);
            this.labelMoneyDiffDay1.TabIndex = 1;
            this.labelMoneyDiffDay1.Text = "Выберите 1 день(сегодня):";
            // 
            // labelMoneyDifference
            // 
            this.labelMoneyDifference.AutoSize = true;
            this.labelMoneyDifference.Location = new System.Drawing.Point(4, 10);
            this.labelMoneyDifference.Name = "labelMoneyDifference";
            this.labelMoneyDifference.Size = new System.Drawing.Size(153, 13);
            this.labelMoneyDifference.TabIndex = 0;
            this.labelMoneyDifference.Text = "Расчет разницы по наличию:";
            // 
            // panelMoney
            // 
            this.panelMoney.Controls.Add(this.labelMoneyFull);
            this.panelMoney.Controls.Add(this.labelMoneyGet);
            this.panelMoney.Controls.Add(this.labelMoneyDate);
            this.panelMoney.Controls.Add(this.dateTimePickerMoney);
            this.panelMoney.Controls.Add(this.labelMoney);
            this.panelMoney.Location = new System.Drawing.Point(7, 6);
            this.panelMoney.Name = "panelMoney";
            this.panelMoney.Size = new System.Drawing.Size(299, 130);
            this.panelMoney.TabIndex = 1;
            // 
            // labelMoneyFull
            // 
            this.labelMoneyFull.AutoSize = true;
            this.labelMoneyFull.Location = new System.Drawing.Point(184, 76);
            this.labelMoneyFull.Name = "labelMoneyFull";
            this.labelMoneyFull.Size = new System.Drawing.Size(13, 13);
            this.labelMoneyFull.TabIndex = 4;
            this.labelMoneyFull.Text = "0";
            // 
            // labelMoneyGet
            // 
            this.labelMoneyGet.AutoSize = true;
            this.labelMoneyGet.Location = new System.Drawing.Point(7, 76);
            this.labelMoneyGet.Name = "labelMoneyGet";
            this.labelMoneyGet.Size = new System.Drawing.Size(171, 13);
            this.labelMoneyGet.TabIndex = 3;
            this.labelMoneyGet.Text = "Стоимость позиций составляет:";
            // 
            // labelMoneyDate
            // 
            this.labelMoneyDate.AutoSize = true;
            this.labelMoneyDate.Location = new System.Drawing.Point(4, 32);
            this.labelMoneyDate.Name = "labelMoneyDate";
            this.labelMoneyDate.Size = new System.Drawing.Size(85, 13);
            this.labelMoneyDate.TabIndex = 2;
            this.labelMoneyDate.Text = "Выберите дату:";
            // 
            // dateTimePickerMoney
            // 
            this.dateTimePickerMoney.Location = new System.Drawing.Point(7, 49);
            this.dateTimePickerMoney.Name = "dateTimePickerMoney";
            this.dateTimePickerMoney.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerMoney.TabIndex = 1;
            this.dateTimePickerMoney.ValueChanged += new System.EventHandler(this.dateTimePickerMoney_ValueChanged);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(4, 4);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(150, 13);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Расчет средств по наличию:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonSave);
            this.panelMain.Controls.Add(this.buttonConnect);
            this.panelMain.Location = new System.Drawing.Point(924, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(224, 130);
            this.panelMain.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(113, 32);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(113, 3);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(108, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelScanPosition);
            this.tabPage2.Controls.Add(this.dataGridViewInvent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1154, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Инвентаризация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelScanPosition
            // 
            this.panelScanPosition.Controls.Add(this.buttonScanPosition);
            this.panelScanPosition.Controls.Add(this.textBoxWeightScan);
            this.panelScanPosition.Controls.Add(this.textBoxSerialScan);
            this.panelScanPosition.Controls.Add(this.labelWeightScan);
            this.panelScanPosition.Controls.Add(this.labelSerialScan);
            this.panelScanPosition.Controls.Add(this.labelScanposition);
            this.panelScanPosition.Location = new System.Drawing.Point(844, 7);
            this.panelScanPosition.Name = "panelScanPosition";
            this.panelScanPosition.Size = new System.Drawing.Size(304, 117);
            this.panelScanPosition.TabIndex = 1;
            // 
            // buttonScanPosition
            // 
            this.buttonScanPosition.Location = new System.Drawing.Point(96, 83);
            this.buttonScanPosition.Name = "buttonScanPosition";
            this.buttonScanPosition.Size = new System.Drawing.Size(100, 23);
            this.buttonScanPosition.TabIndex = 5;
            this.buttonScanPosition.Text = "Сканировать";
            this.buttonScanPosition.UseVisualStyleBackColor = true;
            this.buttonScanPosition.Click += new System.EventHandler(this.buttonScanPosition_Click);
            // 
            // textBoxWeightScan
            // 
            this.textBoxWeightScan.Location = new System.Drawing.Point(96, 57);
            this.textBoxWeightScan.Name = "textBoxWeightScan";
            this.textBoxWeightScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightScan.TabIndex = 4;
            // 
            // textBoxSerialScan
            // 
            this.textBoxSerialScan.Location = new System.Drawing.Point(96, 34);
            this.textBoxSerialScan.Name = "textBoxSerialScan";
            this.textBoxSerialScan.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerialScan.TabIndex = 3;
            // 
            // labelWeightScan
            // 
            this.labelWeightScan.AutoSize = true;
            this.labelWeightScan.Location = new System.Drawing.Point(16, 60);
            this.labelWeightScan.Name = "labelWeightScan";
            this.labelWeightScan.Size = new System.Drawing.Size(74, 13);
            this.labelWeightScan.TabIndex = 2;
            this.labelWeightScan.Text = "Вес позиции:";
            // 
            // labelSerialScan
            // 
            this.labelSerialScan.AutoSize = true;
            this.labelSerialScan.Location = new System.Drawing.Point(31, 37);
            this.labelSerialScan.Name = "labelSerialScan";
            this.labelSerialScan.Size = new System.Drawing.Size(59, 13);
            this.labelSerialScan.TabIndex = 1;
            this.labelSerialScan.Text = "Серийник:";
            // 
            // labelScanposition
            // 
            this.labelScanposition.AutoSize = true;
            this.labelScanposition.Location = new System.Drawing.Point(16, 14);
            this.labelScanposition.Name = "labelScanposition";
            this.labelScanposition.Size = new System.Drawing.Size(123, 13);
            this.labelScanposition.TabIndex = 0;
            this.labelScanposition.Text = "Сканировать позицию:";
            // 
            // dataGridViewInvent
            // 
            this.dataGridViewInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvent.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewInvent.Name = "dataGridViewInvent";
            this.dataGridViewInvent.Size = new System.Drawing.Size(830, 628);
            this.dataGridViewInvent.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonRefresh);
            this.tabPage3.Controls.Add(this.panelAddPosition);
            this.tabPage3.Controls.Add(this.dataGridViewClassification);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1154, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "БД наименований";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelAddPosition
            // 
            this.panelAddPosition.Controls.Add(this.buttonAddPosition);
            this.panelAddPosition.Controls.Add(this.textBoxAddPortion);
            this.panelAddPosition.Controls.Add(this.textBoxAddPrice);
            this.panelAddPosition.Controls.Add(this.textBoxAddCapacityNow);
            this.panelAddPosition.Controls.Add(this.textBoxAddCapacityFull);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightNow);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightEmpty);
            this.panelAddPosition.Controls.Add(this.textBoxAddWeightFull);
            this.panelAddPosition.Controls.Add(this.textBoxAddType);
            this.panelAddPosition.Controls.Add(this.textBoxAddSerial);
            this.panelAddPosition.Controls.Add(this.textBoxAddName);
            this.panelAddPosition.Controls.Add(this.labelAddPortion);
            this.panelAddPosition.Controls.Add(this.labelAddPrice);
            this.panelAddPosition.Controls.Add(this.labelAddCapacityNow);
            this.panelAddPosition.Controls.Add(this.labelAddCapacityFull);
            this.panelAddPosition.Controls.Add(this.labelAddWeightNow);
            this.panelAddPosition.Controls.Add(this.labelAddWeightEmpty);
            this.panelAddPosition.Controls.Add(this.labelAddWeightFull);
            this.panelAddPosition.Controls.Add(this.labelAddType);
            this.panelAddPosition.Controls.Add(this.labelAddSerial);
            this.panelAddPosition.Controls.Add(this.labelAddName);
            this.panelAddPosition.Controls.Add(this.labelAddPosition);
            this.panelAddPosition.Location = new System.Drawing.Point(821, 4);
            this.panelAddPosition.Name = "panelAddPosition";
            this.panelAddPosition.Size = new System.Drawing.Size(330, 339);
            this.panelAddPosition.TabIndex = 1;
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(149, 287);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(100, 38);
            this.buttonAddPosition.TabIndex = 21;
            this.buttonAddPosition.Text = "Добавить позицию";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.buttonAddPosition_Click);
            // 
            // textBoxAddPortion
            // 
            this.textBoxAddPortion.Location = new System.Drawing.Point(149, 260);
            this.textBoxAddPortion.Name = "textBoxAddPortion";
            this.textBoxAddPortion.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPortion.TabIndex = 20;
            // 
            // textBoxAddPrice
            // 
            this.textBoxAddPrice.Location = new System.Drawing.Point(149, 233);
            this.textBoxAddPrice.Name = "textBoxAddPrice";
            this.textBoxAddPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddPrice.TabIndex = 19;
            // 
            // textBoxAddCapacityNow
            // 
            this.textBoxAddCapacityNow.Location = new System.Drawing.Point(149, 205);
            this.textBoxAddCapacityNow.Name = "textBoxAddCapacityNow";
            this.textBoxAddCapacityNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCapacityNow.TabIndex = 18;
            // 
            // textBoxAddCapacityFull
            // 
            this.textBoxAddCapacityFull.Location = new System.Drawing.Point(149, 178);
            this.textBoxAddCapacityFull.Name = "textBoxAddCapacityFull";
            this.textBoxAddCapacityFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddCapacityFull.TabIndex = 17;
            // 
            // textBoxAddWeightNow
            // 
            this.textBoxAddWeightNow.Location = new System.Drawing.Point(149, 153);
            this.textBoxAddWeightNow.Name = "textBoxAddWeightNow";
            this.textBoxAddWeightNow.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightNow.TabIndex = 16;
            // 
            // textBoxAddWeightEmpty
            // 
            this.textBoxAddWeightEmpty.Location = new System.Drawing.Point(149, 130);
            this.textBoxAddWeightEmpty.Name = "textBoxAddWeightEmpty";
            this.textBoxAddWeightEmpty.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightEmpty.TabIndex = 15;
            // 
            // textBoxAddWeightFull
            // 
            this.textBoxAddWeightFull.Location = new System.Drawing.Point(149, 105);
            this.textBoxAddWeightFull.Name = "textBoxAddWeightFull";
            this.textBoxAddWeightFull.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddWeightFull.TabIndex = 14;
            // 
            // textBoxAddType
            // 
            this.textBoxAddType.Location = new System.Drawing.Point(149, 78);
            this.textBoxAddType.Name = "textBoxAddType";
            this.textBoxAddType.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddType.TabIndex = 13;
            // 
            // textBoxAddSerial
            // 
            this.textBoxAddSerial.Location = new System.Drawing.Point(149, 53);
            this.textBoxAddSerial.Name = "textBoxAddSerial";
            this.textBoxAddSerial.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddSerial.TabIndex = 12;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(149, 28);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddName.TabIndex = 11;
            // 
            // labelAddPortion
            // 
            this.labelAddPortion.AutoSize = true;
            this.labelAddPortion.Location = new System.Drawing.Point(4, 263);
            this.labelAddPortion.Name = "labelAddPortion";
            this.labelAddPortion.Size = new System.Drawing.Size(108, 13);
            this.labelAddPortion.TabIndex = 10;
            this.labelAddPortion.Text = "Размер порции, мл:";
            // 
            // labelAddPrice
            // 
            this.labelAddPrice.AutoSize = true;
            this.labelAddPrice.Location = new System.Drawing.Point(4, 236);
            this.labelAddPrice.Name = "labelAddPrice";
            this.labelAddPrice.Size = new System.Drawing.Size(115, 13);
            this.labelAddPrice.TabIndex = 9;
            this.labelAddPrice.Text = "Цена за порцию, руб:";
            // 
            // labelAddCapacityNow
            // 
            this.labelAddCapacityNow.AutoSize = true;
            this.labelAddCapacityNow.Location = new System.Drawing.Point(4, 208);
            this.labelAddCapacityNow.Name = "labelAddCapacityNow";
            this.labelAddCapacityNow.Size = new System.Drawing.Size(110, 13);
            this.labelAddCapacityNow.TabIndex = 8;
            this.labelAddCapacityNow.Text = "Текущий обьем, мл:";
            // 
            // labelAddCapacityFull
            // 
            this.labelAddCapacityFull.AutoSize = true;
            this.labelAddCapacityFull.Location = new System.Drawing.Point(3, 181);
            this.labelAddCapacityFull.Name = "labelAddCapacityFull";
            this.labelAddCapacityFull.Size = new System.Drawing.Size(148, 13);
            this.labelAddCapacityFull.TabIndex = 7;
            this.labelAddCapacityFull.Text = "Обьем полной бутылки, мл:";
            // 
            // labelAddWeightNow
            // 
            this.labelAddWeightNow.AutoSize = true;
            this.labelAddWeightNow.Location = new System.Drawing.Point(3, 156);
            this.labelAddWeightNow.Name = "labelAddWeightNow";
            this.labelAddWeightNow.Size = new System.Drawing.Size(95, 13);
            this.labelAddWeightNow.TabIndex = 6;
            this.labelAddWeightNow.Text = "Текущий вес, мг:";
            // 
            // labelAddWeightEmpty
            // 
            this.labelAddWeightEmpty.AutoSize = true;
            this.labelAddWeightEmpty.Location = new System.Drawing.Point(4, 133);
            this.labelAddWeightEmpty.Name = "labelAddWeightEmpty";
            this.labelAddWeightEmpty.Size = new System.Drawing.Size(128, 13);
            this.labelAddWeightEmpty.TabIndex = 5;
            this.labelAddWeightEmpty.Text = "Вес пустой бутылки, гр:";
            // 
            // labelAddWeightFull
            // 
            this.labelAddWeightFull.AutoSize = true;
            this.labelAddWeightFull.Location = new System.Drawing.Point(4, 108);
            this.labelAddWeightFull.Name = "labelAddWeightFull";
            this.labelAddWeightFull.Size = new System.Drawing.Size(130, 13);
            this.labelAddWeightFull.TabIndex = 4;
            this.labelAddWeightFull.Text = "Вес полной бутылки, гр:";
            // 
            // labelAddType
            // 
            this.labelAddType.AutoSize = true;
            this.labelAddType.Location = new System.Drawing.Point(4, 81);
            this.labelAddType.Name = "labelAddType";
            this.labelAddType.Size = new System.Drawing.Size(29, 13);
            this.labelAddType.TabIndex = 3;
            this.labelAddType.Text = "Тип:";
            // 
            // labelAddSerial
            // 
            this.labelAddSerial.AutoSize = true;
            this.labelAddSerial.Location = new System.Drawing.Point(4, 56);
            this.labelAddSerial.Name = "labelAddSerial";
            this.labelAddSerial.Size = new System.Drawing.Size(59, 13);
            this.labelAddSerial.TabIndex = 2;
            this.labelAddSerial.Text = "Серийник:";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(4, 31);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(60, 13);
            this.labelAddName.TabIndex = 1;
            this.labelAddName.Text = "Название:";
            // 
            // labelAddPosition
            // 
            this.labelAddPosition.AutoSize = true;
            this.labelAddPosition.Location = new System.Drawing.Point(4, 4);
            this.labelAddPosition.Name = "labelAddPosition";
            this.labelAddPosition.Size = new System.Drawing.Size(155, 13);
            this.labelAddPosition.TabIndex = 0;
            this.labelAddPosition.Text = "Добавить позицию на склад:";
            // 
            // dataGridViewClassification
            // 
            this.dataGridViewClassification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassification.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewClassification.Name = "dataGridViewClassification";
            this.dataGridViewClassification.Size = new System.Drawing.Size(810, 634);
            this.dataGridViewClassification.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(821, 350);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 691);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bario3";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMoney.ResumeLayout(false);
            this.panelMoney.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelScanPosition.ResumeLayout(false);
            this.panelScanPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panelAddPosition.ResumeLayout(false);
            this.panelAddPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelScanPosition;
        private System.Windows.Forms.Button buttonScanPosition;
        private System.Windows.Forms.TextBox textBoxWeightScan;
        private System.Windows.Forms.TextBox textBoxSerialScan;
        private System.Windows.Forms.Label labelWeightScan;
        private System.Windows.Forms.Label labelSerialScan;
        private System.Windows.Forms.Label labelScanposition;
        private System.Windows.Forms.DataGridView dataGridViewInvent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelAddPosition;
        private System.Windows.Forms.Button buttonAddPosition;
        private System.Windows.Forms.TextBox textBoxAddPortion;
        private System.Windows.Forms.TextBox textBoxAddPrice;
        private System.Windows.Forms.TextBox textBoxAddCapacityNow;
        private System.Windows.Forms.TextBox textBoxAddCapacityFull;
        private System.Windows.Forms.TextBox textBoxAddWeightNow;
        private System.Windows.Forms.TextBox textBoxAddWeightEmpty;
        private System.Windows.Forms.TextBox textBoxAddWeightFull;
        private System.Windows.Forms.TextBox textBoxAddType;
        private System.Windows.Forms.TextBox textBoxAddSerial;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Label labelAddPortion;
        private System.Windows.Forms.Label labelAddPrice;
        private System.Windows.Forms.Label labelAddCapacityNow;
        private System.Windows.Forms.Label labelAddCapacityFull;
        private System.Windows.Forms.Label labelAddWeightNow;
        private System.Windows.Forms.Label labelAddWeightEmpty;
        private System.Windows.Forms.Label labelAddWeightFull;
        private System.Windows.Forms.Label labelAddType;
        private System.Windows.Forms.Label labelAddSerial;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.Label labelAddPosition;
        private System.Windows.Forms.DataGridView dataGridViewClassification;
        private System.Windows.Forms.Panel panelMoney;
        private System.Windows.Forms.Label labelMoneyFull;
        private System.Windows.Forms.Label labelMoneyGet;
        private System.Windows.Forms.Label labelMoneyDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMoney;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMoneyDiff;
        private System.Windows.Forms.Label labelMoneyDiffd1d2;
        private System.Windows.Forms.Button buttonMoneyDifference;
        private System.Windows.Forms.DateTimePicker dateTimePickerMoneyDiffDay2;
        private System.Windows.Forms.DateTimePicker dateTimePickerMoneyDiffDay1;
        private System.Windows.Forms.Label labelMoneyDiffDay2;
        private System.Windows.Forms.Label labelMoneyDiffDay1;
        private System.Windows.Forms.Label labelMoneyDifference;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

