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

        #region Utilitaire
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

        #endregion MethodeDepartement
    }
}
