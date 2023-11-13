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
            int textBoxesPerRow = 5; // Change this to the desired number of TextBoxes per row
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
