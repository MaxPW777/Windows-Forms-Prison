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
        public List<Prisonnier2> prisonniersPlus = new List<Prisonnier2>();
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


                Console.WriteLine("created new textbox");
                textBoxCount++; // Increment the count
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customQuery = @"
                                    SELECT 
                                        p.ID_prisonnier,
                                        p.Nom AS Nom,
                                        p.Prenom AS Prenom,
                                        p.Date_de_naissance AS Date_de_naissance,
                                        p.Genre AS Genre,
                                        p.Adresse AS Adresse,
                                        p.Date_d_entree_en_prison AS Date_d_entree_en_prison,
                                        p.Date_de_liberation_prevue AS Date_de_liberation_prevue,
                                        p.Photo_du_prisonnier AS Photo_du_prisonnier,
                                        p.Statut AS Statut,
                                        i.Nom_de_l_infraction AS Infraction,
                                        c.Numero_de_cellule
                                    FROM 
                                        prisonnier p
                                    JOIN 
                                        relation_table rt ON p.ID_prisonnier = rt.ID_prisonnier
                                    JOIN 
                                        infractions i ON rt.ID_infraction = i.ID_infractions
                                    JOIN 
                                        cellules c ON rt.ID_Cellule = c.ID_cellules;";
            PrisonnierManagerPlus prisonnierManagerPlus = new PrisonnierManagerPlus(customQuery);
            prisonniersPlus = prisonnierManagerPlus.GetAllPrisonners();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listePrisonnier.Controls.Clear();
            listePrisonnier.Controls.Add(allInfo);
            allInfo.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prisonnier2 addPrisonnier = new Prisonnier2();
            addPrisonnier.Nom = textBoxNom.Text;
            addPrisonnier.Prenom = textBoxPrenom.Text;
            addPrisonnier.DateNaissance = DateTime.Parse(textBoxBirth.Text);
            addPrisonnier.Genre = textBoxGender.Text;
            addPrisonnier.Adresse = textBoxAdress.Text;
            addPrisonnier.DateEntree = DateTime.Parse(textBoxEntry.Text);
            addPrisonnier.DateSortie = DateTime.Parse(textBoxExit.Text);
            addPrisonnier.Photo = textBoxPhoto.Text;
            addPrisonnier.Statut = textBoxStatus.Text;
            addPrisonnier.Infraction = InfractionBox.Text;
            addPrisonnier.Detail = textBoxDetail.Text;
            addPrisonnier.Peine = textBoxPeine.Text;
            addPrisonnier.Cellule = int.Parse(BoxCellules.Text);
            Console.WriteLine(addPrisonnier.Infraction);
            PrisonnierManagerPlus newPrisonner = new PrisonnierManagerPlus();
            newPrisonner.AddToDatabase(addPrisonnier);
        }
    }
}
