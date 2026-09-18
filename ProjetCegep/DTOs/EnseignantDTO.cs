using ProjetCegep.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCegep.DTOs
{
    public class EnseignantDTO
    {
        public int NoEmploye { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string CodePostal { get; set; }
        public string Telephone { get; set; }
        public string Courriel { get; set; }
        public string DateEmbauche { get; set; }
        public string DateArret {  get; set; }

        public EnseignantDTO(int no=0000000, string unNom="", string unPrenom="", string uneAdresse="", string uneVille="", string uneProvince="", string unCodePostal="", string unTelephone="", string unCourriel="", string uneDateEmbauche="", string uneDateArret="")
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

        public override string ToString()
        {
            return $"{NoEmploye} - {Nom} {Prenom}; Contact: {Telephone}; email: {Courriel}";
        }
    }
}
