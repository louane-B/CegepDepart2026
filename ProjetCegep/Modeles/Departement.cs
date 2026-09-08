using System.Collections.Generic;

namespace ProjetCegep
{
    public class Departement
    {
        private string no;
        public string No
        {
            get { return no; }
            set { no = value; }
        }

        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private List<Etudiant> listeEtudiant;

        public List<Enseignant> listeEnseignant;

        private List<Cours> listeCours;

        public Departement() { }

        public Departement(string unNo = "", string unNom = "", string uneDescription = "")
        {
            No = unNo;
            Nom = unNom;
            Description = uneDescription;
            listeEtudiant = new List<Etudiant>();
            listeEnseignant = new List<Enseignant>();
            listeCours = new List<Cours>();
        }

        //liste étudiants
        public Etudiant[] ObtenirListeEtudiant()
        {
            return listeEtudiant.ToArray();
        }

        public Etudiant ObtenirEtudiant(Etudiant unEtudiant)
        {
            foreach (Etudiant etudiant in listeEtudiant)
            {
            if (etudiant.Equals(unEtudiant))
                return etudiant;
            }
            return null;
        }

        public bool SiEtudiantPresent(Etudiant unEtudiant)
        {
            foreach (Etudiant etudiant in listeEtudiant)
            {
            if (etudiant.Equals(unEtudiant))
                return true;
            }
            return false;
        }

        public bool AjouterEtudiant(Etudiant unEtudiant)
        {
            if (SiEtudiantPresent(unEtudiant))
            return false;
            listeEtudiant.Add(unEtudiant);
            return SiEtudiantPresent(unEtudiant);
        }

        public bool EnleverEtudiant(Etudiant unEtudiant)
        {
            if (!SiEtudiantPresent(unEtudiant))
            return false;
            listeEtudiant.Remove(unEtudiant);
            return !SiEtudiantPresent(unEtudiant);
        }

        public int ObtenirNombreEtudiant()
        {
            return listeEtudiant.Count;
        }

        public bool SiAucunEtudiant()
        {
            return ObtenirNombreEtudiant() == 0;
        }

        public bool ViderListeEtudiant()
        {
            if (ObtenirNombreEtudiant() == 0)
            return false;
            listeEtudiant.Clear();
            return SiAucunEtudiant();
        }


        //liste enseignants
        public Enseignant[] ObtenirListeEnseignant()
        {
            return listeEnseignant.ToArray();
        }

        public Enseignant ObtenirEnseignant(Enseignant unEnseignant)
        {
            foreach (Enseignant enseignant in listeEnseignant)
            {
            if (enseignant.Equals(unEnseignant))
                return enseignant;
            }
            return null;
        }

        public bool SiEnseignantPresent(Enseignant unEnseignant)
        {
            foreach (Enseignant enseignant in listeEnseignant)
            {
            if (enseignant.Equals(unEnseignant))
                return true;
            }
            return false;
        }

        public bool AjouterEnseignant(Enseignant unEnseignant)
        {
            if (SiEnseignantPresent(unEnseignant))
            return false;
            listeEnseignant.Add(unEnseignant);
            return SiEnseignantPresent(unEnseignant);
        }

        public bool EnleverEnseignant(Enseignant unEnseignant)
        {
            if (!SiEnseignantPresent(unEnseignant))
            return false;
            listeEnseignant.Remove(unEnseignant);
            return !SiEnseignantPresent(unEnseignant);
        }

        public int ObtenirNombreEnseignant()
        {
            return listeEnseignant.Count;
        }

        public bool SiAucunEnseignant()
        {
            return ObtenirNombreEnseignant() == 0;
        }

        public bool ViderListeEnseignant()
        {
            if (ObtenirNombreEnseignant() == 0)
            return false;
            listeEnseignant.Clear();
            return SiAucunEnseignant();
        }


        // liste cours
        public Cours[] ObtenirListeCours()
        {
            return listeCours.ToArray();
        }

        public Cours ObtenirCours(Cours unCours)
        {
            foreach (Cours cours in listeCours)
            {
            if (cours.Equals(unCours))
                return cours;
            }
            return null;
        }

        public bool SiCoursPresent(Cours unCours)
        {
            foreach (Cours cours in listeCours)
            {
            if (cours.Equals(unCours))
                return true;
            }
            return false;
        }

        public bool AjouterCours(Cours unCours)
        {
            if (SiCoursPresent(unCours))
            return false;
            listeCours.Add(unCours);
            return SiCoursPresent(unCours);
        }

        public bool EnleverCours(Cours unCours)
        {
            if (!SiCoursPresent(unCours))
            return false;
            listeCours.Remove(unCours);
            return !SiCoursPresent(unCours);
        }

        public int ObtenirNombreCours()
        {
            return listeCours.Count;
        }

        public bool SiAucunCours()
        {
            return ObtenirNombreEnseignant() == 0;
        }

        public bool ViderListeCours()
        {
            if (ObtenirNombreEnseignant() == 0)
                return false;
            listeEnseignant.Clear();
            return SiAucunEnseignant();
        }

        public override string ToString()
        {
            return Nom;
        }

        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Departement) && Nom.Equals((obj as Departement).Nom);
        }

        public override int GetHashCode()
        {
            return Nom.Length;
        }
    }
}
