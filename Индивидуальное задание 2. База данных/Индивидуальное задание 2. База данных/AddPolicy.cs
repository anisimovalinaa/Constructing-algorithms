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
    public partial class AddPolicy : Form
    {
        public AddPolicy(DataGridView table)
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (customer.Text != "" && insEvent.Text != "" && begin.Text != "" && end.Text != "" && agent.Text != "" && 
                amount.Text != "" && payments.Text != "" && status.Text != "" && date.Text != "")
            {
                MySqlConnection connection = Program.Conn();
                connection.Open();

                string comStr =
                "INSERT INTO `insurance company`.`insurance_policy` (`customer` ,`insurance_event` ,`begin`, `end` ,`agent` ,`amount`,'payments','date','status')" +
                "VALUES('" + customer.Text + "', '" + insEvent.Text + "', '" + begin.Text + "', '" + end.Text + "', '" + agent.Text +
                "', '" + amount.Text + "', '" + payments.Text + "', '" + date.Text + "', '" + status.Text + "')";
                MySqlCommand com = new MySqlCommand(comStr, connection);
                com.ExecuteNonQuery();

                connection.Close();                
            }
            else MessageBox.Show("Необходимо заполнить все обязательные поля!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
