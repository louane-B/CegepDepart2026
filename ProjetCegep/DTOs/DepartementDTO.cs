using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCegep.Modeles;

namespace ProjetCegep.DTOs
{
    /// <summary>
    /// Permet de transporter les informations du modèle Departement vers la vue
    /// sans exposer directement le modèle, en utlillisant le DepartementDTO.
    /// </summary>
    public class DepartementDTO
    {
        // ------------------------------
        // Propriétés du DTO
        // ------------------------------

        /// <summary>
        /// Le numéro du département.
        /// </summary>
        public string No {  get; set; }

        /// <summary>
        /// Le nom du département.
        /// </summary>
        public string Nom {  get; set; }

        /// <summary>
        /// La description du département.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// La liste des enseignants du département.
        /// </summary>
        public List<string> Enseignants { get; set; }

        // ------------------------------
        // Constructeurs
        // ------------------------------

        /// <summary>
        /// Constructeur permettant d'initialiser un DTO de département
        /// avec ses informations principales.
        /// </summary>
        /// <param name="unNo">Le numéro du département</param>
        /// <param name="unNom">Le nom du département</param>
        /// <param name="uneDescription">La description du département</param>
        public DepartementDTO(string unNo = "", string unNom = "", string uneDescription = "") 
        {
            No = unNo;
            Nom = unNom;
            Description = uneDescription;

            // La liste des enseignants peut être remplie plus tard
            Enseignants = new List<string>();
        }

        /// <summary>
        /// Constructeur permettant de convertir un modèle Departement vers un objet DepartementDTO 
        /// pour l'utiliser dans la vue.
        /// </summary>
        /// <param name="leDepartement">Le modèle Departement à convertir</param>
        public DepartementDTO(Departement leDepartement)
        {
            No = leDepartement.No;
            Nom = leDepartement.Nom;
            Description = leDepartement.Description;

            // Conversion des enseignants en liste de chaînes
            Enseignants = new List<string>();
            foreach (Enseignant e in leDepartement.ObtenirListeEnseignant())
            {
                Enseignants.Add(e.Nom);
            }
        }

        // ------------------------------
        // Overrides
        // ------------------------------

        /// <summary>
        /// Retourne une représentation textuelle du département.
        /// </summary>
        /// <returns>Une chaîne contenant le numéro, le nom et la description</returns>
        public override string ToString()
        {
            return $"{No} - {Nom} : {Description}";
        }
    }
}
