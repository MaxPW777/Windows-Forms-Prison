using System;
using System.Collections.Generic;
using System.Configuration;
using ClackosProj2;
using MySql.Data.MySqlClient;

public class PrisonnierManager
{
    private string request;
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

    public PrisonnierManager(string request)
    {
        this.request = request;
    }

    public List<Prisonnier> GetAllPrisonners()
    {
        List<Prisonnier> prisonniers = new List<Prisonnier>();

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

                        prisonniers.Add(new Prisonnier
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
                            DateNaissance = dateNaissance
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // Gérer les erreurs ici si nécessaire
            }
            foreach (Prisonnier prisonnier in prisonniers)
            {
                Console.WriteLine($"Nom: {prisonnier.Nom}, ID: {prisonnier.ID}, Prénom: {prisonnier.Prenom}, Photo: {prisonnier.Photo}");
            }
        }
        return prisonniers;
    }
}
