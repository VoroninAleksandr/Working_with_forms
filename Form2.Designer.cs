namespace Work_to_form
{
    partial class Form2
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
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCountries = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK_form2 = new System.Windows.Forms.Button();
            this.buttonCancelForm2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(13, 36);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(304, 20);
            this.textBoxNameProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Страна производитель";
            // 
            // textBoxCountries
            // 
            this.textBoxCountries.Location = new System.Drawing.Point(13, 119);
            this.textBoxCountries.Name = "textBoxCountries";
            this.textBoxCountries.Size = new System.Drawing.Size(304, 20);
            this.textBoxCountries.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 202);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(304, 20);
            this.textBoxPrice.TabIndex = 0;
            this.textBoxPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цена";
            // 
            // buttonOK_form2
            // 
            this.buttonOK_form2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_form2.Location = new System.Drawing.Point(13, 250);
            this.buttonOK_form2.Name = "buttonOK_form2";
            this.buttonOK_form2.Size = new System.Drawing.Size(121, 29);
            this.buttonOK_form2.TabIndex = 2;
            this.buttonOK_form2.Text = "OK";
            this.buttonOK_form2.UseVisualStyleBackColor = true;
            this.buttonOK_form2.Click += new System.EventHandler(this.buttonOK_form2_Click);
            // 
            // buttonCancelForm2
            // 
            this.buttonCancelForm2.Location = new System.Drawing.Point(195, 250);
            this.buttonCancelForm2.Name = "buttonCancelForm2";
            this.buttonCancelForm2.Size = new System.Drawing.Size(121, 29);
            this.buttonCancelForm2.TabIndex = 2;
            this.buttonCancelForm2.Text = "CANCEL";
            this.buttonCancelForm2.UseVisualStyleBackColor = true;
            this.buttonCancelForm2.Click += new System.EventHandler(this.buttonCancelForm2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCancelForm2);
            this.panel1.Controls.Add(this.textBoxNameProduct);
            this.panel1.Controls.Add(this.buttonOK_form2);
            this.panel1.Controls.Add(this.textBoxCountries);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 317);
            this.panel1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 317);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карточка товара";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCountries;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK_form2;
        private System.Windows.Forms.Button buttonCancelForm2;
        private System.Windows.Forms.Panel panel1;
    }
}