using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ClackosProj2
{

    public partial class Form1 : Form
    {

        public List<Prisonnier> prisonniers = new List<Prisonnier>();
        public Form1()
        {
            InitializeComponent();
            PrisonnierManager prisonnierManager = new PrisonnierManager("SELECT * FROM prisonnier");
            prisonniers = prisonnierManager.GetAllPrisonners();
        }
       
        private int textBoxCount = 0; // Add this field to your clas

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            Console.WriteLine(search);
            PrisonnierManager prisonnierManager2 = new PrisonnierManager("SELECT * FROM prisonnier WHERE Nom LIKE '%" + search + "%' OR Prenom LIKE '%" + search + "%'");
            prisonniers = prisonnierManager2.GetAllPrisonners();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int textBoxesPerRow = 6; // Change this to the desired number of TextBoxes per row
            int textBoxWidth = 100;
            int textBoxHeight = 30;
            int paddingX = 10;
            int paddingY = 10;

            for (int i = 0; i < 20; i++) // Change '20' to the desired total number of TextBoxes
            {
                // Create a new TextBox
                TextBox dynamicTextBox = new TextBox();

                // Set properties for the TextBox
                dynamicTextBox.Name = "dynamicTextBox" + textBoxCount;
                dynamicTextBox.Text = "Generated TextBox";
                dynamicTextBox.Width = textBoxWidth;
                dynamicTextBox.BackColor = Color.Red;

                // Set the location based on the count of TextBoxes
                int row = textBoxCount / textBoxesPerRow;
                int col = textBoxCount % textBoxesPerRow;
                int x = col * (textBoxWidth + paddingX);
                int y = row * (textBoxHeight + paddingY);
                dynamicTextBox.Location = new Point(x, y);

                // Add the TextBox to the form's controls
                listePrisonnier.Controls.Add(dynamicTextBox);

                // Optionally, you can handle events for the dynamically generated control
                dynamicTextBox.TextChanged += DynamicTextBox_TextChanged;

                Console.WriteLine("created new textbox");
                textBoxCount++; // Increment the count
            }
        }

        private void DynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event for the dynamically generated TextBox
            // Add your custom logic here
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
