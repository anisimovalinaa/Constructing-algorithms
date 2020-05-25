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
    public partial class Insurance_Events : Form
    {
        public Insurance_Events()
        {
            InitializeComponent();
            table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM insurance_event";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                table.Rows.Add();
                table["id_type", table.Rows.Count - 1].Value = reader[0].ToString();
                table["id_event", table.Rows.Count - 1].Value = reader[1].ToString();
                table["name", table.Rows.Count - 1].Value = reader[2].ToString();
            }
            reader.Close();
            connection.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (num2.Text == "") MessageBox.Show("Введите ID страхового события!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (value.Text == "") MessageBox.Show("Введите значение!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (box.Text == "") MessageBox.Show("Поле не выбрано!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();

                for (int i = 0; i < table.Rows.Count; i++)
                    if ((table["id_event", i].Value.ToString() == num2.Text) && !check)
                    {
                        MySqlConnection connection = Program.Conn();
                        connection.Open();

                        string com = "";

                        switch (box.SelectedIndex)
                        {
                            case 0:
                                {
                                    com = "UPDATE insurance_event SET id_type = '" + value.Text + "' WHERE id_event = '" + num2.Text + "'";
                                    table["id_type", i].Value = value.Text; break;
                                }
                            case 1:
                                {
                                    com = "UPDATE insurance_event SET number = '" + value.Text + "' name = '" + num2.Text + "'";
                                    table["name", i].Value = value.Text; break;
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (num1.Text == "") MessageBox.Show("Введите ID!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if ((table["id_event", i].Value.ToString() == num1.Text) && !check)
                    {
                        table.Rows.RemoveAt(i);
                        string com = "DELETE FROM insurance_event WHERE id_event = '" + num1.Text + "'";

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

        private void add_Click(object sender, EventArgs e)
        {
            AddEvent form = new AddEvent();
            form.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = Program.Conn();
            connection.Open();

            string comStr = "SELECT * FROM insurance_event";
            MySqlCommand com = new MySqlCommand(comStr, connection);
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                bool check = new bool();
                for (int i = 0; i < table.Rows.Count; i++)
                    if (table["id_event", i].Value.ToString() == reader[0].ToString()) check = true;
                if (!check)
                {
                    table.Rows.Add();
                    table["id_types", table.Rows.Count - 1].Value = reader[0].ToString();
                    table["id_event", table.Rows.Count - 1].Value = reader[1].ToString();
                    table["name", table.Rows.Count - 1].Value = reader[2].ToString();
                }
            }
            reader.Close();
            connection.Close();
        }

        private void Insurance_Events_Load(object sender, EventArgs e)
        {

        }
    }
}