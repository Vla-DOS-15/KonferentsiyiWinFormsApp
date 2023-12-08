using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace KonferentsiyiWinFormsApp
{
    public partial class Form1 : Form
    {
        static private MySqlConnection con = new MySqlConnection();
        private MySqlCommand cmd;

        public Form1()
        {
            this.Text = "АІС Конференції";
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            InitializeComponent();

            try
            {
                con.ConnectionString = "server=localhost;User Id=root;Persist Security Info=True;database=konferentsiyi_bohdanets_";
                con.Open();
                MessageBox.Show("Підключення відбулось успішно!");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Errror: " + ex.Message);
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевненні, що хочете завершити роботу?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
