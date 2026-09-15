using System;
using System.Collections.Generic;

namespace ProjetCegep.Modeles
{
    public class Cours
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

        private DateTime dateDebut;
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        private DateTime dateFin;
        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

        private Enseignant enseignant;

        private List<Etudiant> listeEtudiant;

        public Cours() { }

        public Cours(string unNo, string unNom, string uneDescription)
        {
            No = unNo;
            Nom = unNom;
            Description = uneDescription;
            DateDebut = DateTime.Now;
            DateFin = new DateTime(1900, 1, 1);
            enseignant = new Enseignant();
            listeEtudiant = new List<Etudiant>();
        }

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

        public Enseignant ObtenirEnseignant()
        {
            return enseignant;
        }

        public Enseignant ObtenirEnseignant(Enseignant unEnseignant)
        {
            if (enseignant.Equals(unEnseignant))
                return enseignant;
            return null;
        }

        public bool SiEnseignantPresent(Enseignant unEnseignant)
        {
            if (enseignant.Equals(unEnseignant))
                return true;
            return false;
        }

        public bool AjouterEnseignant(Enseignant unEnseignant)
        {
            if (SiEnseignantPresent(unEnseignant))
            return false;
            enseignant = unEnseignant;
            return SiEnseignantPresent(unEnseignant);
        }

        public bool EnleverEnseignant(Enseignant unEnseignant)
        {
            if (!SiEnseignantPresent(unEnseignant))
            return false;
            enseignant = null;
            return !SiEnseignantPresent(unEnseignant);
        }

        public bool SiAucunEnseignant()
        {
            return enseignant == null;
        }

        public override string ToString()
        {
            return Nom;
        }

        public override bool Equals(object obj)
        {
            return (obj != null) && (obj is Cours) && Nom.Equals((obj as Cours).Nom);
        }

        public override int GetHashCode()
        {
            return Nom.Length;
        }
    }
}
