using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
