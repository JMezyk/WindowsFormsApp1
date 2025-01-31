using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region FieldDefinitions
           
        #endregion
      
        #region Constructors
        public Form1()
        {
            InitializeComponent();
            DBconnect();
        }

        ~Form1()
        {
            
        }
        #endregion
        
        #region DataBaseConnectivity
        private void DBconnect() 
        {
            SqliteConnection connection = new SqliteConnection("Data Source=e:\\repos\\database\\sample_database.db");
            try { 
                connection.Open();
                
                connection.Close();
            } catch (SqliteException e) {
                Console.WriteLine(e.Message); // Display message
            }
            return;
        }
        #endregion
    }
}
