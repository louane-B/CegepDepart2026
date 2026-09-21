using ProjetCegep.DTOs;
using ProjetCegep.Modeles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ProjetCegep.Controleurs
{
    public class CegepControleur
    {
        #region Singleton
        /// <summary>
        /// Le modèle principal représentant le Cegep manipulé par le contrôleur.
        /// </summary>
        private Cegep monCegep;

        /// <summary>
        /// Instance unique du contrôleur (implémentation du patron Singleton).
        /// </summary>
        private static CegepControleur instance;

        /// <summary>
        /// Permet d'obtenir l'instance unique du contrôleur.
        /// Si aucune instance n'existe, elle est créée automatiquement.
        /// </summary>
        public static CegepControleur Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CegepControleur();
                }
                return instance;
            }
        }
        #endregion Singleton

        #region MethodeSerializer

        /// <summary>
        /// Charge les données du cégep à partir du fichier XML "Cegep.xml".
        /// Si le fichier existe, il est désérialisé pour reconstruire l'objet Cegep.
        /// </summary>
        public void ChargerDonneesFichier()
        {
            // Vérifier si le fichier exite avant de tenter de le charger
            if (File.Exists("Cegep.xml"))
            {
                // Prépare un sérialiseur pour le type Cegep
                XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
                FileStream fichierLogique;

                // Ouvre le fichier en lecture
                fichierLogique = File.OpenRead("Cegep.xml");
                // Désérialise le contenu du fichier dans l'objet monCegep
                monCegep = (Cegep)leFichierCegep.Deserialize(fichierLogique);
                // Ferme le flux de fichier
                fichierLogique.Close();
            }
        }

        /// <summary>
        /// Sauvegarde les données du cégep dans le fichier XML "Cegep.xml".
        /// Si un fichier existe déjà, il est supprimé avant d'être recréé.
        /// </summary>
        public void SauvegarderDonnesFichier()
        {
            // Supprime le fichier existant pour éviter les conflits
            if (File.Exists("Cegep.xml"))
            {
                File.Delete("Cegep.xml");
            }

            // Prépare un sérialiseur pour le type Cegep
            XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
            FileStream fichierLogique;

            // Ouvre le fichier en écriture (création ou remplacement)
            using (fichierLogique = File.OpenWrite("Cegep.xml"))
            {
                // sérialize l'objet monCegep dans le fichier XML
                leFichierCegep.Serialize(fichierLogique, monCegep);
            }
        }

        #endregion MethodeSerializer

        #region Constructor

        /// <summary>
        /// Constructeur privé du contrôleur.
        /// Utilisé uniquement par le patron Singleton afin d'empêcher
        /// la création d'autres instances du contrôleur.
        /// </summary>
        private CegepControleur()
        {
            // Le cégep sera chargé plus tard à partir du fichier XML
            monCegep = null;
        }
        #endregion Constructor

        #region MethodeCegep

        /// <summary>
        /// Crée un nouveau Cegep à partir d'un DTO
        /// </summary>
        /// <param name="cegep">Les informations du cégep à créer</param>
        /// <returns>Vrai si le cégep a été créé</returns>
        public bool CreerCegep(CegepDTO cegep)
        {
            // Création du modèle Cegep à partir des données du DTO
            monCegep = new Cegep(cegep.Nom, cegep.Adresse, cegep.Ville, cegep.Province, cegep.CodePostal, cegep.Telephone, cegep.Courriel);
            // Vérifie que l'objet a bien été créé
            return monCegep != null;
        }

        /// <summary>
        /// Modifie les informations du Cegep existant.
        /// </summary>
        /// <param name="cegep">Les nouvelles informations du Cegep</param>
        /// <returns>Vrai si une modification a été effectuée</returns>
        public bool ModifierCegep(CegepDTO cegep)
        {
            // Vérifie que le cégep à modifier est bien le même (comparaison par nom)
            if (monCegep.Nom.Equals(cegep.Nom))
                // Vérifie si au moins une information est différente
                if (monCegep.Adresse != cegep.Adresse ||
                    monCegep.Ville != cegep.Ville ||
                    monCegep.Province != cegep.Province ||
                    monCegep.CodePostal != cegep.CodePostal ||
                    monCegep.Telephone != cegep.Telephone ||
                    monCegep.Courriel != cegep.Courriel)
                {
                    // Applique les modifications
                    monCegep.Adresse = cegep.Adresse;
                    monCegep.Ville = cegep.Ville;
                    monCegep.Province = cegep.Province;
                    monCegep.CodePostal = cegep.CodePostal;
                    monCegep.Telephone = cegep.Telephone;
                    monCegep.Courriel = cegep.Courriel;
                    return true;
                }
            return false;
        }

        /// <summary>
        /// Supprime complètement le cégep.
        /// </summary>
        /// <returns>Vrai si le Cegep a été supprimé</returns>
        public bool SupprimerCegep()
        {
            // Efface l'objet Cegep
            monCegep = null;
            // Vérifie que l'objet est bien supprimé
            return monCegep == null;
        }

        /// <summary>
        /// Permet d'obtenir le cégep sous forme de DTO.
        /// </summary>
        /// <returns>Un CegepDTO ou null si aucun cégep n'existe</returns>
        public CegepDTO ObtenirCegep()
        {
            if (monCegep != null)
                return new CegepDTO(monCegep);
            return null;
        }
        #endregion MethodeCegep

        #region MethodeDepartement

        /// <summary>
        /// Permet d'obtenir la liste des départements du cégep sous forme de DTO.
        /// </summary>
        /// <returns>Une liste de DepartementDTO ou null si aucun cégep n'est chargé</returns>
        public List<DepartementDTO> ObtenirListeDepartement()
        {
            // Vérifie si un cégep est présent
            if (monCegep == null)
                return null;

            // Liste qui contiendra les DTO
            List<DepartementDTO> listDepartementDTOs = new List<DepartementDTO>();
            // Obtient les départements du modèle
            Departement[] tabDepartement = monCegep.ObtenirListeDepartement();

            // Convertit chaque département en DTO
            foreach (Departement unDepartement in tabDepartement)
            {
                DepartementDTO dto = new DepartementDTO(unDepartement);
                listDepartementDTOs.Add(dto);
            }
            return listDepartementDTOs;
        }

        /// <summary>
        /// Permet d'obtenir un département spécifique à partir d'un DTO.
        /// </summary>
        /// <param name="ledepartement">Le DTO contenant le nom du département recherché</param>
        /// <returns>Un DepartementDTO ou null si aucun département ne correspond</returns>
        public DepartementDTO ObtenirDepartement(DepartementDTO ledepartement)
        {
            // Parcourt la liste des départements du cégep
            foreach (DepartementDTO departementdto in ObtenirListeDepartement())
            {
                // Comparaison par nom
                if (departementdto.Nom == ledepartement.Nom)
                {
                    return departementdto;
                }
            }
            return null;
        }

        /// <summary>
        /// Ajoute un département au cégep.
        /// </summary>
        /// <param name="departement">Le DTO du département à ajouter</param>
        /// <returns>Vrai si l'ajout a réussi</returns>
        public bool AjouterDepartement(DepartementDTO departement)
        {
            // Conversion du DTO vers le modèle
            Departement newDepartement = new Departement(departement.No, departement.Nom, departement.Description);
            // Ajout dans le modèle
            return monCegep.AjouterDepartement(newDepartement);
        }

        /// <summary>
        /// Supprime un département du cégep.
        /// </summary>
        /// <param name="departementDTO">Le DTO du département à supprimer</param>
        /// <returns>Vrai si le département a été supprimé</returns>
        public bool SupprimerDepartement(DepartementDTO departementDTO)
        {
            // Recherche du département dans le modèle (comparaison par nom)
            Departement unDepartement = monCegep.ObtenirDepartement(new Departement(departementDTO.No, departementDTO.Nom, departementDTO.Description));
            // Vérifie si le département existe
            if (unDepartement.Nom == null)
            {
                return false;
            }
            // Suppression du département
            return monCegep.EnleverDepartement(unDepartement);
        }

        #endregion MethodeDepartement

        #region MethodeEnseignant

        /// <summary>
        /// Permet d'obtenir la liste des enseignants d'un département.
        /// </summary>
        /// <param name="departementDTO">Le département dont on veut obtenir les enseignants</param>
        /// <returns>Une liste d'EnseignantDTO ou null si le département n'existe pas</returns>
        public List<EnseignantDTO> ObtenirListeEnseignant(DepartementDTO departementDTO)
        {
            if (departementDTO != null)
            {
                // Obtient le vrai département dans le modèle
                Departement trueDepartement = monCegep.ObtenirDepartement(new Departement(departementDTO.No, departementDTO.Nom, departementDTO.Description));

                if (trueDepartement == null)
                    return null;

                // Liste des enseignants en DTO
                List<EnseignantDTO> listEnseignantDTOs = new List<EnseignantDTO>();
                Enseignant[] tabEnseignant = trueDepartement.ObtenirListeEnseignant();

                // Conversion modèle → DTO
                foreach (Enseignant unEnseignant in tabEnseignant)
                {
                    listEnseignantDTOs.Add(new EnseignantDTO(unEnseignant));
                }
                return listEnseignantDTOs;
            }

            return null;
        }

        /// <summary>
        /// Permet d'obtenir un enseignant spécifique dans un département.
        /// </summary>
        /// <param name="departementDTO">Le département où chercher</param>
        /// <param name="enseignantDTO">L'enseignant recherché</param>
        /// <returns>L'EnseignantDTO correspondant ou null</returns>
        public EnseignantDTO ObtenirEnseignant(DepartementDTO departementDTO, EnseignantDTO enseignantDTO)
        {
            if (departementDTO == null)
                return null;

            // Parcourt la liste des enseignants du département
            foreach (EnseignantDTO dtoProf in ObtenirListeEnseignant(departementDTO))
            {
                // Comparaison par numéro d'employé
                if (dtoProf.NoEmploye == enseignantDTO.NoEmploye)
                {
                    return dtoProf;
                }
            }
            return null;
        }

        /// <summary>
        /// Ajoute un enseignant dans un département.
        /// </summary>
        /// <param name="departementDTO">Le département où ajouter</param>
        /// <param name="enseignantDTO">L'enseignant à ajouter</param>
        /// <returns>Vrai si l'ajout a réussi</returns>
        public bool AjouterEnseignant(DepartementDTO departementDTO, EnseignantDTO enseignantDTO)
        {
            if (departementDTO == null)
                return false;

            // Département temporaire pour la comparaison
            Departement temp = new Departement(departementDTO.No, departementDTO.Nom, departementDTO.Description);
            // Obtient le vrai département
            Departement trueDepartement = monCegep.ObtenirDepartement(temp);

            if (trueDepartement == null)
                return false;

            // Conversion DTO → modèle
            Enseignant newEnseignant = new Enseignant(enseignantDTO.NoEmploye, enseignantDTO.Prenom, enseignantDTO.Nom, enseignantDTO.Adresse, enseignantDTO.Ville, enseignantDTO.Province, enseignantDTO.CodePostal, enseignantDTO.Telephone, enseignantDTO.Courriel, enseignantDTO.DateEmbauche, enseignantDTO.DateArret);
            return trueDepartement.AjouterEnseignant(newEnseignant);
        }

        /// <summary>
        /// Modifie les informations d'un enseignant dans un département.
        /// </summary>
        /// <param name="departementDTO">Le département où se trouve l'enseignant</param>
        /// <param name="enseignantDTO">Les nouvelles informations de l'enseignant</param>
        /// <returns>Vrai si une modification a été effectuée</returns>
        public bool ModifierEnseignant(DepartementDTO departementDTO, EnseignantDTO enseignantDTO)
        {
            // Obtient le département dans le modèle
            Departement departementModel = monCegep.ObtenirDepartement(new Departement("", departementDTO.Nom, ""));
            if (departementModel == null)
                return false;

            // Obtient l'enseignant dans le modèle (comparaison par NoEmploye)
            Enseignant enseignantModel = departementModel.ObtenirEnseignant(new Enseignant(enseignantDTO.NoEmploye, "", "", "", "", "", "", "", "", "", ""));
            if (enseignantModel == null)
                return false;

            // Vérifie si au moins une information est différente
            if (enseignantModel.Prenom != enseignantDTO.Prenom ||
                enseignantModel.Nom != enseignantDTO.Nom ||
                enseignantModel.Adresse != enseignantDTO.Adresse ||
                enseignantModel.Ville != enseignantDTO.Ville ||
                enseignantModel.Province != enseignantDTO.Province ||
                enseignantModel.CodePostal != enseignantDTO.CodePostal ||
                enseignantModel.Telephone != enseignantDTO.Telephone ||
                enseignantModel.Courriel != enseignantDTO.Courriel ||
                enseignantModel.DateEmbauche != enseignantDTO.DateEmbauche ||
                enseignantModel.DateArret != enseignantDTO.DateArret)
            {
                // Applique les modifications
                enseignantModel.Prenom = enseignantDTO.Prenom;
                enseignantModel.Nom = enseignantDTO.Nom;
                enseignantModel.Adresse = enseignantDTO.Adresse;
                enseignantModel.Ville = enseignantDTO.Ville;
                enseignantModel.Province = enseignantDTO.Province;
                enseignantModel.CodePostal = enseignantDTO.CodePostal;
                enseignantModel.Telephone = enseignantDTO.Telephone;
                enseignantModel.Courriel = enseignantDTO.Courriel;
                enseignantModel.DateEmbauche = enseignantDTO.DateEmbauche;
                enseignantModel.DateArret = enseignantDTO.DateArret;

                return true;
            }
            return false;

        }

        /// <summary>
        /// Supprime un enseignant d'un département.
        /// </summary>
        /// <param name="departementDTO">Le département où se trouve l'enseignant</param>
        /// <param name="enseignantDTO">L'enseignant à supprimer</param>
        /// <returns>Vrai si la suppression a réussi</returns>
        public bool SupprimerEnseignant(DepartementDTO departementDTO, EnseignantDTO enseignantDTO)
        {
            if(departementDTO == null)
                return false;

            // Obtient le département dans le modèle
            Departement departementModel = monCegep.ObtenirDepartement(new Departement("", departementDTO.Nom, ""));
            if(departementModel == null )
                return false;

            // Obtient l'enseignant dans le modèle
            Enseignant enseignantModel = departementModel.ObtenirEnseignant(new Enseignant(enseignantDTO.NoEmploye, "", "", "", "", "", "", "", "", "", ""));
            // Supprime l'enseignant
            return departementModel.EnleverEnseignant(enseignantModel);

        }
        #endregion MethodeEnseignant
    }
}
