
namespace ProjetCegep.Modeles
{
    public class Personne
    {
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string province;
        public string Province
        {
            get { return province; }
            set { province = value; }
        }

        private string codePostal;
        public string CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }


        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string courriel;
        public string Courriel
        {
            get { return courriel; }
            set { courriel = value; }
        }

        public Personne() {}            
    
        public Personne(string unPrenom="", string unNom="", string uneAdresse="", string uneVille="", string uneProvince="", string unCodePostal="", string unTelephone="", string unCourriel="")
        {
            Prenom = unPrenom;
            Nom = unNom;
            Adresse = uneAdresse;
            Ville = uneVille;
            Province = uneProvince;
            CodePostal = unCodePostal;
            Telephone = unTelephone;
            Courriel = unCourriel;
        }
    }
}
