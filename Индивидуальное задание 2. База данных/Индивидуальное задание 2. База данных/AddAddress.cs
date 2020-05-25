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
