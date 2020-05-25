﻿namespace Индивидуальное_задание_2.База_данных
{
    partial class Insurance_Events
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
            this.id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.RichTextBox();
            this.num2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.RichTextBox();
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
            this.id_type,
            this.id_event,
            this.name});
            this.table.Location = new System.Drawing.Point(28, 26);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(440, 350);
            this.table.TabIndex = 0;
            // 
            // id_type
            // 
            this.id_type.HeaderText = "ID типа страхования";
            this.id_type.Name = "id_type";
            this.id_type.ReadOnly = true;
            this.id_type.Width = 75;
            // 
            // id_event
            // 
            this.id_event.HeaderText = "ID страхового события";
            this.id_event.Name = "id_event";
            this.id_event.ReadOnly = true;
            this.id_event.Width = 65;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 300;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(550, 102);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить событие";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(713, 163);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(589, 334);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Изменить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изменить запись:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 247);
            this.label2.MaximumSize = new System.Drawing.Size(80, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID страхового события:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поле:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Значение:";
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Items.AddRange(new object[] {
            "ID типа страхования",
            "Наменование"});
            this.box.Location = new System.Drawing.Point(626, 280);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(121, 21);
            this.box.TabIndex = 8;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(626, 307);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(121, 21);
            this.value.TabIndex = 9;
            this.value.Text = "";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(626, 247);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(121, 26);
            this.num2.TabIndex = 10;
            this.num2.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 163);
            this.label5.MaximumSize = new System.Drawing.Size(150, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите ID страхового события:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(607, 163);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 23);
            this.num1.TabIndex = 12;
            this.num1.Text = "";
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(550, 55);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(158, 23);
            this.show.TabIndex = 13;
            this.show.Text = "Показать все записи";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Insurance_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.value);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.table);
            this.Name = "Insurance_Events";
            this.Text = "Insurance_Event";
            this.Load += new System.EventHandler(this.Insurance_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox box;
        private System.Windows.Forms.RichTextBox value;
        private System.Windows.Forms.RichTextBox num2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox num1;
        private System.Windows.Forms.Button show;
    }
}