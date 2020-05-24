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
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_passport,
            this.series,
            this.number,
            this.issued,
            this.birthplace,
            this.code,
            this.date});
            this.table.Location = new System.Drawing.Point(12, 32);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(631, 150);
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
            // id_passport
            // 
            this.id_passport.HeaderText = "Код паспорта";
            this.id_passport.Name = "id_passport";
            this.id_passport.Width = 60;
            // 
            // series
            // 
            this.series.HeaderText = "Серия";
            this.series.Name = "series";
            this.series.Width = 60;
            // 
            // number
            // 
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.Width = 60;
            // 
            // issued
            // 
            this.issued.HeaderText = "Кем выдан";
            this.issued.Name = "issued";
            this.issued.Width = 150;
            // 
            // birthplace
            // 
            this.birthplace.HeaderText = "Место рождения";
            this.birthplace.Name = "birthplace";
            // 
            // code
            // 
            this.code.HeaderText = "Код подразделения";
            this.code.Name = "code";
            this.code.Width = 90;
            // 
            // date
            // 
            this.date.HeaderText = "Дата выдачи";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // Passports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.add);
            this.Controls.Add(this.table);
            this.Name = "Passports";
            this.Text = "Passports";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn issued;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}