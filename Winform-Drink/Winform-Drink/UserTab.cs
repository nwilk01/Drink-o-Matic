using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Winform_Drink
{
    public partial class UserTab : Form
    {
        string ID;
        public UserTab(string User_ID)
        {
            InitializeComponent();
            ID = User_ID;
            initializeName();
            initializeTab();
            initializeHistory();
        }

        private void initializeName()
        {
            string query = "SELECT Fname, Lname FROM Payment WHERE ID ='" + ID + "';";
            DataTable info = new DataTable();
            var connection = ConnectionFactory.Create();
            MySqlDataAdapter namecmd = new MySqlDataAdapter(query, connection);
            namecmd.Fill(info);
            connection.Close();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                DataRow row = info.Rows[i];
                username.Text = row["Fname"] + " " + row["Lname"];
            }
        }

        private void initializeTab()
        {
            string query = "SELECT Tab FROM Users WHERE Pay_ID ='" + ID + "';";
            DataTable info = new DataTable();
            var connection = ConnectionFactory.Create();
            MySqlDataAdapter tabcmd = new MySqlDataAdapter(query, connection);
            tabcmd.Fill(info);
            connection.Close();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                DataRow row = info.Rows[i];
                double amount = Convert.ToDouble(row["Tab"].ToString());
                tab.Text = String.Format("{0:0.00}", amount);
            }
        }

        private void initializeHistory()
        {
            string[] drinks= { };
            string query = "SELECT DrinkHistory FROM Users WHERE Pay_ID ='" + ID + "';";
            DataTable info = new DataTable();
            var connection = ConnectionFactory.Create();
            MySqlDataAdapter historycmd = new MySqlDataAdapter(query, connection);
            historycmd.Fill(info);
            connection.Close();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                DataRow row = info.Rows[i];
                drinks = row["DrinkHistory"].ToString().Split(',');
            }

            for (int j = 0; j < drinks.Length; j++)
            {
                ListViewItem item = new ListViewItem(drinks[j]);
                item.Font = new System.Drawing.Font("Arial", 12);
                history.Items.Add(item);
            }
        }

        private void history_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
