using System;
using System.Collections.Generic;
using System.Configuration;
using ClackosProj2;
using MySql.Data.MySqlClient;

public class PrisonnierManager
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
                        string infraction = reader.IsDBNull(reader.GetOrdinal("Infraction")) ? null : reader.GetString("Infraction");
                        int? cellule = reader.IsDBNull(reader.GetOrdinal("Numero_de_cellule")) ? (int?)null : reader.GetInt32("Numero_de_cellule");


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
            foreach (Prisonnier prisonnier in prisonniers)
            {
                Console.WriteLine($"Nom: {prisonnier.Nom}, ID: {prisonnier.ID}, Prénom: {prisonnier.Prenom}, Photo: {prisonnier.Photo}, Adresse: {prisonnier.Adresse}, Date d'entrée: {prisonnier.DateEntree}, Date de sortie: {prisonnier.DateSortie}, Genre: {prisonnier.Genre}, Statut: {prisonnier.Statut}, Date de naissance: {prisonnier.DateNaissance}, Infraction: {prisonnier.Infraction}, Cellule: {prisonnier.Cellule}");
            }
        }
        return prisonniers;
    }
}
