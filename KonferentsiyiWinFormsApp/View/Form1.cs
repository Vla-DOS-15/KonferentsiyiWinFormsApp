using System;
using System.Windows.Forms;
using KonferentsiyiWinFormsApp.View;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace KonferentsiyiWinFormsApp
{
    public partial class Form1 : Form
    {
        static public MySqlConnection con = new MySqlConnection();
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

        private void кафедриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void місцяПроживанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
