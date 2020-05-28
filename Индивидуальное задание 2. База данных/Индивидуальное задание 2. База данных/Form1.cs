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
            tabControl1.Font = new Font("Times New Roman", 12, tabControl1.Font.Style);

            InitializeTypes();
            InitializePolicy();
            InitializeCustomer();
            InitializeAgents();
            InitializePassport();
            InitializeAddress();
            InitializeEvents();

            ShowTypes();
            ShowPolicy();
            ShowAgents();
            ShowCustomers();
            ShowPassport();
            ShowAddress();
            ShowEvents();
        }

        private void InitializeTypes()
        {
            table.Font = new Font("Times New Roman", 10, table.Font.Style);
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void InitializePolicy()
        {
            table_policy.Font = new Font("Times New Roman", 10, table_policy.Font.Style);
            table_policy.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            table_agents.Font = new Font("Times New Roman", 10, table_agents.Font.Style);
            table_agents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addAgent.Font = new Font("Times New Roman", 10, addAgent.Font.Style);
            deleteAgent.Font = new Font("Times New Roman", 10, deleteAgent.Font.Style);
            updateAgent.Font = new Font("Times New Roman", 10, updateAgent.Font.Style);
            label11.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label12.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label13.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label14.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label15.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numAgent1.Font = new Font("Times New Roman", 10, numAgent1.Font.Style);
            numAgent2.Font = new Font("Times New Roman", 10, numAgent2.Font.Style);
            valueAgent.Font = new Font("Times New Roman", 10, valueAgent.Font.Style);
            boxAgent.Font = new Font("Times New Roman", 10, boxAgent.Font.Style);
        }

        private void InitializePassport()
        {
            table_passport.Font = new Font("Times New Roman", 10, table_passport.Font.Style);
            table_passport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addPassport.Font = new Font("Times New Roman", 10, addPassport.Font.Style);
            deletePassport.Font = new Font("Times New Roman", 10, deletePassport.Font.Style);
            updatePassport.Font = new Font("Times New Roman", 10, updatePassport.Font.Style);
            label16.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label17.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label18.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label19.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label20.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numPassport1.Font = new Font("Times New Roman", 10, numAgent1.Font.Style);
            numPassport2.Font = new Font("Times New Roman", 10, numAgent2.Font.Style);
            valuePassport.Font = new Font("Times New Roman", 10, valueAgent.Font.Style);
            boxPassport.Font = new Font("Times New Roman", 10, boxAgent.Font.Style);
        }

        private void InitializeAddress()
        {
            tableAddress.Font = new Font("Times New Roman", 10, tableAddress.Font.Style);
            tableAddress.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addAddress.Font = new Font("Times New Roman", 10, addAddress.Font.Style);
            deleteAddress.Font = new Font("Times New Roman", 10, deleteAddress.Font.Style);
            updateAddress.Font = new Font("Times New Roman", 10, updateAddress.Font.Style);
            label21.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label22.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label23.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label24.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label25.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numAddress1.Font = new Font("Times New Roman", 10, numAddress1.Font.Style);
            numAddress2.Font = new Font("Times New Roman", 10, numAddress2.Font.Style);
            valueAddress.Font = new Font("Times New Roman", 10, valueAddress.Font.Style);
            boxAddress.Font = new Font("Times New Roman", 10, boxAddress.Font.Style);
        }

        private void InitializeEvents()
        {
            table_event.Font = new Font("Times New Roman", 10, table_event.Font.Style);
            table_event.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEvent.Font = new Font("Times New Roman", 10, addEvent.Font.Style);
            deleteEvent.Font = new Font("Times New Roman", 10, deleteEvent.Font.Style);
            updateEvent.Font = new Font("Times New Roman", 10, updateEvent.Font.Style);
            label26.Font = new Font("Times New Roman", 10, label1.Font.Style);
            label27.Font = new Font("Times New Roman", 10, label2.Font.Style);
            label28.Font = new Font("Times New Roman", 10, label3.Font.Style);
            label29.Font = new Font("Times New Roman", 10, label4.Font.Style);
            label30.Font = new Font("Times New Roman", 10, label5.Font.Style);
            numEvent1.Font = new Font("Times New Roman", 10, numEvent1.Font.Style);
            numEvent2.Font = new Font("Times New Roman", 10, numEvent2.Font.Style);
            valueEvent.Font = new Font("Times New Roman", 10, valueEvent.Font.Style);
            boxEvent.Font = new Font("Times New Roman", 10, boxEvent.Font.Style);
        }

        private void ShowTypes()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM type_of_insurance";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id1", table.Rows.Count - 1].Value = reader[0].ToString();
                table["name2", table.Rows.Count - 1].Value = reader[1].ToString();
            }
            reader.Close();
            connection.Close();
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
                table_customer["dateC", table_customer.Rows.Count - 1].Value = reader[4].ToString();
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
                table_agents.Rows.Add();
                table_agents["surname", table_agents.Rows.Count - 1].Value = reader[0].ToString();
                table_agents["name", table_agents.Rows.Count - 1].Value = reader[1].ToString();
                table_agents["middle_name", table_agents.Rows.Count - 1].Value = reader[2].ToString();
                table_agents["sex", table_agents.Rows.Count - 1].Value = reader[3].ToString();
                table_agents["date", table_agents.Rows.Count - 1].Value = reader[4].ToString();
                table_agents["passport", table_agents.Rows.Count - 1].Value = reader[5].ToString();
                table_agents["phone_number", table_agents.Rows.Count - 1].Value = reader[6].ToString();
                table_agents["id_address", table_agents.Rows.Count - 1].Value = reader[7].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void ShowPassport()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM passport";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table_passport.Rows.Add();
                table_passport["id_passport", table_passport.Rows.Count - 1].Value = reader[0].ToString();
                table_passport["series", table_passport.Rows.Count - 1].Value = reader[1].ToString();
                table_passport["number1", table_passport.Rows.Count - 1].Value = reader[2].ToString();
                table_passport["issued", table_passport.Rows.Count - 1].Value = reader[3].ToString();
                table_passport["birthplace", table_passport.Rows.Count - 1].Value = reader[4].ToString();
                table_passport["code", table_passport.Rows.Count - 1].Value = reader[5].ToString();
                table_passport["date1", table_passport.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void ShowAddress()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM address";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                tableAddress.Rows.Add();
                tableAddress["id", tableAddress.Rows.Count - 1].Value = reader[0].ToString();
                tableAddress["country", tableAddress.Rows.Count - 1].Value = reader[1].ToString();
                tableAddress["city", tableAddress.Rows.Count - 1].Value = reader[2].ToString();
                tableAddress["street", tableAddress.Rows.Count - 1].Value = reader[3].ToString();
                tableAddress["number2", tableAddress.Rows.Count - 1].Value = reader[4].ToString();
                tableAddress["flat", tableAddress.Rows.Count - 1].Value = reader[5].ToString();
                tableAddress["postcode", tableAddress.Rows.Count - 1].Value = reader[6].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void ShowEvents()
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM insurance_event";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table_event.Rows.Add();
                table_event["id_type", table_event.Rows.Count - 1].Value = reader[0].ToString();
                table_event["id_event", table_event.Rows.Count - 1].Value = reader[1].ToString();
                table_event["name1", table_event.Rows.Count - 1].Value = reader[2].ToString();
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

        //**********************Клиенты********************************
        private void addClient_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer(table_customer);
            form.Show();
        }

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
                    if ((table_customer["passport", i].Value.ToString() == numClient2.Text) && !check)
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
                                    table_customer["dateC", i].Value = valueClient.Text; break;
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
            AddAgent form = new AddAgent(table_agents);
            form.Show();
        }

        private void deleteAgent_Click(object sender, EventArgs e)
        {
            if (numAgent1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table_agents.Rows.Count; i++)
                {
                    if ((table_agents["passportA", i].Value.ToString() == numAgent1.Text) && !check)
                    {
                        table_agents.Rows.RemoveAt(i);
                        string com = "DELETE FROM agents WHERE passport = '" + numAgent1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numAgent1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numAgent1.Clear();
            }
        }

        private void updateAgent_Click(object sender, EventArgs e)
        {
            if (numAgent2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valueAgent.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxAgent.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table_agents.Rows.Count; i++)
                    if ((table_agents["passportA", i].Value.ToString() == numAgent2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxAgent.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE address SET surname = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["surnameA", i].Value = valueAgent.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE address SET name = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["nameA", i].Value = valueAgent.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE address SET middle_name = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["middle_nameA", i].Value = valueAgent.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE address SET sex = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["sexA", i].Value = valueAgent.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE address SET date = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["dateA", i].Value = valueAgent.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE address SET passport = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["passportA", i].Value = valueAgent.Text; break;
                                }
                            case 6:
                                {
                                    com = "UPDATE address SET phone_number = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["phone_number", i].Value = valueAgent.Text; break;
                                }
                            case 7:
                                {
                                    com = "UPDATE address SET id_address = '" + valueAgent.Text + "' WHERE passport = '" + numAgent2.Text + "'";
                                    table_agents["id_address", i].Value = valueAgent.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numAgent2.Clear();
                valueAgent.Clear();
            }
        }

        //********************Паспорта****************************
        private void addPassport_Click(object sender, EventArgs e)
        {
            AddPassport form = new AddPassport(table_passport);
            form.Show();
        }

        private void deletePassport_Click(object sender, EventArgs e)
        {
            if (numPassport1.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table_passport.Rows.Count; i++)
                {
                    if ((table_passport["id_passport", i].Value.ToString() == numPassport1.Text) && !check)
                    {
                        table_passport.Rows.RemoveAt(i);
                        string com = "DELETE FROM passport WHERE id_passport = '" + numPassport1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numAgent1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numPassport1.Clear();
            }
        }

        private void updatePassport_Click(object sender, EventArgs e)
        {
            if (numPassport2.Text == "") MessageBox.Show("Введите ID паспорта!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valuePassport.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxPassport.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table_passport.Rows.Count; i++)
                    if ((table_passport["id_passport", i].Value.ToString() == numPassport2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxPassport.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE passport SET series = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["series", i].Value = valuePassport.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE passport SET number = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["number1", i].Value = valuePassport.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE passport SET issued = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["issued", i].Value = valuePassport.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE passport SET birthplace = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["birthplace", i].Value = valuePassport.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE passport SET code = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["code", i].Value = valuePassport.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE passport SET date = '" + valuePassport.Text + "' WHERE id_passport = '" + numPassport2.Text + "'";
                                    table_passport["date", i].Value = valuePassport.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numPassport2.Clear();
                valuePassport.Clear();
            }
        }

        //****************************Адреса*****************
        private void addAddress_Click(object sender, EventArgs e)
        {
            AddAddress form = new AddAddress(tableAddress);
            form.Show();
        }

        private void deleteAddress_Click(object sender, EventArgs e)
        {
            if (numAddress1.Text == "") MessageBox.Show("Введите ID адреса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < tableAddress.Rows.Count; i++)
                {
                    if ((tableAddress["id", i].Value.ToString() == numAddress1.Text) && !check)
                    {
                        tableAddress.Rows.RemoveAt(i);
                        string com = "DELETE FROM address WHERE id_address = '" + numAddress1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numAddress1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numAddress1.Clear();
            }
        }

        private void updateAddress_Click(object sender, EventArgs e)
        {
            if (numAddress2.Text == "") MessageBox.Show("Введите ID адреса!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valueAddress.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxAddress.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < tableAddress.Rows.Count; i++)
                    if ((tableAddress["id", i].Value.ToString() == numAddress2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxAddress.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE address SET country = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["country", i].Value = valueAddress.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE address SET city = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["city", i].Value = valueAddress.Text; break;
                                }
                            case 2:
                                {
                                    com = "UPDATE address SET street = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["street", i].Value = valueAddress.Text; break;
                                }
                            case 3:
                                {
                                    com = "UPDATE address SET number = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["number", i].Value = valueAddress.Text; break;
                                }
                            case 4:
                                {
                                    com = "UPDATE address SET flat = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["flat", i].Value = valueAddress.Text; break;
                                }
                            case 5:
                                {
                                    com = "UPDATE address SET postcode = '" + valueAddress.Text + "' WHERE id_address = '" + numAddress2.Text + "'";
                                    tableAddress["postcode", i].Value = valueAddress.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numAddress2.Clear();
                valueAddress.Clear();
            }
        }

        //********************События**************************************
        private void addEvent_Click(object sender, EventArgs e)
        {
            AddEvent form = new AddEvent(table_event);
            form.Show();
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            if (numEvent1.Text == "") MessageBox.Show("Введите ID!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table_event.Rows.Count; i++)
                {
                    if ((table_event["id_event", i].Value.ToString() == numEvent1.Text) && !check)
                    {
                        table_event.Rows.RemoveAt(i);
                        string com = "DELETE FROM insurance_event WHERE id_event = '" + numEvent1.Text + "'";

                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();

                        numEvent1.Clear();
                    }
                }
                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numEvent1.Clear();
            }
        }

        private void updateEvent_Click(object sender, EventArgs e)
        {
            if (numEvent2.Text == "") MessageBox.Show("Введите ID страхового события!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (valueEvent.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (boxEvent.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table_event.Rows.Count; i++)
                    if ((table_event["id_event", i].Value.ToString() == numEvent2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (boxEvent.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE insurance_event SET id_type = '" + valueEvent.Text + "' WHERE id_event = '" + numEvent2.Text + "'";
                                    table_event["id_type", i].Value = valueEvent.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE insurance_event SET number = '" + valueEvent.Text + "' name = '" + numEvent2.Text + "'";
                                    table_event["name", i].Value = valueEvent.Text; break;
                                }
                        }

                        MySqlCommand command = new MySqlCommand(com, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        check = true;
                    }

                if (!check) MessageBox.Show("Такого ID нет!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);

                numEvent2.Clear();
                valueEvent.Clear();
            }
        }
    }
}
