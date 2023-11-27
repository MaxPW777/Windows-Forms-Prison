using System;
using System.Collections.Generic;
using System.Configuration;
using ClackosProj2;
using MySql.Data.MySqlClient;

public class PrisonnierManagerPlus
{
    private string request;
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

    public PrisonnierManagerPlus(string request)
    {
        this.request = request;
    }

    public List<Prisonnier2> GetAllPrisonners()
    {
        List<Prisonnier2> prisonniers = new List<Prisonnier2>();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(request, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nom = reader.GetString("Nom");
                        string prenom = reader.GetString("Prenom");
                        int ID = reader.GetInt32("ID_prisonnier");
                        string photo = reader.GetString("Photo_du_prisonnier");
                        string adresse = reader.GetString("Adresse");
                        string dateEntree = reader.GetString("Date_d_entree_en_prison");
                        string dateSortie = reader.GetString("Date_de_liberation_prevue");
                        string genre = reader.GetString("Genre");
                        string statut = reader.GetString("Statut");
                        string dateNaissance = reader.GetString("Date_de_naissance");
                        string infraction = reader.GetString("Infraction");
                        int cellule = reader.GetInt32("Numero_de_cellule");


                        prisonniers.Add(new Prisonnier2
                        {
                            Nom = nom,
                            Prenom = prenom,
                            ID = ID,
                            Photo = photo,
                            Adresse = adresse,
                            DateEntree = dateEntree,
                            DateSortie = dateSortie,
                            Genre = genre,
                            Statut = statut,
                            DateNaissance = dateNaissance,
                            Infraction = infraction,
                            Cellule = cellule
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Gérer les erreurs ici si nécessaire
            }
            foreach (Prisonnier2 prisonnier in prisonniers)
            {
                //Debug
                Console.WriteLine($"Nom: {prisonnier.Nom}, ID: {prisonnier.ID}, Prénom: {prisonnier.Prenom}, Photo: {prisonnier.Photo}, Adresse: {prisonnier.Adresse}, Date d'entrée: {prisonnier.DateEntree}, Date de sortie: {prisonnier.DateSortie}, Genre: {prisonnier.Genre}, Statut: {prisonnier.Statut}, Date de naissance: {prisonnier.DateNaissance}, Infraction : {prisonnier.Infraction}, Cellule : {prisonnier.Cellule}");
            }
        }
        return prisonniers;
    }
}
