using System.Data.SqlClient;
using System.Data;
using System;

namespace KURS1
{
    class Works
    {
        string Credentials = string.Empty;
        SqlConnection connection;

        public Works(string Credentials)
        {
            this.Credentials = Credentials;
            connection = new SqlConnection(Credentials);
            connection.Open(); GC.SuppressFinalize(this);
        }
        ~Works()
        {
            connection.Close();
        }
        public DataSet dataSet(string Columns, string Tables, string Arguments)
        {
            DataSet Temp = new DataSet();
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {Tables} {Arguments}", connection);
            sqlData.Fill(Temp);
            return Temp;
        }
        public string addPass(string ser, string nom, DateTime date, string kem)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Паспорт (Серия, Номер, Дата_Выдачи, Кем_выдан) VALUES ('{ser}', '{nom}', '{date}', '{kem}')", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public string deletePass(int ID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Паспорт WHERE Код = {ID}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string editPass(string edit, string edit1, DateTime edit2, string edit3, int id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE Паспорт SET Серия = '{edit}', Номер = '{edit1}', Дата_Выдачи = '{edit2}', Кем_выдан = '{edit3}' WHERE Код = {id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public string addVidTov(string VidTov)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Вид_Товара (Вид_товара) VALUES ('{VidTov}')", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public string deleteVidTov(int ID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Вид_товара WHERE Код = {ID}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string editVidTov(string edit, int id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE Вид_товара SET Вид_товара = '{edit}' WHERE Код = {id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

        public string addShop(string Nazv, string KrNazv)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Магазин (Название, Краткое_название) VALUES ('{Nazv}', '{KrNazv}')", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string editShop(string edit, string edit1, int id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE Магазин SET Название = '{edit}', Краткое_Название = '{edit1}' WHERE Код = {id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string deleteShop(int ID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Магазин WHERE Код = {ID}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string addItem(string name, string opis, int kol, int price, int typeID, int measureID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Товар (Наименование, Описание, Количество, Цена, TypeID, MeasureID ) VALUES ('{name}', '{opis}', {kol}, {price}, {typeID}, {measureID})", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string editItem(string edit, string edit1, int edit2, int edit3, int id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE Товар SET Наименование = '{edit}', Описание = '{edit1}', Количество = {edit2}, Цена = {edit3} WHERE Код = {id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string deleteItem(int ID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Товар WHERE Код = {ID}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public DataSet ReturnTable(string Columns, string TablesName, string Arguments)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter($"SELECT {Columns} FROM {TablesName} {Arguments}", connection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet);
            return dataSet;
        }
        public string addMeasure(string name, string krName)
        {
            try
            {
                SqlCommand command = new SqlCommand($"INSERT INTO Единица_Измерения (Наименование, Краткое_наименование ) VALUES ('{name}', '{krName}')", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string editMeasure(string edit, string edit1, int id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"UPDATE Единица_Измерения SET Наименование = '{edit}', Краткое_наименование = '{edit1}', WHERE Код = {id};", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }
        public string deleteMeasure(int ID)
        {
            try
            {
                SqlCommand command = new SqlCommand($"DELETE FROM Единица_Измерения WHERE Код = {ID}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public string returnMeasureName(string id)
        {
            try
            {
                SqlCommand command = new SqlCommand($"SELECT Вид_товара FROM Вид_товара WHERE Код = {id}", connection);
                return $"Команда выполнена. Задействовано строк таблицы: {command.ExecuteNonQuery()}";
            }
            catch (Exception e)
            {

                return e.ToString();
            }
        }

    }
}
