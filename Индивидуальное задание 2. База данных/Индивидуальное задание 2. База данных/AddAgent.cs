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
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surname.Text != "" && name.Text != "" && middle_name.Text != "" && sex.Text != "" && date.Text != "" && passport.Text != "" && 
                id_address.Text != "" && phone_number.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`address` (`surname` ,`name` ,`middle_name`, `sex` ,`date` ,`passport`, 'phone_number', 'id_address')" +
                "VALUES('" + surname.Text + "', '" + name.Text + "', '" + middle_name.Text + "', '" + sex.Text + "', '" + date.Text +
                "', '" + passport.Text + "', '" + phone_number.Text + "', '" + id_address.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                connection.Close();
            }
            else MessageBox.Show("Необходимо заполнить все поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
