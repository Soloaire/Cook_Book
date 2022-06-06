namespace SCHEF
{
    partial class main_page
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
            this.menu_button = new System.Windows.Forms.Button();
            this.products_in_stock_button = new System.Windows.Forms.Button();
            this.advanced_functionality_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu_button
            // 
            this.menu_button.BackColor = System.Drawing.Color.Transparent;
            this.menu_button.FlatAppearance.BorderSize = 0;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Location = new System.Drawing.Point(445, 90);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(300, 95);
            this.menu_button.TabIndex = 0;
            this.menu_button.TabStop = false;
            this.menu_button.Text = "Меню";
            this.menu_button.UseVisualStyleBackColor = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // products_in_stock_button
            // 
            this.products_in_stock_button.FlatAppearance.BorderSize = 0;
            this.products_in_stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_in_stock_button.Location = new System.Drawing.Point(445, 224);
            this.products_in_stock_button.Name = "products_in_stock_button";
            this.products_in_stock_button.Size = new System.Drawing.Size(300, 95);
            this.products_in_stock_button.TabIndex = 1;
            this.products_in_stock_button.Text = "Продукты на складе";
            this.products_in_stock_button.UseVisualStyleBackColor = true;
            this.products_in_stock_button.Click += new System.EventHandler(this.products_in_stock_button_Click);
            // 
            // advanced_functionality_button
            // 
            this.advanced_functionality_button.FlatAppearance.BorderSize = 0;
            this.advanced_functionality_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanced_functionality_button.Location = new System.Drawing.Point(445, 364);
            this.advanced_functionality_button.Name = "advanced_functionality_button";
            this.advanced_functionality_button.Size = new System.Drawing.Size(300, 95);
            this.advanced_functionality_button.TabIndex = 2;
            this.advanced_functionality_button.Text = "Расширенный функционал";
            this.advanced_functionality_button.UseVisualStyleBackColor = true;
            this.advanced_functionality_button.Click += new System.EventHandler(this.advanced_functionality_button_Click);
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.advanced_functionality_button);
            this.Controls.Add(this.products_in_stock_button);
            this.Controls.Add(this.menu_button);
            this.Name = "main_page";
            this.Text = "Вариант 16. Шеф-повар";
            this.Load += new System.EventHandler(this.main_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_button;
        private System.Windows.Forms.Button products_in_stock_button;
        private System.Windows.Forms.Button advanced_functionality_button;
    }
}

