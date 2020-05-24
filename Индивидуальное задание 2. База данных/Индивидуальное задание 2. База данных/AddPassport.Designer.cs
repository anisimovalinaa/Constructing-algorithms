namespace Индивидуальное_задание_2.База_данных
{
    partial class AddPassport
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
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.series = new System.Windows.Forms.RichTextBox();
            this.number = new System.Windows.Forms.RichTextBox();
            this.issued = new System.Windows.Forms.RichTextBox();
            this.birthplace = new System.Windows.Forms.RichTextBox();
            this.date = new System.Windows.Forms.RichTextBox();
            this.code = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(289, 307);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(139, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кем выдан:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Место рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Код подразделения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата выдачи:";
            // 
            // series
            // 
            this.series.Location = new System.Drawing.Point(120, 48);
            this.series.Name = "series";
            this.series.Size = new System.Drawing.Size(163, 23);
            this.series.TabIndex = 7;
            this.series.Text = "";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(120, 90);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(163, 22);
            this.number.TabIndex = 8;
            this.number.Text = "";
            // 
            // issued
            // 
            this.issued.Location = new System.Drawing.Point(120, 130);
            this.issued.Name = "issued";
            this.issued.Size = new System.Drawing.Size(377, 23);
            this.issued.TabIndex = 9;
            this.issued.Text = "";
            // 
            // birthplace
            // 
            this.birthplace.Location = new System.Drawing.Point(120, 172);
            this.birthplace.Name = "birthplace";
            this.birthplace.Size = new System.Drawing.Size(163, 23);
            this.birthplace.TabIndex = 10;
            this.birthplace.Text = "";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(120, 258);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(163, 24);
            this.date.TabIndex = 11;
            this.date.Text = "";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(120, 215);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(163, 24);
            this.code.TabIndex = 12;
            this.code.Text = "";
            // 
            // AddPassport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 353);
            this.Controls.Add(this.code);
            this.Controls.Add(this.date);
            this.Controls.Add(this.birthplace);
            this.Controls.Add(this.issued);
            this.Controls.Add(this.number);
            this.Controls.Add(this.series);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Name = "AddPassport";
            this.Text = "AddPassport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox series;
        private System.Windows.Forms.RichTextBox number;
        private System.Windows.Forms.RichTextBox issued;
        private System.Windows.Forms.RichTextBox birthplace;
        private System.Windows.Forms.RichTextBox date;
        private System.Windows.Forms.RichTextBox code;
    }
}