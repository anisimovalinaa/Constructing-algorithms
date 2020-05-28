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
    public partial class AddCustomer : Form
    {
        public AddCustomer(DataGridView table)
        {
            InitializeComponent();
            this.table = table;
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            label6.Font = new Font("Times New Roman", 10, label6.Font.Style);
            label7.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label8.Font = new Font("Times New Roman", 10, label8.Font.Style);
            label9.Font = new Font("Times New Roman", 10, label9.Font.Style);
            add.Font = new Font("Times New Roman", 12, add.Font.Style);
            surname.Font = new Font("Times New Roman", 10, surname.Font.Style);
            name.Font = new Font("Times New Roman", 10, name.Font.Style);
            middle_name.Font = new Font("Times New Roman", 10, middle_name.Font.Style);
            sex.Font = new Font("Times New Roman", 10, sex.Font.Style);
            id_address.Font = new Font("Times New Roman", 10, id_address.Font.Style);
            id_passport.Font = new Font("Times New Roman", 10, id_passport.Font.Style);
            jobPlace.Font = new Font("Times New Roman", 10, jobPlace.Font.Style);
            phoneNumber.Font = new Font("Times New Roman", 10, phoneNumber.Font.Style);
            date.Font = new Font("Times New Roman", 10, date.Font.Style);
        }
        DataGridView table;

        private void add_Click(object sender, EventArgs e)
        {
            if (surname.Text != "" && name.Text != "" && middle_name.Text != "" && sex.Text != "" && date.Text != "" && id_passport.Text != "" && jobPlace.Text == ""
                && id_address.Text == "" && phoneNumber.Text == "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`customers` (`surname` ,`name` ,`middle_name` ,`sex` ,`date` ,`id_passport`,'job_place', 'id_address','phone_number')" +
                "VALUES('" + surname.Text + "', '" + name.Text + "', '" + middle_name.Text + "', '" + sex.Text + "', '" + date.Text +
                "', '" + id_passport.Text + "', '" + jobPlace.Text + "', '" + id_address.Text + "', '" + phoneNumber.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM customers";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                table.Rows.Add();

                while (reader.Read())
                {
                    table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["dateC", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["pasport", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["jobPlace", table.Rows.Count - 1].Value = reader[6].ToString();
                    table["address", table.Rows.Count - 1].Value = reader[7].ToString();
                    table["phoneNumber", table.Rows.Count - 1].Value = reader[8].ToString();
                }

                reader.Close();
                connection.Close();
            }
            else MessageBox.Show("Необходимо заполнить все поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
