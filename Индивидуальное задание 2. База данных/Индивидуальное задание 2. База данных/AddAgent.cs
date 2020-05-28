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
        public AddAgent(DataGridView table, DataGridView table1, DataGridView table2)
        {
            InitializeComponent();
            this.table = table;
            this.table1 = table1;
            this.table2 = table2;
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            label7.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label9.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label10.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label11.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label12.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label13.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label14.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label15.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label16.Font = new Font("Times New Roman", 10, FontStyle.Underline);
            label17.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label18.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label19.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label20.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label21.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label22.Font = new Font("Times New Roman", 10, label7.Font.Style);
            label23.Font = new Font("Times New Roman", 10, FontStyle.Underline);
            add.Font = new Font("Times New Roman", 12, add.Font.Style);
            surname.Font = new Font("Times New Roman", 10, surname.Font.Style);
            name.Font = new Font("Times New Roman", 10, name.Font.Style);
            middle_name.Font = new Font("Times New Roman", 10, middle_name.Font.Style);
            sex.Font = new Font("Times New Roman", 10, sex.Font.Style);
            phone_number.Font = new Font("Times New Roman", 10, phone_number.Font.Style);
            date.Font = new Font("Times New Roman", 10, date.Font.Style);
            country.Font = new Font("Times New Roman", 10, country.Font.Style);
            city.Font = new Font("Times New Roman", 10, city.Font.Style);
            street.Font = new Font("Times New Roman", 10, street.Font.Style);
            number.Font = new Font("Times New Roman", 10, number.Font.Style);
            flat.Font = new Font("Times New Roman", 10, flat.Font.Style);
            postcode.Font = new Font("Times New Roman", 10, postcode.Font.Style);
            issued.Font = new Font("Times New Roman", 10, date.Font.Style);
            place.Font = new Font("Times New Roman", 10, date.Font.Style);
            code.Font = new Font("Times New Roman", 10, date.Font.Style);
            date1.Font = new Font("Times New Roman", 10, date.Font.Style);
            series.Font = new Font("Times New Roman", 10, date.Font.Style);
            number1.Font = new Font("Times New Roman", 10, date.Font.Style);
        }
        DataGridView table, table1, table2;

        private void Cleaning()
        {
            surname.Clear();
            name.Clear();
            middle_name.Clear();
            sex.Clear();
            date.Clear();
            phone_number.Clear();
            series.Clear();
            number.Clear();
            code.Clear();
            date1.Clear();
            place.Clear();
            issued.Clear();
            country.Clear();
            city.Clear();
            street.Clear();
            number1.Clear();
            flat.Clear();
            postcode.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surname.Text != "" && name.Text != "" && middle_name.Text != "" && sex.Text != "" && date.Text != "" && phone_number.Text != ""
                && series.Text != "" && number.Text != "" && issued.Text != "" && place.Text != "" &&
                code.Text != "" && date1.Text != "" && country.Text != "" && city.Text != "" && street.Text != "" && number1.Text != "" && postcode.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr1 =
                "INSERT INTO `insurance company`.`passport` (`series` ,`number` ,`issued` ,`birthplace` ,`code` ,`date`)" +
                "VALUES('" + series.Text + "', '" + number.Text + "', '" + issued.Text + "', '" + place.Text + "', '" + code.Text +
                "', '" + date1.Text + "')";
                MySqlCommand com1 = new MySqlCommand(comStr1, connection);
                com1.ExecuteNonQuery();

                string comStr4 =
                    "INSERT INTO `insurance company`.`address` (`country` ,`city` ,`street`, `number` ,`flat` ,`postcode`)" +
                    "VALUES('" + country.Text + "', '" + city.Text + "', '" + street.Text + "', '" + number1.Text + "', '" + flat.Text +
                    "', '" + postcode.Text + "')";
                MySqlCommand com4 = new MySqlCommand(comStr4, connection);
                com4.ExecuteNonQuery();

                string comStr3 = "SELECT * FROM `passport` WHERE(series = " + series.Text + " AND number =" + number.Text + ")";
                MySqlCommand com3 = new MySqlCommand(comStr3, connection);
                MySqlDataReader reader1 = com3.ExecuteReader();

                table1.Rows.Add();
                while (reader1.Read())
                {
                    table1["id_passport", table1.Rows.Count - 1].Value = reader1[0].ToString();
                    table1["series", table1.Rows.Count - 1].Value = reader1[1].ToString();
                    table1["number1", table1.Rows.Count - 1].Value = reader1[2].ToString();
                    table1["issued", table1.Rows.Count - 1].Value = reader1[3].ToString();
                    table1["birthplace", table1.Rows.Count - 1].Value = reader1[4].ToString();
                    table1["code", table1.Rows.Count - 1].Value = reader1[5].ToString();
                    table1["date1", table1.Rows.Count - 1].Value = reader1[6].ToString();
                }

                string id = table1["id_passport", table1.Rows.Count - 1].Value.ToString();
                reader1.Close();

                string comStr5 = "SELECT * FROM `address` WHERE(country = '" + country.Text + "' AND city = '" + city.Text + "' AND street = '" +
                street.Text + "' AND number = '" + number1.Text + "' AND flat = '" + flat.Text + "')";
                MySqlCommand com5 = new MySqlCommand(comStr5, connection);
                MySqlDataReader reader2 = com5.ExecuteReader();

                table.Rows.Add();
                table2.Rows.Add();

                string id1 = "";
                while (reader2.Read())
                {
                    id1 = reader2[0].ToString();
                    table2["id", table2.Rows.Count - 1].Value = reader2[0].ToString();
                    table2["country", table2.Rows.Count - 1].Value = reader2[1].ToString();
                    table2["city", table2.Rows.Count - 1].Value = reader2[2].ToString();
                    table2["street", table2.Rows.Count - 1].Value = reader2[3].ToString();
                    table2["number2", table2.Rows.Count - 1].Value = reader2[4].ToString();
                    table2["flat", table2.Rows.Count - 1].Value = reader2[5].ToString();
                    table2["postcode", table2.Rows.Count - 1].Value = reader2[6].ToString();
                }
                reader2.Close();

                string comStr =
                "INSERT INTO `insurance company`.`agents` (`surname` ,`name` ,`middle_name`, `sex` ,`date` ,`passport`, `phone_number`, `id_address`)" +
                "VALUES('" + surname.Text + "', '" + name.Text + "', '" + middle_name.Text + "', '" + sex.Text + "', '" + date.Text +
                "', '" + id + "', '" + phone_number.Text + "', '" + id1 + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                string comStr2 = "SELECT * FROM agents";
                MySqlCommand com2 = new MySqlCommand(comStr2, connection);
                MySqlDataReader reader = com2.ExecuteReader();

                while (reader.Read())
                {
                    table["surnameA", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["nameA", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["middle_nameA", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["sexA", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["dateA", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["passportA", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["phone_number", table.Rows.Count - 1].Value = reader[6].ToString();
                    table["id_address", table.Rows.Count - 1].Value = reader[7].ToString();
                }

                reader.Close();
                connection.Close();
                Cleaning();
            }
            else MessageBox.Show("Необходимо заполнить все поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
