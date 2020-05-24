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
    public partial class Passports : Form
    {
        public Passports()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM passport";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id_passport", table.Rows.Count - 1].Value = reader[0].ToString();
                table["series", table.Rows.Count - 1].Value = reader[1].ToString();
                table["number", table.Rows.Count - 1].Value = reader[2].ToString();
                table["issued", table.Rows.Count - 1].Value = reader[3].ToString();
                table["birthplace", table.Rows.Count - 1].Value = reader[4].ToString();
                table["code", table.Rows.Count - 1].Value = reader[5].ToString();
                table["date", table.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddPassport form = new AddPassport();
            form.Show();
        }
    }
}
