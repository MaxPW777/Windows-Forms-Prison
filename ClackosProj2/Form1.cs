using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClackosProj2
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();

            // Liez le DataTable au DataGridView
            dataGridView1.DataSource = dataTable;
            //Remplir chaque cellule du tableau avec les informations de la base de données
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nom", typeof(string));
            dataTable.Columns.Add("Prenom", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Genre", typeof(string));
            dataTable.Columns.Add("Adresse", typeof(string));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
