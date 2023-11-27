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
    public PrisonnierManagerPlus()
    {
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
                        DateTime dateEntree = reader.GetDateTime("Date_d_entree_en_prison");
                        DateTime dateSortie = reader.GetDateTime("Date_de_liberation_prevue");
                        string genre = reader.GetString("Genre");
                        string statut = reader.GetString("Statut");
                        DateTime dateNaissance = reader.GetDateTime("Date_de_naissance");
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
                Console.WriteLine($"Nom: {prisonnier.Nom}, ID: {prisonnier.ID}, Prénom: {prisonnier.Prenom}, Photo: {prisonnier.Photo}, Adresse: {prisonnier.Adresse}, Date d'entrée: {prisonnier.DateEntree}, Date de sortie: {prisonnier.DateSortie}, Genre: {prisonnier.Genre}, Statut: {prisonnier.Statut}, Date de naissance: {prisonnier.DateNaissance}, Infraction : {prisonnier.Infraction}, Cellule : {prisonnier.Cellule}");
            }
        }
        return prisonniers;
    }
    public void AddToDatabase(Prisonnier2 prisonnier)
    {
        int ID_prisonnier;
        int ID_infraction;
        int ID_cellule;
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string query = "INSERT INTO prisonnier (Nom, Prenom , Date_de_naissance, Genre, Adresse, Date_d_entree_en_prison, Date_de_liberation_prevue, Photo_du_prisonnier, Statut) VALUES (@Nom, @Prenom, @Date_de_naissance, @Genre, @Adresse, @Date_d_entree_en_prison, @Date_de_liberation_prevue, @Photo_du_prisonnier, @Statut)";
            string query2 = $"WITH RankedPrisonniers AS (\r\n    SELECT \r\n        p.ID_prisonnier,\r\n        i.ID_infractions,\r\n        c.ID_cellules,\r\n        ROW_NUMBER() OVER (ORDER BY p.ID_prisonnier DESC) AS RowNum\r\n    FROM \r\n        prisonnier p\r\n    JOIN \r\n        relation_table rt ON p.ID_prisonnier = rt.ID_prisonnier\r\n    JOIN \r\n        infractions i ON rt.ID_infraction = i.ID_infractions\r\n    JOIN \r\n        cellules c ON rt.ID_Cellule = c.ID_cellules\r\n    WHERE Numero_de_cellule = {prisonnier.Cellule}\r\n)\r\nSELECT \r\n    ID_prisonnier,\r\n    ID_infractions,\r\n    ID_cellules\r\nFROM \r\n    RankedPrisonniers\r\nWHERE \r\n    RowNum = 1;";
            string query3 = "INSERT INTO infractions (Nom_de_l_infraction, Description_de_l_infraction, Peine_associee) VALUES (@Nom_de_l_infraction ,@Detail, @Peine)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nom", prisonnier.Nom);
                command.Parameters.AddWithValue("@Prenom", prisonnier.Prenom);
                command.Parameters.AddWithValue("@Date_de_naissance", prisonnier.DateNaissance);
                command.Parameters.AddWithValue("@Genre", prisonnier.Genre);
                command.Parameters.AddWithValue("@Adresse", prisonnier.Adresse);
                command.Parameters.AddWithValue("@Date_d_entree_en_prison", prisonnier.DateEntree);
                command.Parameters.AddWithValue("@Date_de_liberation_prevue", prisonnier.DateSortie);
                command.Parameters.AddWithValue("@Photo_du_prisonnier", prisonnier.Photo);
                command.Parameters.AddWithValue("@Statut", prisonnier.Statut);

                // Ajoutez d'autres paramètres selon vos besoins

                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand(query3, connection))
            {
                command.Parameters.AddWithValue("@Nom_de_l_infraction", prisonnier.Infraction);
                command.Parameters.AddWithValue("@Detail", prisonnier.Detail);
                command.Parameters.AddWithValue("@Peine", prisonnier.Peine);

                // Ajoutez d'autres paramètres selon vos besoins

                command.ExecuteNonQuery();
            }
            using (MySqlCommand command = new MySqlCommand(query2, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ID_prisonnier = reader.GetInt32("ID_prisonnier");
                        ID_infraction = reader.GetInt32("ID_infractions");
                        ID_cellule = reader.GetInt32("ID_cellules");
                        Console.WriteLine($"ID_prisonnier : {ID_prisonnier}, ID_infraction : {ID_infraction}, ID_cellule : {ID_cellule}");

                        using (MySqlConnection connectionInsert = new MySqlConnection(connectionString))
                        {
                            connectionInsert.Open();

                            string queryInsert = $"INSERT INTO relation_table (ID_prisonnier, ID_Cellule, ID_infraction) VALUES ({ID_prisonnier} ,  {ID_cellule}, {ID_infraction})";

                            using (MySqlCommand commandInsert = new MySqlCommand(queryInsert, connectionInsert))
                            {
                                commandInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
