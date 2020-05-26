namespace Индивидуальное_задание_2.База_данных
{
    partial class Agents
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
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middle_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
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
            this.phone_number,
            this.id_address});
            this.table.Location = new System.Drawing.Point(12, 28);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(680, 410);
            this.table.TabIndex = 0;
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
            // 
            // passport
            // 
            this.passport.HeaderText = "ID паспорта";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            this.passport.Width = 60;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            // 
            // id_address
            // 
            this.id_address.HeaderText = "ID адреса";
            this.id_address.Name = "id_address";
            this.id_address.ReadOnly = true;
            this.id_address.Width = 60;
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
            "Номер телефона",
            "ID адреса"});
            this.box.Location = new System.Drawing.Point(823, 300);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 26;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(823, 337);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 20);
            this.value.TabIndex = 25;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(823, 264);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(121, 20);
            this.num2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(774, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Изменить запись:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Новое значение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Поле:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID паспорта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 164);
            this.label1.MaximumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите номер ID паспорта:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(794, 170);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(73, 20);
            this.num1.TabIndex = 18;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(792, 373);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 17;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(746, 95);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 23);
            this.add.TabIndex = 16;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(882, 168);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 15;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(746, 48);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(150, 23);
            this.show.TabIndex = 14;
            this.show.Text = "Показать все записи";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.box);
            this.Controls.Add(this.value);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.show);
            this.Controls.Add(this.table);
            this.Name = "Agents";
            this.Text = "Agentes";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn middle_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_address;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button show;
    }
}