using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetCegep.DTOs;
using ProjetCegep.Modeles;

namespace ProjetCegep.Controleurs
{
    public class CegepControleur
    {
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

        /// <summary>
        /// 
        /// </summary>
        private CegepControleur()
        {
            monCegep = null;
        }

        public void ChargerDonneesFichier()
        {

        }

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
                    monCegep.Courriel != cegep.Courriel;
                    return true;
                }
            return false;
        }
    }
}
