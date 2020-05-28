namespace Индивидуальное_задание_2.База_данных
{
    partial class AddAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.flat = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Улица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер дома:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Квартира:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Почтовый индекс:";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(124, 164);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 6;
            // 
            // flat
            // 
            this.flat.Location = new System.Drawing.Point(124, 205);
            this.flat.Name = "flat";
            this.flat.Size = new System.Drawing.Size(100, 20);
            this.flat.TabIndex = 7;
            // 
            // postcode
            // 
            this.postcode.Location = new System.Drawing.Point(124, 250);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(100, 20);
            this.postcode.TabIndex = 8;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(124, 118);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(100, 20);
            this.street.TabIndex = 9;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(124, 38);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 20);
            this.country.TabIndex = 10;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(124, 75);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 11;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(114, 299);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(110, 39);
            this.add.TabIndex = 12;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "*необязательное поле";
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.street);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.flat);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAddress";
            this.Text = "AddAddress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox flat;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label7;
    }
}