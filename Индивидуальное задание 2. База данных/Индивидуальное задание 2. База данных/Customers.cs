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
            table.Font = new Font("Times New Roman", 10, table.Font.Style);
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            showClients.Font = new Font("Times New Roman", 10, showClients.Font.Style);
            addClient.Font = new Font("Times New Roman", 10, addClient.Font.Style);
            delete.Font = new Font("Times New Roman", 10, delete.Font.Style);
            update.Font = new Font("Times New Roman", 10, update.Font.Style);
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            num1.Font = new Font("Times New Roman", 10, num1.Font.Style);
            num2.Font = new Font("Times New Roman", 10, num2.Font.Style);
            value.Font = new Font("Times New Roman", 10, value.Font.Style);
            box.Font = new Font("Times New Roman", 10, box.Font.Style);

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM customers";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                table["dateOfBirth", table.Rows.Count - 1].Value = reader[4].ToString();
                table["pasport", table.Rows.Count - 1].Value = reader[5].ToString();
                table["jobPlace", table.Rows.Count - 1].Value = reader[6].ToString();
                table["address", table.Rows.Count - 1].Value = reader[7].ToString();
                table["phoneNumber", table.Rows.Count - 1].Value = reader[8].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }

        private void showClients_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM customers";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                    if (table["customers", i].Value.ToString() == reader[5].ToString()) check = true;
                if (!check)
                {
                    table.Rows.Add();
                    table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                    table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                    table["dateOfBirth", table.Rows.Count - 1].Value = reader[4].ToString();
                    table["pasport", table.Rows.Count - 1].Value = reader[5].ToString();
                    table["jobPlace", table.Rows.Count - 1].Value = reader[6].ToString();
                    table["address", table.Rows.Count - 1].Value = reader[7].ToString();
                    table["phoneNumber", table.Rows.Count - 1].Value = reader[8].ToString();
                }
            }
            reader.Close();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (num1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((table["passport", i].Value.ToString() == num1.Text) && !check)
                    {
                        table.Rows.RemoveAt(i);
                        string com = "DELETE FROM customers WHERE id_passport = '" + num1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        num1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                num1.Clear();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (num2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (value.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (box.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table.Rows.Count; i++)
                    if ((table["id_passport", i].Value.ToString() == num2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (box.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE customers SET surname = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["surname", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE customers SET name = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["name", i].Value = value.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE customers SET middle_name = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["middle_name", i].Value = value.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE customers SET sex = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["sex", i].Value = value.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE customers SET date = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["date", i].Value = value.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE customers SET id_passport = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["passport", i].Value = value.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE customers SET job_place = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["jobPlace", i].Value = value.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE customers SET id_address = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["address", i].Value = value.Text; break;
                                }
                            case 8:
                                {
                                    com = "UPDATE customers SET phone_number = '" + value.Text + "' WHERE id_passport = '" + num2.Text + "'";
                                    table["phoneNumber", i].Value = value.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                num2.Clear();
                value.Clear();
            }
        }
    }
}