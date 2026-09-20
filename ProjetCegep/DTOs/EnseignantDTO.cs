using ProjetCegep.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCegep.DTOs
{
    /// <summary>
    /// Permet de transporter les informations du modèle Enseignant vers la vue
    /// sans exposer directement le modèle.
    /// </summary>
    public class EnseignantDTO
    {
        // ------------------------------
        // Propriétés du DTO
        // ------------------------------

        /// <summary>
        /// Le numéro d'employé de l'enseignant (identifiant unique).
        /// </summary>
        public int NoEmploye { get; set; }

        /// <summary>
        /// Le nom de famille de l'enseignant.
        /// </summary>
        public string Nom {  get; set; }

        /// <summary>
        /// Le prénom de l'enseignant.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// L'adresse civique de l'enseignant.
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// La ville où réside l'enseignant.
        /// </summary>
        public string Ville { get; set; }

        /// <summary>
        /// La province de résidence de l'enseignant.
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Le code postal de l'enseignant.
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Le numéro de téléphone de l'enseignant.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Le courriel de l'enseignant.
        /// </summary>
        public string Courriel { get; set; }

        /// <summary>
        /// La date d'embauche de l'enseignant.
        /// </summary>
        public string DateEmbauche { get; set; }

        /// <summary>
        /// La date d'arrêt de travail de l'enseignant (si applicable).
        /// </summary>
        public string DateArret {  get; set; }

        // ------------------------------
        // Constructeurs
        // ------------------------------

        /// <summary>
        /// Constructeur permettant d'initialiser un DTO d'enseignant
        /// avec toutes ses informations principales.
        /// </summary>
        /// <param name="no">Le numéro d'employé</param>
        /// <param name="unNom">Le nom de famille</param>
        /// <param name="unPrenom">Le prénom</param>
        /// <param name="uneAdresse">L'adresse civique</param>
        /// <param name="uneVille">La ville</param>
        /// <param name="uneProvince">La province</param>
        /// <param name="unCodePostal">Le code postal</param>
        /// <param name="unTelephone">Le téléphone</param>
        /// <param name="unCourriel">Le courriel</param>
        /// <param name="uneDateEmbauche">La date d'embauche</param>
        /// <param name="uneDateArret">La date d'arrêt</param>
        public EnseignantDTO(int no=0, string unNom="", string unPrenom="", string uneAdresse="", string uneVille="", string uneProvince="", string unCodePostal="", string unTelephone="", string unCourriel="", string uneDateEmbauche="", string uneDateArret="")
        {
            NoEmploye = no;
            Nom = unNom;
            Prenom = unPrenom;
            Adresse = uneAdresse;
            Ville = uneVille;
            Province = uneProvince;
            CodePostal = unCodePostal;
            Telephone = unTelephone;
            Courriel = unCourriel;
            DateEmbauche = uneDateEmbauche;
            DateArret = uneDateArret;
        }

        /// <summary>
        /// Constructeur permettant de convertir un modèle Enseignant
        /// en un objet EnseignantDTO pour l'utiliser dans la vue.
        /// </summary>
        /// <param name="unEnseignant">Le modèle Enseignant à convertir</param>
        public EnseignantDTO(Enseignant unEnseignant)
        {
            NoEmploye = unEnseignant.NoEmploye;
            Nom = unEnseignant.Nom;
            Prenom = unEnseignant.Prenom;
            Adresse = unEnseignant.Adresse;
            Ville = unEnseignant.Ville;
            Province = unEnseignant.Province;
            CodePostal = unEnseignant.CodePostal;
            Telephone = unEnseignant.Telephone;
            Courriel = unEnseignant.Courriel;
            DateEmbauche = unEnseignant.DateEmbauche;
            DateArret = unEnseignant.DateArret;
        }

        // ------------------------------
        // Overrides
        // ------------------------------

        /// <summary>
        /// Retourne une représentation textuelle de l'enseignant.
        /// </summary>
        /// <returns>Une chaîne contenant le numéro, le nom, le prénom et le téléphone</returns>
        public override string ToString()
        {
            return $"{NoEmploye} - {Nom} {Prenom} ({Telephone})";
        }
    }
}
