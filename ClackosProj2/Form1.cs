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

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the LabelContainer class
            LabelContainer labelContainer = new LabelContainer();

            // Add the labels to the form
            Controls.Add(labelContainer.Label1);
            Controls.Add(labelContainer.Label2);

            // You may want to set the position and size of the labels
            labelContainer.Label1.Location = new System.Drawing.Point(100, 100);
            labelContainer.Label2.Location = new System.Drawing.Point(100, 130);
        }
    }

    // Custom class to hold the labels
    public class LabelContainer
    {
        public Label Label1 { get; }
        public Label Label2 { get; }

        public LabelContainer()
        {
            Label1 = new Label();
            Label2 = new Label();

            // Set properties for the labels
            Label1.Text = "MAX";
            Label2.Text = "MAX";
            Label1.ForeColor = System.Drawing.Color.Blue;
            Label2.ForeColor = System.Drawing.Color.Red;
            Label1.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            Label2.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
        }
    }
}
}
