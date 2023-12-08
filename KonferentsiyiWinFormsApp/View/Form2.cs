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
    public partial class Form2 : Form
    {
        private MySqlCommand cmd;
        string query;

        public Form2()
        {          
            InitializeComponent();

            query = @"select * from kafedry order by nazva_kafedry";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Form1.con);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "kafedry");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "kafedry";
            dataGridView1.Columns[0].HeaderText = "Код кафедри";
            dataGridView1.Columns[1].HeaderText = "Назва кафедри";
            dataGridView1.Columns[2].HeaderText = "Розсташування";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Refresh();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Кафедри";
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 700;
            this.Height = 600;

            dataGridView1.Width = 600;
            dataGridView1.Height = 300;
            dataGridView1.Location = new Point(30, 60);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ReadOnly = true;
        }
    }
}
