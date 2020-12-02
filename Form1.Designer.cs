namespace Work_to_form
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
            this.MyList = new System.Windows.Forms.ListBox();
            this.buttonInputProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyList
            // 
            this.MyList.FormattingEnabled = true;
            this.MyList.Location = new System.Drawing.Point(13, 13);
            this.MyList.Name = "MyList";
            this.MyList.Size = new System.Drawing.Size(422, 316);
            this.MyList.TabIndex = 0;
            // 
            // buttonInputProduct
            // 
            this.buttonInputProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonInputProduct.Location = new System.Drawing.Point(13, 335);
            this.buttonInputProduct.Name = "buttonInputProduct";
            this.buttonInputProduct.Size = new System.Drawing.Size(422, 30);
            this.buttonInputProduct.TabIndex = 1;
            this.buttonInputProduct.Text = "Добавить товар";
            this.buttonInputProduct.UseVisualStyleBackColor = true;
            this.buttonInputProduct.Click += new System.EventHandler(this.buttonInputProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonEditProduct.Location = new System.Drawing.Point(13, 371);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(422, 30);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.Text = "Редактировать товар";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonDeleteProduct.Location = new System.Drawing.Point(12, 407);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(422, 30);
            this.buttonDeleteProduct.TabIndex = 1;
            this.buttonDeleteProduct.Text = "Удалить товар";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Font = new System.Drawing.Font("Arial", 12F);
            this.buttonClearList.Location = new System.Drawing.Point(13, 443);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(422, 30);
            this.buttonClearList.TabIndex = 1;
            this.buttonClearList.Text = "Очистить список товаров";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 484);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonInputProduct);
            this.Controls.Add(this.MyList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог товаров";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MyList;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonInputProduct;
    }
}

