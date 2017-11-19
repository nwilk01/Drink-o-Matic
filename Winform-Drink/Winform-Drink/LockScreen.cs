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

namespace Winform_Drink
{
    public partial class LockScreen : Form
    {
        StringBuilder pin = new StringBuilder();
        public LockScreen()
        {
            InitializeComponent();
            Pin.TextChanged += codecheck;
        }

        private void codecheck(object sender, EventArgs e)
        {
            if (Pin.Text.Length == 4)
            {
                bool success = pincheck(pin.ToString());
                Pin.Text = string.Empty;                
                if(success)
                {
                    HomeScreen home = new HomeScreen(pin.ToString());
                    pin.Clear();
                    this.Hide();
                    var display = home.ShowDialog();
                }
                pin.Clear();
            }
        }

        private bool pincheck(string pin)
        {
            string query = "SELECT COUNT(Pin) AS Exist FROM Users WHERE Pin = '" + pin + "';";
            DataTable result = new DataTable();
            var connection = ConnectionFactory.Create();
            MySqlDataAdapter datacmd = new MySqlDataAdapter(query, connection);
            datacmd.Fill(result);
            connection.Close();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                if (Convert.ToInt32(row["Exist"].ToString()) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void checkdatabase(string pin)
        {
            //var connection = ConnectionFactory.Create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pin.Append('1');
            Pin.AppendText("*");                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pin.Append('2');
            Pin.AppendText("*");            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pin.Append('3');
            Pin.AppendText("*");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pin.Append('4');
            Pin.AppendText("*");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pin.Append('5');
            Pin.AppendText("*");            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pin.Append('6');
            Pin.AppendText("*");            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pin.Append('7');
            Pin.AppendText("*");            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pin.Append('8');
            Pin.AppendText("*");            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pin.Append('9');
            Pin.AppendText("*");            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            pin.Append('0');
            Pin.AppendText("*");            
        }
    }
}
