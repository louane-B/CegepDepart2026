using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCegep.DTOs
{
    public class CegepDTO
    {
        public string Nom { get; set; }

        public string Adresse { get; set; }

        public string Ville { get; set; }

        public string Province { get; set; }

        public string CodePostal { get; set; }

        public string Telephone { get; set; }

        public string Courriel { get; set; }

        public List<string> Departements { get; set; }

        public CegepDTO()
        {
            Departements = new List<string>();
        }

        public CegepDTO(Cegep unCegep)
        {
            Nom = unCegep.Nom;
            Adresse = unCegep.Adresse;
            Ville = unCegep.Ville;
            Province = unCegep.Province;
            CodePostal = unCegep.CodePostal;
            Telephone = unCegep.Telephone;
            Courriel = unCegep.Courriel;

            Departements = new List<string>();
            foreach (var departement in unCegep.ObtenirListeDepartement())
            {
                Departements.Add($"{departement.No} {departement.Nom}");
            }
        }
    }
}
