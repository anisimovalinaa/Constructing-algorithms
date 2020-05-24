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
            this.SuspendLayout();
            // 
            // passports
            // 
            this.passports.Location = new System.Drawing.Point(233, 74);
            this.passports.Name = "passports";
            this.passports.Size = new System.Drawing.Size(241, 23);
            this.passports.TabIndex = 0;
            this.passports.Text = "Таблица \"Паспорта\"";
            this.passports.UseVisualStyleBackColor = true;
            this.passports.Click += new System.EventHandler(this.passports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passports;
    }
}

