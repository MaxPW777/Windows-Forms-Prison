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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
        private int textBoxCount = 0; // Add this field to your class

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new TextBox
            TextBox dynamicTextBox = new TextBox();

            // Set properties for the TextBox
            dynamicTextBox.Name = "dynamicTextBox" + textBoxCount; // Make the name unique
            dynamicTextBox.Text = "Generated TextBox";
            dynamicTextBox.Width = 100;
            dynamicTextBox.BackColor = Color.Red;

            // Set the location based on the count of TextBoxes
            int x = (textBoxCount % 3) * 110; // Change '3' to the number of TextBoxes per row
            int y = (textBoxCount / 3) * 30; // Change '30' to the height of the TextBox plus some padding
            dynamicTextBox.Location = new Point(x, y);

            // Add the TextBox to the form's controls
            listePrisonnier.Controls.Add(dynamicTextBox);

            // Optionally, you can handle events for the dynamically generated control
            dynamicTextBox.TextChanged += DynamicTextBox_TextChanged;
            Console.WriteLine("created new textbox");

            textBoxCount++; // Increment the count
        }

        private void DynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event for the dynamically generated TextBox
            // Add your custom logic here
        }
    }
}
