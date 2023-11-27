using System;

namespace ClackosProj2
{
    public class Prisonnier
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int ID { get; set; }
        public string Photo { get; set; }
        public string Adresse { get; set; }
        public DateTime DateEntree { get; set; }
        public DateTime DateSortie { get; set; }
        public string Genre { get; set; }
        public string Statut { get; set; }
        public DateTime DateNaissance { get; set; }
    }
}