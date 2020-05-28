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
    public partial class AddAddress : Form
    {
        public AddAddress(DataGridView table)
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            label6.Font = new Font("Times New Roman", 10, label6.Font.Style);
            label7.Font = new Font("Times New Roman", 10, FontStyle.Italic);
            add.Font = new Font("Times New Roman", 10, label7.Font.Style);
            country.Font = new Font("Times New Roman", 10, country.Font.Style);
            city.Font = new Font("Times New Roman", 10, city.Font.Style);
            street.Font = new Font("Times New Roman", 10, street.Font.Style);
            number.Font = new Font("Times New Roman", 10, number.Font.Style);
            flat.Font = new Font("Times New Roman", 10, flat.Font.Style);
            postcode.Font = new Font("Times New Roman", 10, postcode.Font.Style);
            this.table = table;
        }

        DataGridView table;
        private void add_Click(object sender, EventArgs e)
        {
            if (country.Text != "" && city.Text != "" && street.Text != "" && number.Text != "" && postcode.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`address` (`country` ,`city` ,`street`, `number` ,`flat` ,`postcode`)" +
                "VALUES('" + country.Text + "', '" + city.Text + "', '" + street.Text + "', '" + number.Text + "', '" + flat.Text +
                "', '" + postcode.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM address";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();

                while (reader.Read())
                {
                    table["id", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["country", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["city", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["street", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["number2", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["flat", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["postcode", table.Rows.Count - 1].Value = reader[6].ToString();
                }
                reader.Close();
                connection.Close();
                country.Clear();
                city.Clear();
                street.Clear();
                number.Clear();
                flat.Clear();
                postcode.Clear();
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
