using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace Project_XT_v1_0_0
{
    public class Database
    {
        private readonly SQLiteConnection dbConnection;

        public Database(string dbPath)
        {
            string connectionString = $"Data Source={dbPath}; FailIfMissing=false";
            dbConnection = new SQLiteConnection(connectionString);
        }

        public void OpenDatabase()
        {
            dbConnection.Open();
        }

        public void CloseDatabase()
        {
            dbConnection.Close();
        }

        public void ExecuteNonQuery(string commandString)
        {
            this.OpenDatabase();
            SQLiteCommand command = new(dbConnection)
            {
                CommandText = commandString
            };
            command.ExecuteNonQuery();
            this.CloseDatabase();
        }

        public DataTable GetData(string queryString)
        {
            SQLiteDataAdapter da = new(queryString, dbConnection);
            DataTable dt = new();
            da.Fill(dt);
            return dt;
        }

        //public void CreateTable(params string[] components)
        //{
        //    string query = "CREATE TABLE IF NOT EXISTS table_name (" +
        //            "column1 datatype [constraints]," +
        //            "column2 datatype [constraints]," +
        //        ");";

        //    MessageBox.Show(query);
        //}
    }
}
