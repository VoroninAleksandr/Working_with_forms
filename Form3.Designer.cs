namespace Work_to_form
{
    partial class Form3
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
            this.buttonCancelForm3 = new System.Windows.Forms.Button();
            this.buttonOKForm3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditNamePreoduct = new System.Windows.Forms.TextBox();
            this.textBoxEditCountry = new System.Windows.Forms.TextBox();
            this.textBoxEditPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelForm3
            // 
            this.buttonCancelForm3.Location = new System.Drawing.Point(201, 252);
            this.buttonCancelForm3.Name = "buttonCancelForm3";
            this.buttonCancelForm3.Size = new System.Drawing.Size(121, 29);
            this.buttonCancelForm3.TabIndex = 9;
            this.buttonCancelForm3.Text = "CANCEL";
            this.buttonCancelForm3.UseVisualStyleBackColor = true;
            this.buttonCancelForm3.Click += new System.EventHandler(this.buttonCancelForm3_Click);
            // 
            // buttonOKForm3
            // 
            this.buttonOKForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOKForm3.Location = new System.Drawing.Point(19, 252);
            this.buttonOKForm3.Name = "buttonOKForm3";
            this.buttonOKForm3.Size = new System.Drawing.Size(121, 29);
            this.buttonOKForm3.TabIndex = 10;
            this.buttonOKForm3.Text = "OK";
            this.buttonOKForm3.UseVisualStyleBackColor = true;
            this.buttonOKForm3.Click += new System.EventHandler(this.buttonOKForm3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Страна производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Наименование товара";
            // 
            // textBoxEditNamePreoduct
            // 
            this.textBoxEditNamePreoduct.Location = new System.Drawing.Point(19, 38);
            this.textBoxEditNamePreoduct.Name = "textBoxEditNamePreoduct";
            this.textBoxEditNamePreoduct.Size = new System.Drawing.Size(304, 20);
            this.textBoxEditNamePreoduct.TabIndex = 5;
            // 
            // textBoxEditCountry
            // 
            this.textBoxEditCountry.Location = new System.Drawing.Point(19, 121);
            this.textBoxEditCountry.Name = "textBoxEditCountry";
            this.textBoxEditCountry.Size = new System.Drawing.Size(304, 20);
            this.textBoxEditCountry.TabIndex = 4;
            // 
            // textBoxEditPrice
            // 
            this.textBoxEditPrice.Location = new System.Drawing.Point(18, 204);
            this.textBoxEditPrice.Name = "textBoxEditPrice";
            this.textBoxEditPrice.Size = new System.Drawing.Size(304, 20);
            this.textBoxEditPrice.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCancelForm3);
            this.panel1.Controls.Add(this.textBoxEditNamePreoduct);
            this.panel1.Controls.Add(this.buttonOKForm3);
            this.panel1.Controls.Add(this.textBoxEditCountry);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxEditPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 308);
            this.panel1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 308);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование карточки товара";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelForm3;
        private System.Windows.Forms.Button buttonOKForm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditPrice;
        private System.Windows.Forms.TextBox textBoxEditCountry;
        private System.Windows.Forms.TextBox textBoxEditNamePreoduct;
        private System.Windows.Forms.Panel panel1;
    }
}