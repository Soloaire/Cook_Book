namespace SCHEF
{
    partial class advanced_functionality_form
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
            this.Make_a_dinner_party = new System.Windows.Forms.Button();
            this.Create_a_menu_button = new System.Windows.Forms.Button();
            this.Make_a_dinner_party_button = new System.Windows.Forms.Button();
            this.Generate_an_expense_invoice = new System.Windows.Forms.Button();
            this.Order_restocking_button = new System.Windows.Forms.Button();
            this.Checking_stocks_button = new System.Windows.Forms.Button();
            this.number_of_visitors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Make_a_dinner_party
            // 
            this.Make_a_dinner_party.Location = new System.Drawing.Point(1177, 12);
            this.Make_a_dinner_party.Name = "Make_a_dinner_party";
            this.Make_a_dinner_party.Size = new System.Drawing.Size(75, 23);
            this.Make_a_dinner_party.TabIndex = 0;
            this.Make_a_dinner_party.Text = "Назад";
            this.Make_a_dinner_party.UseVisualStyleBackColor = true;
            this.Make_a_dinner_party.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Create_a_menu_button
            // 
            this.Create_a_menu_button.Location = new System.Drawing.Point(29, 84);
            this.Create_a_menu_button.Name = "Create_a_menu_button";
            this.Create_a_menu_button.Size = new System.Drawing.Size(193, 71);
            this.Create_a_menu_button.TabIndex = 1;
            this.Create_a_menu_button.Text = "Сформировать меню";
            this.Create_a_menu_button.UseVisualStyleBackColor = true;
            // 
            // Make_a_dinner_party_button
            // 
            this.Make_a_dinner_party_button.Location = new System.Drawing.Point(228, 84);
            this.Make_a_dinner_party_button.Name = "Make_a_dinner_party_button";
            this.Make_a_dinner_party_button.Size = new System.Drawing.Size(193, 71);
            this.Make_a_dinner_party_button.TabIndex = 2;
            this.Make_a_dinner_party_button.Text = "Составить званый ужин";
            this.Make_a_dinner_party_button.UseVisualStyleBackColor = true;
            // 
            // Generate_an_expense_invoice
            // 
            this.Generate_an_expense_invoice.Location = new System.Drawing.Point(840, 561);
            this.Generate_an_expense_invoice.Name = "Generate_an_expense_invoice";
            this.Generate_an_expense_invoice.Size = new System.Drawing.Size(193, 71);
            this.Generate_an_expense_invoice.TabIndex = 3;
            this.Generate_an_expense_invoice.Text = "Сформировать расходную накладную";
            this.Generate_an_expense_invoice.UseVisualStyleBackColor = true;
            // 
            // Order_restocking_button
            // 
            this.Order_restocking_button.Location = new System.Drawing.Point(641, 561);
            this.Order_restocking_button.Name = "Order_restocking_button";
            this.Order_restocking_button.Size = new System.Drawing.Size(193, 71);
            this.Order_restocking_button.TabIndex = 4;
            this.Order_restocking_button.Text = "Заказать пополнение запасов";
            this.Order_restocking_button.UseVisualStyleBackColor = true;
            // 
            // Checking_stocks_button
            // 
            this.Checking_stocks_button.Location = new System.Drawing.Point(1039, 561);
            this.Checking_stocks_button.Name = "Checking_stocks_button";
            this.Checking_stocks_button.Size = new System.Drawing.Size(193, 71);
            this.Checking_stocks_button.TabIndex = 5;
            this.Checking_stocks_button.Text = "Проверка запасов";
            this.Checking_stocks_button.UseVisualStyleBackColor = true;
            // 
            // number_of_visitors
            // 
            this.number_of_visitors.Location = new System.Drawing.Point(209, 30);
            this.number_of_visitors.Name = "number_of_visitors";
            this.number_of_visitors.Size = new System.Drawing.Size(100, 20);
            this.number_of_visitors.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите число посетителей";
            // 
            // advanced_functionality_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number_of_visitors);
            this.Controls.Add(this.Checking_stocks_button);
            this.Controls.Add(this.Order_restocking_button);
            this.Controls.Add(this.Generate_an_expense_invoice);
            this.Controls.Add(this.Make_a_dinner_party_button);
            this.Controls.Add(this.Create_a_menu_button);
            this.Controls.Add(this.Make_a_dinner_party);
            this.Name = "advanced_functionality_form";
            this.Text = "Расширенный функционал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Make_a_dinner_party;
        private System.Windows.Forms.Button Create_a_menu_button;
        private System.Windows.Forms.Button Make_a_dinner_party_button;
        private System.Windows.Forms.Button Generate_an_expense_invoice;
        private System.Windows.Forms.Button Order_restocking_button;
        private System.Windows.Forms.Button Checking_stocks_button;
        private System.Windows.Forms.TextBox number_of_visitors;
        private System.Windows.Forms.Label label1;
    }
}