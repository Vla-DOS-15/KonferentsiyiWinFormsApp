using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonferentsiyiWinFormsApp.View
{
    public partial class Form3 : Form
    {
        private MySqlCommand cmd;
        string query;

        public Form3()
        {
            InitializeComponent();

            query = @"select * from mistsya_prozhyvannya";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Form1.con);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "kafedry");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "kafedry";
            dataGridView1.Columns[0].HeaderText = "Код місця проживання";
            dataGridView1.Columns[1].HeaderText = "тип проживання";
            dataGridView1.Columns[2].HeaderText = "Назва проживання";
            dataGridView1.Columns[3].HeaderText = "Адреса проживання";
            dataGridView1.Columns[4].HeaderText = "Телефон проживання";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Refresh();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Місця прожвання";
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 700;
            this.Height = 600;

            dataGridView1.Width = 800;
            dataGridView1.Height = 300;
            dataGridView1.Location = new Point(30, 60);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ReadOnly = true;
        }
    }
}
