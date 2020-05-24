namespace Индивидуальное_задание_2.База_данных
{
    partial class Tab1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table = new System.Windows.Forms.DataGridView();
            this.showClients = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.sex,
            this.dateOfBirth,
            this.pasport,
            this.jobPlace,
            this.address,
            this.phoneNumber});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(793, 283);
            this.table.TabIndex = 0;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showClients
            // 
            this.showClients.Location = new System.Drawing.Point(724, 55);
            this.showClients.Name = "showClients";
            this.showClients.Size = new System.Drawing.Size(162, 23);
            this.showClients.TabIndex = 1;
            this.showClients.Text = "Показать всех клиентов";
            this.showClients.UseVisualStyleBackColor = true;
            this.showClients.Click += new System.EventHandler(this.Out_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(724, 84);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(162, 23);
            this.addClient.TabIndex = 2;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // name
            // 
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // sex
            // 
            this.sex.HeaderText = "Пол";
            this.sex.Name = "sex";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.HeaderText = "Дата рождения";
            this.dateOfBirth.Name = "dateOfBirth";
            // 
            // pasport
            // 
            this.pasport.HeaderText = "Паспорт";
            this.pasport.Name = "pasport";
            // 
            // jobPlace
            // 
            this.jobPlace.HeaderText = "Место работы";
            this.jobPlace.Name = "jobPlace";
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // Tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.showClients);
            this.Controls.Add(this.table);
            this.Name = "Tab1";
            this.Text = "Tab1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button showClients;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasport;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
    }
}