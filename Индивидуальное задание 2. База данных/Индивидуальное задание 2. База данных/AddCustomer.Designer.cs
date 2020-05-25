namespace Индивидуальное_задание_2.База_данных
{
    partial class AddCustomer
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.middle_name = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.id_passport = new System.Windows.Forms.TextBox();
            this.jobPlace = new System.Windows.Forms.TextBox();
            this.id_address = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(118, 323);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 36);
            this.add.TabIndex = 0;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пол:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID паспорта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Место работы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID адреса:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Номер телефона:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(153, 36);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(205, 20);
            this.surname.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(153, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(205, 20);
            this.name.TabIndex = 11;
            // 
            // middle_name
            // 
            this.middle_name.Location = new System.Drawing.Point(153, 97);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(205, 20);
            this.middle_name.TabIndex = 12;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(153, 130);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(205, 20);
            this.sex.TabIndex = 13;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(153, 161);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(205, 20);
            this.date.TabIndex = 14;
            // 
            // id_passport
            // 
            this.id_passport.Location = new System.Drawing.Point(153, 191);
            this.id_passport.Name = "id_passport";
            this.id_passport.Size = new System.Drawing.Size(205, 20);
            this.id_passport.TabIndex = 15;
            // 
            // jobPlace
            // 
            this.jobPlace.Location = new System.Drawing.Point(153, 222);
            this.jobPlace.Name = "jobPlace";
            this.jobPlace.Size = new System.Drawing.Size(205, 20);
            this.jobPlace.TabIndex = 16;
            // 
            // id_address
            // 
            this.id_address.Location = new System.Drawing.Point(153, 253);
            this.id_address.Name = "id_address";
            this.id_address.Size = new System.Drawing.Size(205, 20);
            this.id_address.TabIndex = 17;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(153, 286);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(205, 20);
            this.phoneNumber.TabIndex = 18;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 371);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.id_address);
            this.Controls.Add(this.jobPlace);
            this.Controls.Add(this.id_passport);
            this.Controls.Add(this.date);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.middle_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox middle_name;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox id_passport;
        private System.Windows.Forms.TextBox jobPlace;
        private System.Windows.Forms.TextBox id_address;
        private System.Windows.Forms.TextBox phoneNumber;
    }
}