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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializePolicy();
            InitializeCustomer();
            InitializeAgents();

            ShowPolicy();
            ShowAgents();
            ShowCustomers();
        }

        private void InitializePolicy()
        {
            tabControl1.Font = new Font("Times New Roman", 10, tabControl1.Font.Style);
            table_policy.Font = new Font("Times New Roman", 10, table_policy.Font.Style);
            table_policy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            show.Font = new Font("Times New Roman", 10, show.Font.Style);
            addPolicy.Font = new Font("Times New Roman", 10, addPolicy.Font.Style);
            deletePolicy.Font = new Font("Times New Roman", 10, deletePolicy.Font.Style);
            updatePolicy.Font = new Font("Times New Roman", 10, updatePolicy.Font.Style);
            label1.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label2.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label3.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label4.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label5.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numPolicy1.Font = new Font("Times New Roman", 10, numPolicy1.Font.Style);
            numPolicy2.Font = new Font("Times New Roman", 10, numPolicy2.Font.Style);
            valuePolicy.Font = new Font("Times New Roman", 10, valuePolicy.Font.Style);
            boxPolicy.Font = new Font("Times New Roman", 10, boxPolicy.Font.Style);
        }

        private void InitializeCustomer()
        {
            table_customer.Font = new Font("Times New Roman", 10, table_customer.Font.Style);
            table_customer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            showClients.Font = new Font("Times New Roman", 10, showClients.Font.Style);
            addClient.Font = new Font("Times New Roman", 10, addClient.Font.Style);
            deleteClient.Font = new Font("Times New Roman", 10, deleteClient.Font.Style);
            updateClient.Font = new Font("Times New Roman", 10, updateClient.Font.Style);
            label6.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label7.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label8.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label9.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label10.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numClient1.Font = new Font("Times New Roman", 10, numClient1.Font.Style);
            numClient2.Font = new Font("Times New Roman", 10, numClient2.Font.Style);
            valueClient.Font = new Font("Times New Roman", 10, valueClient.Font.Style);
            boxClient.Font = new Font("Times New Roman", 10, boxClient.Font.Style);
        }

        private void InitializeAgents()
        {
            table.Font = new Font("Times New Roman", 10, table.Font.Style);
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            show.Font = new Font("Times New Roman", 10, show.Font.Style);
            addAgent.Font = new Font("Times New Roman", 10, addAgent.Font.Style);
            deleteAgent.Font = new Font("Times New Roman", 10, deleteAgent.Font.Style);
            updateAgent.Font = new Font("Times New Roman", 10, updateAgent.Font.Style);
            label11.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label12.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label13.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label14.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label15.Font = new Font("Times New Roman", 10, label5.Font.Style);
            num1.Font = new Font("Times New Roman", 10, num1.Font.Style);
            num2.Font = new Font("Times New Roman", 10, num2.Font.Style);
            value.Font = new Font("Times New Roman", 10, value.Font.Style);
            box.Font = new Font("Times New Roman", 10, box.Font.Style);
        }

        private void ShowPolicy()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM agents";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table_policy.Rows.Add();
                table_policy["number", table_policy.Rows.Count - 1].Value = reader[0].ToString();
                table_policy["customer", table_policy.Rows.Count - 1].Value = reader[1].ToString();
                table_policy["insEvent", table_policy.Rows.Count - 1].Value = reader[2].ToString();
                table_policy["begin", table_policy.Rows.Count - 1].Value = reader[3].ToString();
                table_policy["end", table_policy.Rows.Count - 1].Value = reader[4].ToString();
                table_policy["agent", table_policy.Rows.Count - 1].Value = reader[5].ToString();
                table_policy["amount", table_policy.Rows.Count - 1].Value = reader[6].ToString();
                table_policy["payments", table_policy.Rows.Count - 1].Value = reader[7].ToString();
                table_policy["date", table_policy.Rows.Count - 1].Value = reader[8].ToString();
                table_policy["status", table_policy.Rows.Count - 1].Value = reader[9].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void ShowCustomers()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM customers";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table_customer.Rows.Add();
                table_customer["surname", table_customer.Rows.Count - 1].Value = reader[0].ToString();
                table_customer["name", table_customer.Rows.Count - 1].Value = reader[1].ToString();
                table_customer["middle_name", table_customer.Rows.Count - 1].Value = reader[2].ToString();
                table_customer["sex", table_customer.Rows.Count - 1].Value = reader[3].ToString();
                table_customer["dateOfBirth", table_customer.Rows.Count - 1].Value = reader[4].ToString();
                table_customer["pasport", table_customer.Rows.Count - 1].Value = reader[5].ToString();
                table_customer["jobPlace", table_customer.Rows.Count - 1].Value = reader[6].ToString();
                table_customer["address", table_customer.Rows.Count - 1].Value = reader[7].ToString();
                table_customer["phoneNumber", table_customer.Rows.Count - 1].Value = reader[8].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void ShowAgents()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM agents";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["surname", table.Rows.Count - 1].Value = reader[0].ToString();
                table["name", table.Rows.Count - 1].Value = reader[1].ToString();
                table["middle_name", table.Rows.Count - 1].Value = reader[2].ToString();
                table["sex", table.Rows.Count - 1].Value = reader[3].ToString();
                table["date", table.Rows.Count - 1].Value = reader[4].ToString();
                table["passport", table.Rows.Count - 1].Value = reader[5].ToString();
                table["phone_number", table.Rows.Count - 1].Value = reader[6].ToString();
                table["id_address", table.Rows.Count - 1].Value = reader[7].ToString();
            }
            reader.Close();
            connection.Close();
        }
        //******************Страховой полис********************
        private void deletePolicy_Click(object sender, EventArgs e)
        {
            if (numPolicy1.Text == "") MessageBox.Show("Введите номер полиса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table_policy.Rows.Count; i++)
                {
                    if ((table_policy["number", i].Value.ToString() == numPolicy1.Text) && !check)
                    {
                        table_policy.Rows.RemoveAt(i);
                        string com = "DELETE FROM insurance_policy WHERE number = '" + numPolicy1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numPolicy1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого номера нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numPolicy1.Clear();
            }
        }

        private void updatePolicy_Click(object sender, EventArgs e)
        {
            if (numPolicy2.Text == "") MessageBox.Show("Введите номер полиса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valuePolicy.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxPolicy.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table_policy.Rows.Count; i++)
                    if ((table_policy["number", i].Value.ToString() == numPolicy2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxPolicy.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE insurance_policy SET surname = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["customer", i].Value = valuePolicy.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE insurance_policy SET name = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["insEvent", i].Value = valuePolicy.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE insurance_policy SET middle_name = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["begin", i].Value = valuePolicy.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE insurance_policy SET sex = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["end", i].Value = valuePolicy.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE insurance_policy SET date = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["agent", i].Value = valuePolicy.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE insurance_policy SET passport = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["amount", i].Value = valuePolicy.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE insurance_policy SET phone_number = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["payments", i].Value = valuePolicy.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE insurance_policy SET id_address = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["status", i].Value = valuePolicy.Text; break;
                                }
                            case 8:
                                {
                                    com = "UPDATE insurance_policy SET id_address = '" + valuePolicy.Text + "' WHERE number = '" + numPolicy2.Text + "'";
                                    table_policy["data", i].Value = valuePolicy.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numPolicy2.Clear();
                valuePolicy.Clear();
            }
        }

        private void addPolicy_Click(object sender, EventArgs e)
        {
            AddPolicy form = new AddPolicy(table_policy);
            form.Show();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }

        //**********************Клиенты********************************
        private void deleteClient_Click(object sender, EventArgs e)
        {
            if (numClient1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table_customer.Rows.Count; i++)
                {
                    if ((table_customer["passport", i].Value.ToString() == numClient1.Text) && !check)
                    {
                        table_customer.Rows.RemoveAt(i);
                        string com = "DELETE FROM customers WHERE id_passport = '" + numClient1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numClient1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numClient1.Clear();
            }
        }

        private void updateClient_Click(object sender, EventArgs e)
        {
            if (numClient2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valueClient.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxClient.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table_customer.Rows.Count; i++)
                    if ((table_customer["id_passport", i].Value.ToString() == numClient2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxClient.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE customers SET surname = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["surname", i].Value = valueClient.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE customers SET name = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["name", i].Value = valueClient.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE customers SET middle_name = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["middle_name", i].Value = valueClient.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE customers SET sex = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["sex", i].Value = valueClient.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE customers SET date = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["date", i].Value = valueClient.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE customers SET id_passport = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["passport", i].Value = valueClient.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE customers SET job_place = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["jobPlace", i].Value = valueClient.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE customers SET id_address = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["address", i].Value = valueClient.Text; break;
                                }
                            case 8:
                                {
                                    com = "UPDATE customers SET phone_number = '" + valueClient.Text + "' WHERE id_passport = '" + numClient2.Text + "'";
                                    table_customer["phoneNumber", i].Value = valueClient.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numClient2.Clear();
                valueClient.Clear();
            }
        }


        //***************************Агенты********************************
        private void addAgent_Click(object sender, EventArgs e)
        {
            AddAgent form = new AddAgent();
            form.Show();
        }

        private void deleteAgent_Click(object sender, EventArgs e)
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
                        string com = "DELETE FROM agents WHERE passport = '" + num1.Text + "'";

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

        private void updateAgent_Click(object sender, EventArgs e)
        {
            if (num2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (value.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (box.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table.Rows.Count; i++)
                    if ((table["id_address", i].Value.ToString() == num2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (box.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE address SET surname = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["surname", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE address SET name = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["name", i].Value = value.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE address SET middle_name = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["middle_name", i].Value = value.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE address SET sex = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["sex", i].Value = value.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE address SET date = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["date", i].Value = value.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE address SET passport = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["passport", i].Value = value.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE address SET phone_number = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["phone_number", i].Value = value.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE address SET id_address = '" + value.Text + "' WHERE passport = '" + num2.Text + "'";
                                    table["id_address", i].Value = value.Text; break;
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
