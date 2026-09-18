
namespace ProjetCegep.Modeles
{
    public class Enseignant : Personne
    {
        private int noEmploye;
        public int NoEmploye
        {
            get { return noEmploye; }
            set { noEmploye = value; }
        }

        private string dateEmbauche;
        public string DateEmbauche
        {
            get { return dateEmbauche; }
            set { dateEmbauche = value; }
        }

        private string dateArret;
        public string DateArret
        {
            get { return dateArret; }
            set { dateArret = value; }
        }

        public Enseignant() { }

        public Enseignant(int unNoEmploye = 0000000, string unPrenom = "", string unNom = "", string uneAdresse = "", string uneVille = "", string uneProvince = "", string unCodePostal = "", string unTelephone = "", string unCourriel = "", string uneDateEmbauche="", string uneDateArret="")
        {
            NoEmploye = unNoEmploye;
            Prenom = unPrenom;
            Nom = unNom;
            Adresse = uneAdresse;
            Ville = uneVille;
            Province = uneProvince;
            CodePostal = unCodePostal;
            Telephone = unTelephone;
            Courriel = unCourriel;
            DateEmbauche = uneDateEmbauche;
            DateArret = uneDateArret;
            
        }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }

        public override int GetHashCode()
        {
            return NoEmploye.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Enseignant) && NoEmploye.Equals((obj as Enseignant).NoEmploye);
        }
    }
}
