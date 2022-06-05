using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SCHEF
{
    public partial class products_in_stock_form : Form
    {

        DataBase database = new DataBase();

        public products_in_stock_form()
        {
            InitializeComponent();

            LoadData();
        }


        private void LoadData()
        {
            

            database.openConnection();

            string query = "SELECT * FROM ingredients ORDER BY id";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();

            database.closeConnection();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void back_button_Click(object sender, EventArgs e) // кнопка "назад"
        {
            this.Close();
            main_page mp = new main_page();
            mp.Show();
        }

    }
}
