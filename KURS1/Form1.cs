using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace KURS1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ComboUpdates();
        }

        string Credentials =
            "Server = localhost;" +
            "Integrated security = SSPI;" +
            "database = Анализ_Продаж;";
        #region паспорт
        private void AddPassBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addPass(SerPassTB.Text, NomPassTB.Text, datePass.Value, KemPassTB.Text));
        }
        private void EditPassBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editPass(SerPassTB.Text, NomPassTB.Text, datePass.Value, KemPassTB.Text, tempeID)); tempeID = -1; }
        }
    

        private void DeletePassBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deletePass(tempeID)); tempeID = -1; }
        }
        #endregion
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {  
            Works works = new Works(Credentials);
            switch(tabControl1.SelectedIndex)
            {
                case 0: selectedTable = "Паспорт"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Серия, Номер, Дата_выдачи, Кем_выдан", "Паспорт", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Паспорт", null).Tables[0].DefaultView; break;
                case 1: selectedTable = "Клиент"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Фамилия, Имя, Отчество, Дата_рождения, Номер_телефона, Размер_Скидки", "Клиент", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Клиент", null).Tables[0].DefaultView; break;
                case 2: selectedTable = "Вид_товара"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Вид_Товара", "Вид_товара", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Вид_товара", null).Tables[0].DefaultView; break;
                case 3: selectedTable = "Единица_измерения"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Наименование, Краткое_Наименование", "Единица_измерения", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Единица_измерения", null).Tables[0].DefaultView; break;
                case 4: selectedTable = "Магазин"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Название, Краткое_Название", "Магазин", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Магазин", null).Tables[0].DefaultView; break;
                case 5: selectedTable = "Накладная"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Дата_Накладной, Номер_Накладной", "Накладная", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Накладная", null).Tables[0].DefaultView; break;
                //case 6: selectedTable = "Поступление"; dataGridView1.DataSource = works.dataSet("Дата_поступления, Код_накладной", "Поступление", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Поступление", null).Tables[0].DefaultView; break;
                case 6: selectedTable = "Товар"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Товар.Наименование, Количество, Цена, Описание, Вид_Товара.Вид_Товара as ВидТовара, Единица_Измерения.Наименование as НаименованиеЕдИзмер, Единица_Измерения.Краткое_Наименование as КрНаименованиеЕдИзмер, Накладная.Номер_Накладной as НомерНакладной", "Товар, Вид_Товара, Единица_Измерения, Товары_Накладных, Накладная", "WHERE Товар.TypeID = Вид_Товара.Код AND Товар.MeasureID = Единица_Измерения.Код AND Товар.Код = Товары_Накладных.Код_Товара AND Накладная.Код = Товары_Накладных.Код_Накладной").Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Товар", null).Tables[0].DefaultView; break;
                case 7: selectedTable = "Учет_Товара"; ComboUpdates(); dataGridView1.DataSource = works.dataSet("Дата_Продажи, Количество", "Учет_Товара", null).Tables[0].DefaultView; dataGridView2.DataSource = works.dataSet("*", "Учет_товара", null).Tables[0].DefaultView; break;

            }
        }

        void ComboUpdates()
        {
            VidTovCB.Items.Clear(); // При добавлении нас.пункта
            ShopChangeCB.Items.Clear();
            MeasureCB.Items.Clear();
            NaklCB.Items.Clear(); 
            MagazCB.Items.Clear();
            ClientCB.Items.Clear();
            PassIDCB.Items.Clear();
            foreach (string i in BufferListUpdate(0))
            {
                VidTovCB.Items.Add(i);
            }
            foreach(string i in BufferListUpdate(1))
            {
                MeasureCB.Items.Add(i);
            }
            foreach (string i in BufferListUpdate(2))
            {
                ShopChangeCB.Items.Add(i);
                MagazCB.Items.Add(i);
            }
            foreach (string i in BufferListUpdate(3))
            {
                NaklCB.Items.Add(i);
            }
            foreach (string i in BufferListUpdate(4))
            {
                ClientCB.Items.Add(i);
            }
            foreach (string i in BufferListUpdate(5))
            {
                PassIDCB.Items.Add(i);
            }

        }
        DataGridViewCellEventArgs e;
        List<string> BufferListUpdate(int Index)
        {
            Works database = new Works(Credentials);
            List<string> Temp = new List<string>();
            switch (Index)
            {
                case 0: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Вид_Товара", "Вид_Товара", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case 1: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Наименование", "Единица_измерения", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case 2: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Название", "Магазин", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case 3: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Номер_накладной", "Накладная", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case 4: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Фамилия", "Клиент", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
                case 5: // Заполнение видов товара
                    dataGridViewListReturner.DataSource = database.ReturnTable("Номер", "Паспорт", null).Tables[0].DefaultView;
                    for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
                    {
                        Temp.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
                    }
                    break;

            }
            return Temp;
        }

        int tempeID = -1;
        string selectedTable;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Works database = new Works(Credentials);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tempeID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            switch (selectedTable)
            {
                case "Вид_товара": VidTovaraTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); break;
                case "Магазин":
                    {
                        ShopNazvTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ShopKrNazvTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); break;
                    }
                case "Товар":
                    {
                        ShopChangeCB.Text = dataGridViewListReturner.Rows[e.RowIndex].Cells[0].Value.ToString();
                        MeasureCB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                        VidTovCB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        NameTovTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        DesTovTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        AmountTov.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        NaklCB.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                        PriceTov.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value); break;
                    }
                case "Паспорт":
                    {
                        SerPassTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        NomPassTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        datePass.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        KemPassTB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); break;
                    }
                case "Единица_измерения":
                    {
                        MeasureNameTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        MeasureKrNameTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); break;
                    }
                case "Накладная":
                    {
                        NomNaklTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                        break;
                    }
                case "Клиент":
                    {
                        NameClientTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        FamClientTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        OtchClientTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dateClientTP.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                        PhoneClientTB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                        PassIDCB.SelectedItem = dataGridViewListReturner.Rows[e.RowIndex].Cells[0].Value.ToString();
                        break;
                    }
            }
        }
        #region вид товара
        private void VidTovAddBTN_Click_1(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addVidTov(VidTovaraTB.Text));
        }
        private void VidTovDeleteBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deleteVidTov(tempeID)); tempeID = -1; }
        }

        private void EditVidTovBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editVidTov(VidTovaraTB.Text, tempeID)); tempeID = -1; }
        }
        #endregion
        #region магазин
        private void ShopAddBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addShop(ShopNazvTB.Text, ShopKrNazvTB.Text));
        }

        private void ShopDeleteBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deleteShop(tempeID)); tempeID = -1; }
        }

        private void ShopEditBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editShop(ShopNazvTB.Text, ShopKrNazvTB.Text, tempeID)); tempeID = -1; }
        }
        #endregion 
        #region товар

        int GetAddingItemID()
        {
            Works database = new Works(Credentials);
            dataGridViewListReturner.DataSource = database.dataSet("Код", "Товар", "WHERE Код = (SELECT MAX(Код) FROM Товар)").Tables[0].DefaultView;
            return Convert.ToInt32(dataGridViewListReturner.Rows[0].Cells[0].Value);
        }

        private void AddItemBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            int li = GetDirCode("Вид_Товара", VidTovCB.SelectedItem.ToString(), 1);
            int li1 = GetDirCode("Единица_измерения", MeasureCB.SelectedItem.ToString(), 1);
            listBox1.Items.Add(database.addItem(NameTovTB.Text, DesTovTB.Text, Convert.ToInt32(AmountTov.Value), Convert.ToInt32(PriceTov.Value),li, li1));
            listBox1.Items.Add(database.ConnectItemNakl(GetAddingItemID(), GetDirCode("Накладная", NaklCB.SelectedItem.ToString(), 2)));
            listBox1.Items.Add(database.addTable(GetDirCode("Магазин", ShopChangeCB.SelectedItem.ToString(), 1), GetDirCode("Товар", NameTovTB.Text, 1)));

        }

        private void EditItemBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editItem(NameTovTB.Text, DesTovTB.Text, Convert.ToInt32(AmountTov.Value), Convert.ToInt32(PriceTov.Value), tempeID)); tempeID = -1; }
        }
        private void DeleteItemBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deleteItem(tempeID)); tempeID = -1; }
        }
        #endregion

        // GetDirCode("Магазин", ShopChangeCB.SelectedItem.ToString(), 0), GetDirCode("Вид_Товара", VidTovCB.SelectedItem.ToString(), 0),
        int GetDirCode(string Table, string ToFind, int cell) // Вернуть код (итератор) из справочника
        {
            Works database = new Works(Credentials);
            dataGridViewListReturner.DataSource = database.ReturnTable("*", Table, null).Tables[0].DefaultView;
            for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
            {
                if (dataGridViewListReturner.Rows[i].Cells[cell].Value.ToString() == ToFind)
                {
                    return Convert.ToInt32(dataGridViewListReturner.Rows[i].Cells[0].Value);
                }
            }
            return -1;
        }
        #region Единица измерения
        private void AddMeasure_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addMeasure(MeasureNameTB.Text, MeasureKrNameTB.Text));
        }

        private void EditMeasureBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editMeasure(MeasureNameTB.Text, MeasureKrNameTB.Text, tempeID)); tempeID = -1; }
        }

        private void DeleteMeasureBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deleteMeasure(tempeID)); tempeID = -1; }
        }
        #endregion
        #region Накладная
        private void addNaklBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addNakl(dateTimePicker1.Value, NomNaklTB.Text));
        }
        private void EditNaklBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.editNakl(NomNaklTB.Text.ToString(), dateTimePicker1.Value, tempeID)); tempeID = -1; }
        }

        private void DeleteNaklBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            if (tempeID != -1) { listBox1.Items.Add(database.deleteNakl(tempeID)); tempeID = -1; }
        }
        #endregion
        private void BuyBTN_Click(object sender, EventArgs e)
        {
           
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.buyItem(Convert.ToInt32(numericUpDown1.Value), GetDirCode("Товар", TovarCB.SelectedItem.ToString(), 1)));
            //listBox1.Items.Add(database.Sum()
        }

        private void MagazCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            TovarCB.Items.Clear();
            int shopID = GetDirCode("Магазин", MagazCB.SelectedItem.ToString(), 1);
            dataGridViewListReturner.DataSource = database.ReturnTable("Наименование", "Товар, Магазин_и_Товар", $"WHERE ShopID = {shopID} AND Товар.Код = ItemID").Tables[0].DefaultView;
            for (int i = 0; i < dataGridViewListReturner.Rows.Count - 1; i++)
            {
                TovarCB.Items.Add(dataGridViewListReturner.Rows[i].Cells[0].Value.ToString());
            }
          
        }

        private void TovarCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            int tovarID = GetDirCode("Товар", TovarCB.SelectedItem.ToString(), 1);
            dataGridViewListReturner.DataSource = database.ReturnTable("Количество", "Товар", $"WHERE Код = {tovarID} ").Tables[0].DefaultView;
            numericUpDown1.Maximum = Convert.ToInt32(dataGridViewListReturner.Rows[0].Cells[0].Value.ToString());
        }

        private void AddClientBTN_Click(object sender, EventArgs e)
        {
            Works database = new Works(Credentials);
            listBox1.Items.Add(database.addClient(NameClientTB.Text, FamClientTB.Text, OtchClientTB.Text, dateClientTP.Value, Convert.ToInt64(PhoneClientTB.Text), GetDirCode("Паспорт",PassIDCB.SelectedItem.ToString(), 2)));
        }

       
    }
}
    

