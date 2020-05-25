namespace Индивидуальное_задание_2.База_данных
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.passports = new System.Windows.Forms.Button();
            this.types = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.addresses = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passports
            // 
            this.passports.Location = new System.Drawing.Point(233, 74);
            this.passports.Name = "passports";
            this.passports.Size = new System.Drawing.Size(241, 32);
            this.passports.TabIndex = 0;
            this.passports.Text = "Таблица \"Паспорта\"";
            this.passports.UseVisualStyleBackColor = true;
            this.passports.Click += new System.EventHandler(this.passports_Click);
            // 
            // types
            // 
            this.types.Location = new System.Drawing.Point(233, 134);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(241, 30);
            this.types.TabIndex = 1;
            this.types.Text = "Таблица \"Виды страхования\"";
            this.types.UseVisualStyleBackColor = true;
            this.types.Click += new System.EventHandler(this.types_Click);
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(233, 191);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(241, 33);
            this.events.TabIndex = 2;
            this.events.Text = "Таблица \"Страховые события\"";
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // addresses
            // 
            this.addresses.Location = new System.Drawing.Point(233, 249);
            this.addresses.Name = "addresses";
            this.addresses.Size = new System.Drawing.Size(241, 32);
            this.addresses.TabIndex = 3;
            this.addresses.Text = "Таблица \"Адреса\"";
            this.addresses.UseVisualStyleBackColor = true;
            this.addresses.Click += new System.EventHandler(this.addresses_Click);
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(233, 304);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(241, 31);
            this.customers.TabIndex = 4;
            this.customers.Text = "Таблица \"Клиенты\"";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customers);
            this.Controls.Add(this.addresses);
            this.Controls.Add(this.events);
            this.Controls.Add(this.types);
            this.Controls.Add(this.passports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passports;
        private System.Windows.Forms.Button types;
        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button addresses;
        private System.Windows.Forms.Button customers;
    }
}

