namespace SCHEF
{
    partial class menu_form
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
            this.back_button = new System.Windows.Forms.Button();
            this.dessert = new System.Windows.Forms.Button();
            this.drink = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(1177, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dessert
            // 
            this.dessert.BackColor = System.Drawing.Color.Transparent;
            this.dessert.BackgroundImage = global::SCHEF.Properties.Resources.dessert;
            this.dessert.FlatAppearance.BorderSize = 0;
            this.dessert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessert.Location = new System.Drawing.Point(977, 220);
            this.dessert.Name = "dessert";
            this.dessert.Size = new System.Drawing.Size(225, 225);
            this.dessert.TabIndex = 4;
            this.dessert.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dessert.UseCompatibleTextRendering = true;
            this.dessert.UseVisualStyleBackColor = false;
            this.dessert.Click += new System.EventHandler(this.dessert_Click);
            // 
            // drink
            // 
            this.drink.BackColor = System.Drawing.Color.Transparent;
            this.drink.BackgroundImage = global::SCHEF.Properties.Resources.drink;
            this.drink.FlatAppearance.BorderSize = 0;
            this.drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drink.Location = new System.Drawing.Point(677, 220);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(225, 225);
            this.drink.TabIndex = 3;
            this.drink.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.drink.UseCompatibleTextRendering = true;
            this.drink.UseVisualStyleBackColor = false;
            this.drink.Click += new System.EventHandler(this.drink_Click);
            // 
            // second
            // 
            this.second.BackColor = System.Drawing.Color.Transparent;
            this.second.BackgroundImage = global::SCHEF.Properties.Resources.first1;
            this.second.FlatAppearance.BorderSize = 0;
            this.second.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.second.Location = new System.Drawing.Point(377, 220);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(225, 225);
            this.second.TabIndex = 2;
            this.second.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.second.UseCompatibleTextRendering = true;
            this.second.UseVisualStyleBackColor = false;
            this.second.Click += new System.EventHandler(this.second_Click);
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.Color.Transparent;
            this.first.BackgroundImage = global::SCHEF.Properties.Resources.first2;
            this.first.FlatAppearance.BorderSize = 0;
            this.first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.first.Location = new System.Drawing.Point(77, 220);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(225, 225);
            this.first.TabIndex = 5;
            this.first.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.first.UseCompatibleTextRendering = true;
            this.first.UseVisualStyleBackColor = false;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Первое";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Второе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Напиток";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1063, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Десерт";
            // 
            // menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.first);
            this.Controls.Add(this.dessert);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.second);
            this.Controls.Add(this.back_button);
            this.Name = "menu_form";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Button drink;
        private System.Windows.Forms.Button dessert;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}