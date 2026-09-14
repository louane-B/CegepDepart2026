using System.Collections.Generic;

namespace ProjetCegep.Modeles
{
    public class Cegep
    {
        //Propriétés et attribus
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

        public List<Departement> listeDepartement;

        public Cegep() { }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="unNom">Le nom du cégep</param>
        /// <param name="uneAdresse">L'adresse du cégep</param>
        /// <param name="uneVille">La ville du cégep</param>
        /// <param name="uneProvince">La province du cégep</param>
        /// <param name="unCodePostal">Le code postal du cégep</param>
        /// <param name="unTelephone">Le téléphone du cégep</param>
        /// <param name="unCourriel">Le courriel du cégep</param>
        public Cegep(string unNom = "", string uneAdresse = "", string uneVille = "", string uneProvince = "", string unCodePostal = "", string unTelephone = "", string unCourriel = "")
        {
            Nom = unNom;
            Adresse = uneAdresse;
            Ville = uneVille;
            Province = uneProvince;
            CodePostal = unCodePostal;
            Telephone = unTelephone;
            Courriel = unCourriel;
            listeDepartement = new List<Departement>();
        }

        /// <summary>
        /// Permet l'obtenir la liste des départements du cégep
        /// </summary>
        /// <returns>un tableau de département</returns>
        public Departement[] ObtenirListeDepartement()
        {
            return listeDepartement.ToArray();
        }

        /// <summary>
        /// Permet d'obtenir un département.
        /// </summary>
        /// <param name="unDepartement">L'objet département que l'on veut avoir</param>
        /// <returns>le département qui correspond ou null si l'on a rien trouvé</returns>
        public Departement ObtenirDepartement(Departement unDepartement)
        {
            foreach (Departement departement in listeDepartement)
            {
            if (departement.Equals(unDepartement))
                return departement;
            }
            return null;
        }

        /// <summary>
        /// Vérifier si un département est présent dans la liste
        /// </summary>
        /// <param name="unDepartement">Le département que l'on cherche</param>
        /// <returns>vrai si le département est trouvé, faux sinon</returns>
        public bool SiDepartementPresent(Departement unDepartement)
        {
            foreach (Departement departement in listeDepartement)
            {
            if (departement.Equals(unDepartement))
                return true;
            }
            return false;
        }

        /// <summary>
        /// Permet d'ajouter un département à la liste.
        /// </summary>
        /// <param name="unDepartement">Le département à ajouter</param>
        /// <returns>Vrai si le département c'est bien ajouté, faux sinon</returns>
        public bool AjouterDepartement(Departement unDepartement)
        {
            if (SiDepartementPresent(unDepartement))
            return false;
            listeDepartement.Add(unDepartement);
            return SiDepartementPresent(unDepartement);
        }

        public bool EnleverDepartement(Departement unDepartement)
        {
            if (!SiDepartementPresent(unDepartement))
            return false;
            listeDepartement.Remove(unDepartement);
            return !SiDepartementPresent(unDepartement);
        }

        public int ObtenirNombreDepartement()
        {
            return listeDepartement.Count;
        }

        public bool SiAucunDepartement()
        {
            return ObtenirNombreDepartement() == 0;
        }

        public bool ViderListeDepartement()
        {
            if (ObtenirNombreDepartement() == 0)
            return false;
            listeDepartement.Clear();
            return SiAucunDepartement();
        }

        public override string ToString()
        {
            return (Nom + "\n" + Adresse + "\n" + Ville + ", "
                    + Province + "\n" + CodePostal + "\n" + Telephone + "\n" + Courriel);
        }

        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Cegep) && Nom.Equals((obj as Cegep).Nom);
        }

        public override int GetHashCode()
        {
            return Nom.Length;
        }
    }
}
