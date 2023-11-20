susing System;
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


            for (int i = 0; i < prisonniers.Count(); i++)
            {
                // Create a new TextBox
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + textBoxCount;
                textBox.Text = prisonniers[i].Nom;
                textBox.TextChanged += new EventHandler(DynamicTextBox_TextChanged);
                textBoxCount++;

                // Calculate the position of the TextBox
                int row = i / textBoxesPerRow;
                int col = i % textBoxesPerRow;
                int x = paddingX + col * (textBoxWidth + paddingX);
                int y = paddingY + row * (textBoxHeight + paddingY);

                // Set the position and size of the TextBox
                textBox.Location = new Point(x, y);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);

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
            PrisonnierManager prisonnierManager3 = new PrisonnierManager(customQuery);
            prisonniers = prisonnierManager3.GetAllPrisonners();
        }

        private void detailsPrisonnier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void afficherPrisonnier_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Afficher prisonnier");
            detailsPrisonnier.Visible = !detailsPrisonnier.Visible;
            pictureBoxPhoto.ImageLocation = "./"+prisonniers[0].Photo;
            Console.WriteLine(prisonniers[0].Photo);
            detailNom.Text = prisonniers[0].Nom;
            detailPrenom.Text = prisonniers[0].Prenom;
            detailID.Text = prisonniers[0].ID.ToString();
            

        }

        private void Nom_Click(object sender, EventArgs e)
        {

        }

        private void detailsPrisonnier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
