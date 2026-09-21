using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetCegep.Controleurs;
using ProjetCegep.DTOs;
using System.Linq;

namespace TestUnitaireCegepDepart2026
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Setup()
        {
            CegepControleur.Instance.SupprimerCegep();
        }

        [TestMethod]
        public void CreerCegep_DoitCreerUnCegep()
        {
            // Créer le CegepDTO test
            CegepDTO dto = new CegepDTO("Cegep Test", "123 Rue", "VilleTest", "QC", "G0L1B0", "418-555-0000", "test@cegep.com");

            // Utilisation de la fonction CreerCegep
            bool resultat = CegepControleur.Instance.CreerCegep(dto);
            CegepDTO cegep = CegepControleur.Instance.ObtenirCegep();

            // Assert
            Assert.IsTrue(resultat);
            Assert.IsNotNull(cegep);
            Assert.AreEqual("Cegep Test", cegep.Nom);
        }

        [TestMethod]
        public void CreerCegep_DoitEchouerSiNomVide()
        {
            // Arrange
            CegepDTO dto = new CegepDTO("", "123 Rue", "VilleTest", "QC", "G0L1B0", "418-555-0000", "test@cegep.com");

            // Act
            bool resultat = CegepControleur.Instance.CreerCegep(dto);

            // Assert
            Assert.IsFalse(resultat);
        }

        [TestMethod]
        public void CreerCegep_DoitEchouerSiCegepExisteDeja()
        {
            // Arrange
            CegepControleur.Instance.CreerCegep(new CegepDTO("Cegep Test"));

            // Act
            bool resultat = CegepControleur.Instance.CreerCegep(new CegepDTO("Cegep Test"));

            // Assert
            Assert.IsFalse(resultat);
        }
    }
}

        
