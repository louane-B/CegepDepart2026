using ProjetCegep.DTOs;
using ProjetCegep.Modeles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ProjetCegep.Controleurs
{
    public class CegepControleur
    {
        #region Singleton
        /// <summary>
        /// 
        /// </summary>
        private Cegep monCegep;
        private Departement newDepartement;

        /// <summary>
        /// 
        /// </summary>
        private static CegepControleur instance;

        /// <summary>
        /// 
        /// </summary>
        public static CegepControleur Instance
        {
            get
            {
                if(Instance == null)
                {
                    instance = new CegepControleur();
                }
                return instance;
            }
        }
        #endregion Singleton

        #region MethodeSerializer
        public void ChargerDonneesFichier()
        {
            if (File.Exists("Cegep.xml"))
            {
                XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
                FileStream fichierLogique;

                fichierLogique = File.OpenRead("Cegep.xml");
                monCegep = (Cegep)leFichierCegep.Deserialize(fichierLogique);
                fichierLogique.Close();
            }
        }

        ///<summary>
        ///
        /// </summary>
        public void SauvegarderDonnesFichier()
        {
            if (File.Exists("Cegep.xml"))
            {
                File.Delete("Cegep.xml");
            }
            XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
            FileStream fichierLogique;

            using (fichierLogique = File.OpenWrite("Cegep.xml"))
            {
                leFichierCegep.Serialize(fichierLogique, monCegep);
            }
        }

        #endregion Utilitaire

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        private CegepControleur()
        {
            monCegep = null;
        }
        #endregion Constructor

        #region MethodeCegep
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cegep"></param>
        /// <returns></returns>
        public bool CreerCegep(CegepDTO cegep)
        {
            monCegep = new Cegep(cegep.Nom, cegep.Adresse, cegep.Ville, cegep.Province, cegep.CodePostal, cegep.Telephone, cegep.Courriel);
            return monCegep != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cegep"></param>
        /// <returns></returns>
        public bool ModifierCegep(CegepDTO cegep)
        {
            if(monCegep.Nom.Equals(cegep.Nom))
                if(monCegep.Adresse != cegep.Adresse ||
                    monCegep.Ville != cegep.Ville ||
                    monCegep.Province != cegep.Province ||
                    monCegep.CodePostal != cegep.CodePostal ||
                    monCegep.Telephone != cegep.Telephone ||
                    monCegep.Courriel != cegep.Courriel)
                {
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
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SupprimerCegep()
        {
            monCegep = null;
            return monCegep == null;
        }

        public CegepDTO ObtenirCegep()
        {
            if (monCegep != null)
                return new CegepDTO(monCegep);
            return null;
        }
        #endregion MethodeCegep

        #region MethodeDepartement

        public List<DepartementDTO> ObtenirListeDepartement()
        {
            if (monCegep == null)
                return null;

            List<DepartementDTO> listDepartementDTOs = new List<DepartementDTO>();
            Departement[] tabDepartement = monCegep.ObtenirListeDepartement();

            foreach (Departement unDepartement in tabDepartement)
            {
                DepartementDTO dto = new DepartementDTO(unDepartement);
                listDepartementDTOs.Add(dto);
            }
            return listDepartementDTOs;
        }

        public DepartementDTO ObtenirDepartement(DepartementDTO ledepartement)
        {
            foreach(Departement departement in monCegep.ObtenirListeDepartement())
            {
                if(departement.No == ledepartement.No)
                {
                    return new DepartementDTO(departement);
                }
            }
            return null;
        }

        public bool AjouterDepartement(DepartementDTO departement)
        {
            newDepartement = new Departement(departement.No, departement.Nom, departement.Description);
            return monCegep.AjouterDepartement(newDepartement);
        }

        public bool SupprimerDepartement(DepartementDTO departementDTO)
        {
            //créer un modèle temporaire avec seulement le NO
            Departement temp = new Departement(departementDTO.No, "", "");

            Departement unDepartement = monCegep.ObtenirDepartement(temp);
            if (unDepartement.No == null)
            {
                return false;
            }
            return monCegep.EnleverDepartement(unDepartement);
        }

        #endregion MethodeDepartement
    }
}
