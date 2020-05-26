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
            customers.Font = new Font("Times New Roman", 12, customers.Font.Style);
            addresses.Font = new Font("Times New Roman", 12, addresses.Font.Style);
            types.Font = new Font("Times New Roman", 12, types.Font.Style);
            events.Font = new Font("Times New Roman", 12, events.Font.Style);
            passports.Font = new Font("Times New Roman", 12, passports.Font.Style);
            agentes.Font = new Font("Times New Roman", 12, passports.Font.Style);
        }

        private void passports_Click(object sender, EventArgs e)
        {
            Passports tab = new Passports();
            tab.Show();
        }

        private void types_Click(object sender, EventArgs e)
        {
            Types_Of_Insurance form = new Types_Of_Insurance();
            form.Show();
        }

        private void events_Click(object sender, EventArgs e)
        {
            Insurance_Events form = new Insurance_Events();
            form.Show();
        }

        private void addresses_Click(object sender, EventArgs e)
        {
            Addresses form = new Addresses();
            form.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            Customers form = new Customers();
            form.Show();
        }

        private void agentes_Click(object sender, EventArgs e)
        {
            Agents form = new Agents();
            form.Show();
        }
    }
}
