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

namespace Индивидуальное_задание_2.База_данных
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Out_Click(object sender, EventArgs e)
        {
            MySqlConnection connection =  Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM client";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["name", table.Rows.Count - 1].Value = reader[0].ToString();
                table["sex", table.Rows.Count - 1].Value = reader[1].ToString();
                table["dateOfBirth", table.Rows.Count - 1].Value = reader[2].ToString();
                table["pasport", table.Rows.Count - 1].Value = reader[3].ToString();
                table["jobPlace", table.Rows.Count - 1].Value = reader[4].ToString();
                table["address", table.Rows.Count - 1].Value = reader[5].ToString();
                table["phoneNumber", table.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            
        }
    }
}