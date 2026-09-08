
namespace ProjetCegep
{
    public class Enseignant : Personne
    {
        private int noEmploye;
        public int NoEmploye
        {
            get { return noEmploye; }
            set { noEmploye = value; }
        }

        public Enseignant() { }

        public Enseignant(int unNoEmploye = 0000000, string unPrenom = "", string unNom = "", string uneAdresse = "", string uneVille = "", string uneProvince = "", string unCodePostal = "", string unTelephone = "", string unCourriel = "")
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
