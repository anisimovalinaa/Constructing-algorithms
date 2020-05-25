namespace Индивидуальное_задание_2.База_данных
{
    partial class Addresses
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.country,
            this.city,
            this.street,
            this.number,
            this.flat,
            this.postcode});
            this.table.Location = new System.Drawing.Point(12, 33);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(581, 390);
            this.table.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID адреса";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // country
            // 
            this.country.HeaderText = "Страна";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // city
            // 
            this.city.HeaderText = "Город";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // street
            // 
            this.street.HeaderText = "Улица";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Номер дома";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 60;
            // 
            // flat
            // 
            this.flat.HeaderText = "Номер квартиры";
            this.flat.Name = "flat";
            this.flat.ReadOnly = true;
            this.flat.Width = 60;
            // 
            // postcode
            // 
            this.postcode.HeaderText = "Почтовый индекс";
            this.postcode.Name = "postcode";
            this.postcode.ReadOnly = true;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(635, 58);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(150, 23);
            this.show.TabIndex = 1;
            this.show.Text = "Показать все записи";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(767, 182);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(635, 113);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(688, 387);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 4;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(688, 185);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(73, 20);
            this.num1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 179);
            this.label1.MaximumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите номер ID адреса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID адреса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поле:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Новое значение:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Изменить запись:";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(709, 275);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(121, 20);
            this.num2.TabIndex = 11;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(709, 348);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 20);
            this.value.TabIndex = 12;
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "Страна",
            "Город",
            "Улица",
            "Номер дома",
            "Номер квартиры",
            "Почтовый индекс"});
            this.box.Location = new System.Drawing.Point(709, 311);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 13;
            // 
            // Addresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
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
            this.Name = "Addresses";
            this.Text = "Addresses";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn flat;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcode;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.ComboBox box;
    }
}