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
        public AddAddress()
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
        }

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

                connection.Close();
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
