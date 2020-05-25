namespace Индивидуальное_задание_2.База_данных
{
    partial class AddEvent
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
            this.id = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.tableTypes = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID вида страхования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(151, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(114, 20);
            this.id.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(92, 130);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // tableTypes
            // 
            this.tableTypes.Location = new System.Drawing.Point(24, 12);
            this.tableTypes.Name = "tableTypes";
            this.tableTypes.Size = new System.Drawing.Size(227, 23);
            this.tableTypes.TabIndex = 5;
            this.tableTypes.Text = "Показать таблицу \"Виды страхования\"";
            this.tableTypes.UseVisualStyleBackColor = true;
            this.tableTypes.Click += new System.EventHandler(this.tableTypes_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(113, 74);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(152, 41);
            this.name.TabIndex = 6;
            this.name.Text = "";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 166);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tableTypes);
            this.Controls.Add(this.add);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button tableTypes;
        private System.Windows.Forms.RichTextBox name;
    }
}