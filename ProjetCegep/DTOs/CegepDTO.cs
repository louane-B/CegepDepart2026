using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCegep.Modeles;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="ville"></param>
        /// <param name="province"></param>
        /// <param name="codePostal"></param>
        /// <param name="telephone"></param>
        /// <param name="courriel"></param>
        /// <param name="departements"></param>
        public CegepDTO(string nom="", string adresse="", string ville="", string province="", string codePostal="", string telephone="", string courriel="")
        {
            Nom = nom;
            Adresse = adresse;
            Ville = ville;
            Province = province;
            CodePostal = codePostal;
            Telephone = telephone;
            Courriel = courriel;
            Departements = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unCegep"></param>
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
