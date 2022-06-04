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
    public partial class products_in_stock_form : Form
    {
        public products_in_stock_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e) // кнопка "назад"
        {
            this.Close();
            main_page mp = new main_page();
            mp.Show();
        }
    }
}
