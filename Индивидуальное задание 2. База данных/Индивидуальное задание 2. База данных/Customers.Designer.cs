namespace Индивидуальное_задание_2.База_данных
{
    partial class Customers
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
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.ComboBox();
            this.update = new System.Windows.Forms.Button();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.name,
            this.middle_name,
            this.sex,
            this.date,
            this.passport,
            this.jobPlace,
            this.address,
            this.phoneNumber});
            this.table.Location = new System.Drawing.Point(12, 12);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(773, 412);
            this.table.TabIndex = 0;
            // 
            // showClients
            // 
            this.showClients.Location = new System.Drawing.Point(826, 43);
            this.showClients.Name = "showClients";
            this.showClients.Size = new System.Drawing.Size(162, 23);
            this.showClients.TabIndex = 1;
            this.showClients.Text = "Показать всех клиентов";
            this.showClients.UseVisualStyleBackColor = true;
            this.showClients.Click += new System.EventHandler(this.showClients_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(826, 95);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(162, 23);
            this.addClient.TabIndex = 2;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(971, 154);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(807, 151);
            this.label1.MaximumSize = new System.Drawing.Size(80, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID паспорта клиента:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(893, 157);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(72, 20);
            this.num1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Изменить запись:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID паспорта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поле:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Новое значение:";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(893, 259);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 10;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(893, 329);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 20);
            this.value.TabIndex = 11;
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Пол",
            "Дата рождения",
            "ID паспорта",
            "Место работы",
            "ID адреса",
            "Номер телефона"});
            this.box.Location = new System.Drawing.Point(893, 293);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 12;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(880, 372);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // middle_name
            // 
            this.middle_name.HeaderText = "Отчество";
            this.middle_name.Name = "middle_name";
            this.middle_name.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Пол";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 60;
            // 
            // date
            // 
            this.date.HeaderText = "Дата рождения";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 90;
            // 
            // passport
            // 
            this.passport.HeaderText = "ID паспорта";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            this.passport.Width = 60;
            // 
            // jobPlace
            // 
            this.jobPlace.HeaderText = "Место работы";
            this.jobPlace.Name = "jobPlace";
            this.jobPlace.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "ID адреса";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 60;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.update);
            this.Controls.Add(this.box);
            this.Controls.Add(this.value);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.showClients);
            this.Controls.Add(this.table);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button showClients;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
    }
}