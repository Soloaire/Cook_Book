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
    public partial class menu_form : Form
    {
        public menu_form()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e) // кнопка "назад"
        {
            this.Close();
            main_page mp = new main_page();
            mp.Show();
        }

        private void first_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму menu
            first_dish fd = new first_dish();
            fd.Show(); // показывает форму first_dish
        }

        private void second_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму menu
            second_dish sd = new second_dish();
            sd.Show(); // показывает форму second_dish
        }

        private void drink_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму menu
            drink_dish dd = new drink_dish();
            dd.Show(); // показывает форму drink_dish
        }

        private void dessert_Click(object sender, EventArgs e)
        {
            this.Visible = false; // скрывает форму menu
            dessert_dish dds = new dessert_dish();
            dds.Show(); // показывает форму dessert_dish
        }

    }
}
