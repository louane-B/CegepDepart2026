using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCegep.Modeles;

namespace ProjetCegep.DTOs
{
    /// <summary>
    /// la CegepDTO permet de transférer les donner vers la vue sans que la vue est accès directement au model
    /// </summary>
    public class CegepDTO
    {
        // ------------------------------
        // Propriété du DTO
        // ------------------------------

        /// <summary>
        /// Le nom du cégep
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// L'adresse civique du cégep
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// La Ville où se trouve le Cegep
        /// </summary>
        public string Ville { get; set; }

        /// <summary>
        /// La province du Cegep
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Le code postal du Cegep
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Le numéro de téléphone du Cegep
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Le couriel du Cegep
        /// </summary>
        public string Courriel { get; set; }

        /// <summary>
        /// La liste des départements du Cegep
        /// </summary>
        public List<string> Departements { get; set; }

        // ------------------------------
        // Constructueur
        // ------------------------------

        /// <summary>
        /// Constructeur permetent d'initialiser un DTO de Cegep
        /// avec ses informations principales.
        /// </summary>
        /// <param name="nom">Le nom du Cegep</param>
        /// <param name="adresse">L'adresse du Cegep</param>
        /// <param name="ville">La ville du Cegep</param>
        /// <param name="province">La province du Cegep</param>
        /// <param name="codePostal">Le code postal du Cegep</param>
        /// <param name="telephone">Le téléphone du Cegep</param>
        /// <param name="courriel">Le courriel du Cegep</param>
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

            // La liste des départements peut être remplie plus tard
            Departements = new List<string>();
        }

        /// <summary>
        /// Le constructeur qui permet de convertir un Cegep Model en un objet CegepDTO
        /// pour l'utiliser dans la vue
        /// </summary>
        /// <param name="unCegep">Le modèle Cegep à convertir</param>
        public CegepDTO(Cegep unCegep)
        {
            Nom = unCegep.Nom;
            Adresse = unCegep.Adresse;
            Ville = unCegep.Ville;
            Province = unCegep.Province;
            CodePostal = unCegep.CodePostal;
            Telephone = unCegep.Telephone;
            Courriel = unCegep.Courriel;

            // Conversion des départements en liste de chaînes
            Departements = new List<string>();
            foreach (Departement d in unCegep.ObtenirListeDepartement())
            {
                Departements.Add(d.Nom);
            }
        }
    }
}
