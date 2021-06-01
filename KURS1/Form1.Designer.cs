namespace KURS1
{
    partial class Form1
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
            this.DeletePassBTN = new System.Windows.Forms.Button();
            this.EditPassBTN = new System.Windows.Forms.Button();
            this.KemPassTB = new System.Windows.Forms.TextBox();
            this.datePass = new System.Windows.Forms.DateTimePicker();
            this.NomPassTB = new System.Windows.Forms.TextBox();
            this.SerPassTB = new System.Windows.Forms.TextBox();
            this.AddPassBTN = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteClientBTN = new System.Windows.Forms.Button();
            this.EditClientBTN = new System.Windows.Forms.Button();
            this.AddClientBTN = new System.Windows.Forms.Button();
            this.PassIDTB = new System.Windows.Forms.ComboBox();
            this.PhoneClientTB = new System.Windows.Forms.TextBox();
            this.dateClientTP = new System.Windows.Forms.DateTimePicker();
            this.OtchClientTB = new System.Windows.Forms.TextBox();
            this.FamClientTB = new System.Windows.Forms.TextBox();
            this.NameClientTB = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EditVidTovBTN = new System.Windows.Forms.Button();
            this.VidTovDeleteBTN = new System.Windows.Forms.Button();
            this.VidTovaraTB = new System.Windows.Forms.TextBox();
            this.VidTovAddBTN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DeleteMeasureBTN = new System.Windows.Forms.Button();
            this.EditMeasureBTN = new System.Windows.Forms.Button();
            this.AddMeasure = new System.Windows.Forms.Button();
            this.MeasureKrNameTB = new System.Windows.Forms.TextBox();
            this.MeasureNameTB = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ShopKrNazvTB = new System.Windows.Forms.TextBox();
            this.ShopNazvTB = new System.Windows.Forms.TextBox();
            this.ShopEditBTN = new System.Windows.Forms.Button();
            this.ShopDeleteBTN = new System.Windows.Forms.Button();
            this.ShopAddBTN = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MeasureCB = new System.Windows.Forms.ComboBox();
            this.DeleteItemBTN = new System.Windows.Forms.Button();
            this.EditItemBTN = new System.Windows.Forms.Button();
            this.DesTovTB = new System.Windows.Forms.TextBox();
            this.NameTovTB = new System.Windows.Forms.TextBox();
            this.PriceTov = new System.Windows.Forms.NumericUpDown();
            this.AmountTov = new System.Windows.Forms.NumericUpDown();
            this.AddItemBTN = new System.Windows.Forms.Button();
            this.VidTovCB = new System.Windows.Forms.ComboBox();
            this.ShopChangeCB = new System.Windows.Forms.ComboBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewListReturner = new System.Windows.Forms.DataGridView();
            this.addNaklBTN = new System.Windows.Forms.Button();
            this.NaklCB = new System.Windows.Forms.ComboBox();
            this.NomNaklTB = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListReturner)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 501);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeletePassBTN);
            this.tabPage1.Controls.Add(this.EditPassBTN);
            this.tabPage1.Controls.Add(this.KemPassTB);
            this.tabPage1.Controls.Add(this.datePass);
            this.tabPage1.Controls.Add(this.NomPassTB);
            this.tabPage1.Controls.Add(this.SerPassTB);
            this.tabPage1.Controls.Add(this.AddPassBTN);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Паспорт";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeletePassBTN
            // 
            this.DeletePassBTN.Location = new System.Drawing.Point(201, 189);
            this.DeletePassBTN.Name = "DeletePassBTN";
            this.DeletePassBTN.Size = new System.Drawing.Size(75, 23);
            this.DeletePassBTN.TabIndex = 6;
            this.DeletePassBTN.Text = "button2";
            this.DeletePassBTN.UseVisualStyleBackColor = true;
            this.DeletePassBTN.Click += new System.EventHandler(this.DeletePassBTN_Click);
            // 
            // EditPassBTN
            // 
            this.EditPassBTN.Location = new System.Drawing.Point(104, 189);
            this.EditPassBTN.Name = "EditPassBTN";
            this.EditPassBTN.Size = new System.Drawing.Size(75, 23);
            this.EditPassBTN.TabIndex = 5;
            this.EditPassBTN.Text = "button1";
            this.EditPassBTN.UseVisualStyleBackColor = true;
            this.EditPassBTN.Click += new System.EventHandler(this.EditPassBTN_Click);
            // 
            // KemPassTB
            // 
            this.KemPassTB.Location = new System.Drawing.Point(7, 84);
            this.KemPassTB.Name = "KemPassTB";
            this.KemPassTB.Size = new System.Drawing.Size(100, 20);
            this.KemPassTB.TabIndex = 4;
            // 
            // datePass
            // 
            this.datePass.Location = new System.Drawing.Point(7, 58);
            this.datePass.Name = "datePass";
            this.datePass.Size = new System.Drawing.Size(200, 20);
            this.datePass.TabIndex = 3;
            // 
            // NomPassTB
            // 
            this.NomPassTB.Location = new System.Drawing.Point(7, 32);
            this.NomPassTB.Name = "NomPassTB";
            this.NomPassTB.Size = new System.Drawing.Size(100, 20);
            this.NomPassTB.TabIndex = 2;
            // 
            // SerPassTB
            // 
            this.SerPassTB.Location = new System.Drawing.Point(7, 6);
            this.SerPassTB.Name = "SerPassTB";
            this.SerPassTB.Size = new System.Drawing.Size(100, 20);
            this.SerPassTB.TabIndex = 1;
            // 
            // AddPassBTN
            // 
            this.AddPassBTN.Location = new System.Drawing.Point(7, 189);
            this.AddPassBTN.Name = "AddPassBTN";
            this.AddPassBTN.Size = new System.Drawing.Size(75, 23);
            this.AddPassBTN.TabIndex = 0;
            this.AddPassBTN.Text = "button1";
            this.AddPassBTN.UseVisualStyleBackColor = true;
            this.AddPassBTN.Click += new System.EventHandler(this.AddPassBTN_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteClientBTN);
            this.tabPage2.Controls.Add(this.EditClientBTN);
            this.tabPage2.Controls.Add(this.AddClientBTN);
            this.tabPage2.Controls.Add(this.PassIDTB);
            this.tabPage2.Controls.Add(this.PhoneClientTB);
            this.tabPage2.Controls.Add(this.dateClientTP);
            this.tabPage2.Controls.Add(this.OtchClientTB);
            this.tabPage2.Controls.Add(this.FamClientTB);
            this.tabPage2.Controls.Add(this.NameClientTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клиент";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteClientBTN
            // 
            this.DeleteClientBTN.Location = new System.Drawing.Point(214, 182);
            this.DeleteClientBTN.Name = "DeleteClientBTN";
            this.DeleteClientBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteClientBTN.TabIndex = 8;
            this.DeleteClientBTN.Text = "button3";
            this.DeleteClientBTN.UseVisualStyleBackColor = true;
            // 
            // EditClientBTN
            // 
            this.EditClientBTN.Location = new System.Drawing.Point(105, 182);
            this.EditClientBTN.Name = "EditClientBTN";
            this.EditClientBTN.Size = new System.Drawing.Size(75, 23);
            this.EditClientBTN.TabIndex = 7;
            this.EditClientBTN.Text = "button2";
            this.EditClientBTN.UseVisualStyleBackColor = true;
            // 
            // AddClientBTN
            // 
            this.AddClientBTN.Location = new System.Drawing.Point(7, 182);
            this.AddClientBTN.Name = "AddClientBTN";
            this.AddClientBTN.Size = new System.Drawing.Size(75, 23);
            this.AddClientBTN.TabIndex = 6;
            this.AddClientBTN.Text = "button1";
            this.AddClientBTN.UseVisualStyleBackColor = true;
            // 
            // PassIDTB
            // 
            this.PassIDTB.FormattingEnabled = true;
            this.PassIDTB.Location = new System.Drawing.Point(8, 137);
            this.PassIDTB.Name = "PassIDTB";
            this.PassIDTB.Size = new System.Drawing.Size(100, 21);
            this.PassIDTB.TabIndex = 5;
            // 
            // PhoneClientTB
            // 
            this.PhoneClientTB.Location = new System.Drawing.Point(8, 111);
            this.PhoneClientTB.Name = "PhoneClientTB";
            this.PhoneClientTB.Size = new System.Drawing.Size(100, 20);
            this.PhoneClientTB.TabIndex = 4;
            // 
            // dateClientTP
            // 
            this.dateClientTP.Location = new System.Drawing.Point(8, 85);
            this.dateClientTP.Name = "dateClientTP";
            this.dateClientTP.Size = new System.Drawing.Size(100, 20);
            this.dateClientTP.TabIndex = 3;
            // 
            // OtchClientTB
            // 
            this.OtchClientTB.Location = new System.Drawing.Point(8, 59);
            this.OtchClientTB.Name = "OtchClientTB";
            this.OtchClientTB.Size = new System.Drawing.Size(100, 20);
            this.OtchClientTB.TabIndex = 2;
            // 
            // FamClientTB
            // 
            this.FamClientTB.Location = new System.Drawing.Point(7, 32);
            this.FamClientTB.Name = "FamClientTB";
            this.FamClientTB.Size = new System.Drawing.Size(100, 20);
            this.FamClientTB.TabIndex = 1;
            // 
            // NameClientTB
            // 
            this.NameClientTB.Location = new System.Drawing.Point(7, 6);
            this.NameClientTB.Name = "NameClientTB";
            this.NameClientTB.Size = new System.Drawing.Size(100, 20);
            this.NameClientTB.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EditVidTovBTN);
            this.tabPage3.Controls.Add(this.VidTovDeleteBTN);
            this.tabPage3.Controls.Add(this.VidTovaraTB);
            this.tabPage3.Controls.Add(this.VidTovAddBTN);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(606, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вид товара";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EditVidTovBTN
            // 
            this.EditVidTovBTN.Location = new System.Drawing.Point(214, 32);
            this.EditVidTovBTN.Name = "EditVidTovBTN";
            this.EditVidTovBTN.Size = new System.Drawing.Size(75, 23);
            this.EditVidTovBTN.TabIndex = 3;
            this.EditVidTovBTN.Text = "button1";
            this.EditVidTovBTN.UseVisualStyleBackColor = true;
            this.EditVidTovBTN.Click += new System.EventHandler(this.EditVidTovBTN_Click);
            // 
            // VidTovDeleteBTN
            // 
            this.VidTovDeleteBTN.Location = new System.Drawing.Point(107, 32);
            this.VidTovDeleteBTN.Name = "VidTovDeleteBTN";
            this.VidTovDeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.VidTovDeleteBTN.TabIndex = 2;
            this.VidTovDeleteBTN.Text = "button1";
            this.VidTovDeleteBTN.UseVisualStyleBackColor = true;
            this.VidTovDeleteBTN.Click += new System.EventHandler(this.VidTovDeleteBTN_Click);
            // 
            // VidTovaraTB
            // 
            this.VidTovaraTB.Location = new System.Drawing.Point(7, 6);
            this.VidTovaraTB.Name = "VidTovaraTB";
            this.VidTovaraTB.Size = new System.Drawing.Size(100, 20);
            this.VidTovaraTB.TabIndex = 1;
            // 
            // VidTovAddBTN
            // 
            this.VidTovAddBTN.Location = new System.Drawing.Point(7, 32);
            this.VidTovAddBTN.Name = "VidTovAddBTN";
            this.VidTovAddBTN.Size = new System.Drawing.Size(75, 23);
            this.VidTovAddBTN.TabIndex = 0;
            this.VidTovAddBTN.Text = "button1";
            this.VidTovAddBTN.UseVisualStyleBackColor = true;
            this.VidTovAddBTN.Click += new System.EventHandler(this.VidTovAddBTN_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DeleteMeasureBTN);
            this.tabPage4.Controls.Add(this.EditMeasureBTN);
            this.tabPage4.Controls.Add(this.AddMeasure);
            this.tabPage4.Controls.Add(this.MeasureKrNameTB);
            this.tabPage4.Controls.Add(this.MeasureNameTB);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(606, 475);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Единица измерения";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DeleteMeasureBTN
            // 
            this.DeleteMeasureBTN.Location = new System.Drawing.Point(220, 58);
            this.DeleteMeasureBTN.Name = "DeleteMeasureBTN";
            this.DeleteMeasureBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteMeasureBTN.TabIndex = 4;
            this.DeleteMeasureBTN.Text = "button2";
            this.DeleteMeasureBTN.UseVisualStyleBackColor = true;
            this.DeleteMeasureBTN.Click += new System.EventHandler(this.DeleteMeasureBTN_Click);
            // 
            // EditMeasureBTN
            // 
            this.EditMeasureBTN.Location = new System.Drawing.Point(108, 58);
            this.EditMeasureBTN.Name = "EditMeasureBTN";
            this.EditMeasureBTN.Size = new System.Drawing.Size(75, 23);
            this.EditMeasureBTN.TabIndex = 3;
            this.EditMeasureBTN.Text = "button1";
            this.EditMeasureBTN.UseVisualStyleBackColor = true;
            this.EditMeasureBTN.Click += new System.EventHandler(this.EditMeasureBTN_Click);
            // 
            // AddMeasure
            // 
            this.AddMeasure.Location = new System.Drawing.Point(7, 58);
            this.AddMeasure.Name = "AddMeasure";
            this.AddMeasure.Size = new System.Drawing.Size(75, 23);
            this.AddMeasure.TabIndex = 2;
            this.AddMeasure.Text = "button1";
            this.AddMeasure.UseVisualStyleBackColor = true;
            this.AddMeasure.Click += new System.EventHandler(this.AddMeasure_Click);
            // 
            // MeasureKrNameTB
            // 
            this.MeasureKrNameTB.Location = new System.Drawing.Point(7, 32);
            this.MeasureKrNameTB.Name = "MeasureKrNameTB";
            this.MeasureKrNameTB.Size = new System.Drawing.Size(100, 20);
            this.MeasureKrNameTB.TabIndex = 1;
            // 
            // MeasureNameTB
            // 
            this.MeasureNameTB.Location = new System.Drawing.Point(7, 6);
            this.MeasureNameTB.Name = "MeasureNameTB";
            this.MeasureNameTB.Size = new System.Drawing.Size(100, 20);
            this.MeasureNameTB.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ShopKrNazvTB);
            this.tabPage5.Controls.Add(this.ShopNazvTB);
            this.tabPage5.Controls.Add(this.ShopEditBTN);
            this.tabPage5.Controls.Add(this.ShopDeleteBTN);
            this.tabPage5.Controls.Add(this.ShopAddBTN);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(606, 475);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Магазин";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ShopKrNazvTB
            // 
            this.ShopKrNazvTB.Location = new System.Drawing.Point(8, 33);
            this.ShopKrNazvTB.Name = "ShopKrNazvTB";
            this.ShopKrNazvTB.Size = new System.Drawing.Size(100, 20);
            this.ShopKrNazvTB.TabIndex = 4;
            // 
            // ShopNazvTB
            // 
            this.ShopNazvTB.Location = new System.Drawing.Point(7, 6);
            this.ShopNazvTB.Name = "ShopNazvTB";
            this.ShopNazvTB.Size = new System.Drawing.Size(100, 20);
            this.ShopNazvTB.TabIndex = 3;
            // 
            // ShopEditBTN
            // 
            this.ShopEditBTN.Location = new System.Drawing.Point(202, 71);
            this.ShopEditBTN.Name = "ShopEditBTN";
            this.ShopEditBTN.Size = new System.Drawing.Size(75, 23);
            this.ShopEditBTN.TabIndex = 2;
            this.ShopEditBTN.Text = "button3";
            this.ShopEditBTN.UseVisualStyleBackColor = true;
            this.ShopEditBTN.Click += new System.EventHandler(this.ShopEditBTN_Click);
            // 
            // ShopDeleteBTN
            // 
            this.ShopDeleteBTN.Location = new System.Drawing.Point(105, 71);
            this.ShopDeleteBTN.Name = "ShopDeleteBTN";
            this.ShopDeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.ShopDeleteBTN.TabIndex = 1;
            this.ShopDeleteBTN.Text = "button2";
            this.ShopDeleteBTN.UseVisualStyleBackColor = true;
            this.ShopDeleteBTN.Click += new System.EventHandler(this.ShopDeleteBTN_Click);
            // 
            // ShopAddBTN
            // 
            this.ShopAddBTN.Location = new System.Drawing.Point(8, 71);
            this.ShopAddBTN.Name = "ShopAddBTN";
            this.ShopAddBTN.Size = new System.Drawing.Size(75, 23);
            this.ShopAddBTN.TabIndex = 0;
            this.ShopAddBTN.Text = "button1";
            this.ShopAddBTN.UseVisualStyleBackColor = true;
            this.ShopAddBTN.Click += new System.EventHandler(this.ShopAddBTN_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(606, 475);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Накладная";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.NomNaklTB);
            this.tabPage8.Controls.Add(this.NaklCB);
            this.tabPage8.Controls.Add(this.addNaklBTN);
            this.tabPage8.Controls.Add(this.dateTimePicker1);
            this.tabPage8.Controls.Add(this.MeasureCB);
            this.tabPage8.Controls.Add(this.DeleteItemBTN);
            this.tabPage8.Controls.Add(this.EditItemBTN);
            this.tabPage8.Controls.Add(this.DesTovTB);
            this.tabPage8.Controls.Add(this.NameTovTB);
            this.tabPage8.Controls.Add(this.PriceTov);
            this.tabPage8.Controls.Add(this.AmountTov);
            this.tabPage8.Controls.Add(this.AddItemBTN);
            this.tabPage8.Controls.Add(this.VidTovCB);
            this.tabPage8.Controls.Add(this.ShopChangeCB);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(606, 475);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Товар";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // MeasureCB
            // 
            this.MeasureCB.FormattingEnabled = true;
            this.MeasureCB.Location = new System.Drawing.Point(157, 6);
            this.MeasureCB.Name = "MeasureCB";
            this.MeasureCB.Size = new System.Drawing.Size(121, 21);
            this.MeasureCB.TabIndex = 9;
            // 
            // DeleteItemBTN
            // 
            this.DeleteItemBTN.Location = new System.Drawing.Point(203, 295);
            this.DeleteItemBTN.Name = "DeleteItemBTN";
            this.DeleteItemBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteItemBTN.TabIndex = 8;
            this.DeleteItemBTN.Text = "button3";
            this.DeleteItemBTN.UseVisualStyleBackColor = true;
            this.DeleteItemBTN.Click += new System.EventHandler(this.DeleteItemBTN_Click);
            // 
            // EditItemBTN
            // 
            this.EditItemBTN.Location = new System.Drawing.Point(104, 295);
            this.EditItemBTN.Name = "EditItemBTN";
            this.EditItemBTN.Size = new System.Drawing.Size(75, 23);
            this.EditItemBTN.TabIndex = 7;
            this.EditItemBTN.Text = "button2";
            this.EditItemBTN.UseVisualStyleBackColor = true;
            this.EditItemBTN.Click += new System.EventHandler(this.EditItemBTN_Click);
            // 
            // DesTovTB
            // 
            this.DesTovTB.Location = new System.Drawing.Point(8, 88);
            this.DesTovTB.Name = "DesTovTB";
            this.DesTovTB.Size = new System.Drawing.Size(100, 20);
            this.DesTovTB.TabIndex = 6;
            // 
            // NameTovTB
            // 
            this.NameTovTB.Location = new System.Drawing.Point(8, 61);
            this.NameTovTB.Name = "NameTovTB";
            this.NameTovTB.Size = new System.Drawing.Size(100, 20);
            this.NameTovTB.TabIndex = 5;
            // 
            // PriceTov
            // 
            this.PriceTov.Location = new System.Drawing.Point(8, 162);
            this.PriceTov.Name = "PriceTov";
            this.PriceTov.Size = new System.Drawing.Size(120, 20);
            this.PriceTov.TabIndex = 4;
            // 
            // AmountTov
            // 
            this.AmountTov.Location = new System.Drawing.Point(8, 136);
            this.AmountTov.Name = "AmountTov";
            this.AmountTov.Size = new System.Drawing.Size(120, 20);
            this.AmountTov.TabIndex = 3;
            // 
            // AddItemBTN
            // 
            this.AddItemBTN.Location = new System.Drawing.Point(7, 295);
            this.AddItemBTN.Name = "AddItemBTN";
            this.AddItemBTN.Size = new System.Drawing.Size(75, 23);
            this.AddItemBTN.TabIndex = 2;
            this.AddItemBTN.Text = "button1";
            this.AddItemBTN.UseVisualStyleBackColor = true;
            this.AddItemBTN.Click += new System.EventHandler(this.AddItemBTN_Click);
            // 
            // VidTovCB
            // 
            this.VidTovCB.FormattingEnabled = true;
            this.VidTovCB.Location = new System.Drawing.Point(7, 33);
            this.VidTovCB.Name = "VidTovCB";
            this.VidTovCB.Size = new System.Drawing.Size(121, 21);
            this.VidTovCB.TabIndex = 1;
            // 
            // ShopChangeCB
            // 
            this.ShopChangeCB.FormattingEnabled = true;
            this.ShopChangeCB.Location = new System.Drawing.Point(7, 6);
            this.ShopChangeCB.Name = "ShopChangeCB";
            this.ShopChangeCB.Size = new System.Drawing.Size(121, 21);
            this.ShopChangeCB.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(606, 475);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Учет_товара";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(982, 383);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 95);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(621, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(330, 476);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(982, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewListReturner
            // 
            this.dataGridViewListReturner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListReturner.Location = new System.Drawing.Point(982, 193);
            this.dataGridViewListReturner.Name = "dataGridViewListReturner";
            this.dataGridViewListReturner.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewListReturner.TabIndex = 3;
            // 
            // addNaklBTN
            // 
            this.addNaklBTN.Location = new System.Drawing.Point(400, 87);
            this.addNaklBTN.Name = "addNaklBTN";
            this.addNaklBTN.Size = new System.Drawing.Size(75, 23);
            this.addNaklBTN.TabIndex = 11;
            this.addNaklBTN.Text = "button1";
            this.addNaklBTN.UseVisualStyleBackColor = true;
            this.addNaklBTN.Click += new System.EventHandler(this.addNaklBTN_Click);
            // 
            // NaklCB
            // 
            this.NaklCB.FormattingEnabled = true;
            this.NaklCB.Location = new System.Drawing.Point(157, 33);
            this.NaklCB.Name = "NaklCB";
            this.NaklCB.Size = new System.Drawing.Size(121, 21);
            this.NaklCB.TabIndex = 12;
            // 
            // NomNaklTB
            // 
            this.NomNaklTB.Location = new System.Drawing.Point(418, 33);
            this.NomNaklTB.Name = "NomNaklTB";
            this.NomNaklTB.Size = new System.Drawing.Size(100, 20);
            this.NomNaklTB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 508);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridViewListReturner);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListReturner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddPassBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox VidTovaraTB;
        private System.Windows.Forms.Button VidTovAddBTN;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button VidTovDeleteBTN;
        private System.Windows.Forms.Button EditVidTovBTN;
        private System.Windows.Forms.TextBox ShopKrNazvTB;
        private System.Windows.Forms.TextBox ShopNazvTB;
        private System.Windows.Forms.Button ShopEditBTN;
        private System.Windows.Forms.Button ShopDeleteBTN;
        private System.Windows.Forms.Button ShopAddBTN;
        private System.Windows.Forms.Button DeleteItemBTN;
        private System.Windows.Forms.Button EditItemBTN;
        private System.Windows.Forms.TextBox DesTovTB;
        private System.Windows.Forms.TextBox NameTovTB;
        private System.Windows.Forms.NumericUpDown PriceTov;
        private System.Windows.Forms.NumericUpDown AmountTov;
        private System.Windows.Forms.Button AddItemBTN;
        private System.Windows.Forms.ComboBox VidTovCB;
        private System.Windows.Forms.ComboBox ShopChangeCB;
        private System.Windows.Forms.DataGridView dataGridViewListReturner;
        private System.Windows.Forms.Button AddMeasure;
        private System.Windows.Forms.TextBox MeasureKrNameTB;
        private System.Windows.Forms.TextBox MeasureNameTB;
        private System.Windows.Forms.ComboBox MeasureCB;
        private System.Windows.Forms.TextBox KemPassTB;
        private System.Windows.Forms.DateTimePicker datePass;
        private System.Windows.Forms.TextBox NomPassTB;
        private System.Windows.Forms.TextBox SerPassTB;
        private System.Windows.Forms.Button DeletePassBTN;
        private System.Windows.Forms.Button EditPassBTN;
        private System.Windows.Forms.ComboBox PassIDTB;
        private System.Windows.Forms.TextBox PhoneClientTB;
        private System.Windows.Forms.DateTimePicker dateClientTP;
        private System.Windows.Forms.TextBox OtchClientTB;
        private System.Windows.Forms.TextBox FamClientTB;
        private System.Windows.Forms.TextBox NameClientTB;
        private System.Windows.Forms.Button DeleteClientBTN;
        private System.Windows.Forms.Button EditClientBTN;
        private System.Windows.Forms.Button AddClientBTN;
        private System.Windows.Forms.Button DeleteMeasureBTN;
        private System.Windows.Forms.Button EditMeasureBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox NaklCB;
        private System.Windows.Forms.Button addNaklBTN;
        private System.Windows.Forms.TextBox NomNaklTB;
    }
}

