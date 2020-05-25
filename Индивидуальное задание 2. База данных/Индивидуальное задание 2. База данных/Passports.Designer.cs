namespace Индивидуальное_задание_2.База_данных
{
    partial class Passports
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
            this.add = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.ComboBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.id_passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issued = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_passport,
            this.series,
            this.number,
            this.issued,
            this.birthplace,
            this.code,
            this.date});
            this.table.Location = new System.Drawing.Point(28, 32);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(609, 391);
            this.table.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(693, 85);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(130, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(693, 43);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(130, 23);
            this.show.TabIndex = 2;
            this.show.Text = "Показать все записи";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(844, 122);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ID паспорта:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(793, 122);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(45, 23);
            this.num1.TabIndex = 5;
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "Серия",
            "Номер",
            "Кем выдан",
            "Место рождения",
            "Код подразделения",
            "Дата выдачи"});
            this.box.Location = new System.Drawing.Point(751, 229);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(751, 202);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(121, 20);
            this.num2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Изменить запись:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID паспорта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поле:";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(751, 297);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 11;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Новое значение:";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(752, 258);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(120, 20);
            this.value.TabIndex = 13;
            // 
            // id_passport
            // 
            this.id_passport.HeaderText = "ID паспорта";
            this.id_passport.Name = "id_passport";
            this.id_passport.ReadOnly = true;
            this.id_passport.Width = 60;
            // 
            // series
            // 
            this.series.HeaderText = "Серия";
            this.series.Name = "series";
            this.series.ReadOnly = true;
            this.series.Width = 60;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 60;
            // 
            // issued
            // 
            this.issued.HeaderText = "Кем выдан";
            this.issued.Name = "issued";
            this.issued.ReadOnly = true;
            this.issued.Width = 150;
            // 
            // birthplace
            // 
            this.birthplace.HeaderText = "Место рождения";
            this.birthplace.Name = "birthplace";
            this.birthplace.ReadOnly = true;
            // 
            // code
            // 
            this.code.HeaderText = "Код подразделения";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 95;
            // 
            // date
            // 
            this.date.HeaderText = "Дата выдачи";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 85;
            // 
            // Passports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.show);
            this.Controls.Add(this.add);
            this.Controls.Add(this.table);
            this.Name = "Passports";
            this.Text = "Passports";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}