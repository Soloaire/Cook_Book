using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHEF
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void main_page_Load(object sender, EventArgs e)
        {
           
        }

        private void products_in_stock_button_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму main_page
            products_in_stock_form pisf = new products_in_stock_form();
            pisf.Show(); // показывает форму products_in_stock
        }

        private void menu_button_Click(object sender, EventArgs e)
        { 
            this.Visible = false; // скрывает форму main_page
            menu_form mf = new menu_form();
            mf.Show(); // показывает форму menu
        }

        private void advanced_functionality_button_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму main_page
            advanced_functionality_form aff = new advanced_functionality_form();
            aff.Show(); // показывает форму advanced_functionality
        }
    }
}
