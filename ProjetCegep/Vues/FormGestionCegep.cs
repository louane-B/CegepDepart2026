using ProjetCegep.Controleurs;
using ProjetCegep.DTOs;
using ProjetCegep.Modeles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjetCegep.Vues
{
   public partial class FormGestionCegep : Form
   {
        #region MethodeUtilitaire
        /// <summary>
        /// Constructeur du formulaire Gestion Cégep
        /// </summary>
        public FormGestionCegep()
        {
            InitializeComponent();
            CegepControleur.Instance.ChargerDonneesFichier();
            RemplirListes();
        }

        /// <summary>
        /// Méthode qui permet d'enregistrer le cégep et les listes dans un fichier XML.  Par la suite, on quitte l'application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CegepControleur.Instance.SauvegarderDonnesFichier();
            Application.Exit();
        }

        /// <summary>
        /// Permet de remplir les différentes listes du formulaire 
        /// </summary>
        public void RemplirListes()
        {
             lbxDepartement.DataSource = null;
             lbxDepartementInfoCegep.DataSource = null;
             cbxDepartementEnseignant.DataSource = null;
            if (CegepControleur.Instance.ObtenirCegep() != null)
            {
                List<DepartementDTO> liste = CegepControleur.Instance.ObtenirListeDepartement();

                lbxDepartement.DataSource = liste;
                lbxDepartement.DisplayMember = "Nom";

                lbxDepartementInfoCegep.DataSource = liste;
                lbxDepartementInfoCegep.DisplayMember = "Nom";

                cbxDepartementEnseignant.DataSource = liste;
                cbxDepartementEnseignant.DisplayMember = "Nom";
            }
        }
        #endregion

        #region Onglet Gestion enseignants...

        /// <summary>
        /// Méthode qui permet de mettre à jour les différentes listes d'enseignants
        /// </summary>
        /// <param name="departementDTO">Le département qui à été sélectionné</param>
        public void AfficherListeEnseignantGestionEnseignant(DepartementDTO departementDTO)
        {
            lbxEnseignantsSaisie.Items.Clear();

            var liste = CegepControleur.Instance.ObtenirListeEnseignant(departementDTO);

            if (liste == null)
                return; // ou afficher un message

            foreach (EnseignantDTO enseignantDTO in CegepControleur.Instance.ObtenirListeEnseignant(departementDTO))
            {
                lbxEnseignantsSaisie.Items.Add(enseignantDTO);
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un enseignant dans un département qui a été sélectionné dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterEnseignant_Click(object sender, EventArgs e)
        {
            DepartementDTO monDepartement = new DepartementDTO("", cbxDepartementEnseignant.Text, "");


            DepartementDTO leDepartementAChercher = CegepControleur.Instance.ObtenirDepartement(monDepartement);

            if (leDepartementAChercher != null)
            {
                CegepControleur.Instance.AjouterEnseignant(leDepartementAChercher,new EnseignantDTO(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text));

                AfficherListeEnseignantGestionEnseignant(leDepartementAChercher);
            }
            else
            {
                MessageBox.Show("Erreur dans la sélection du département.");
            }
        }

        /// <summary>
        /// Méthode qui permet d'afficher la liste des enseignants après avoir sélectionner un département dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbxDepartementEnseignant_SelectedIndexChanged(object sender, EventArgs e)
        {
            DepartementDTO monDepartement = new DepartementDTO("", cbxDepartementEnseignant.Text, "");

            DepartementDTO leDepartementACherher = CegepControleur.Instance.ObtenirDepartement(monDepartement);

            if(monDepartement != null)
            {
                AfficherListeEnseignantGestionEnseignant(monDepartement);
            }
        }


        /// <summary>
        /// Méthode qui permet de modifier un enseignant déjà dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierEnseignant_Click(object sender, EventArgs e)
        {
            // Récupère le vrai DTO du ComboBox
            DepartementDTO monDepartementDTO = (DepartementDTO)cbxDepartementEnseignant.SelectedItem;

            if (monDepartementDTO != null)
            {
                EnseignantDTO enseignantModifieDTO = new EnseignantDTO(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text, txtDateEmbauche.Text, txtDateArret.Text);

                bool modifie = CegepControleur.Instance.ModifierEnseignant(monDepartementDTO, enseignantModifieDTO);

                if (modifie)
                    AfficherListeEnseignantGestionEnseignant(monDepartementDTO);
                else
                    MessageBox.Show("Impossible de modifier l'enseignant.");
                
            }
            else
            {
                MessageBox.Show("Erreur dans la sélection du département.");
            }
        }

        /// <summary>
        /// Méthode pour supprimer un enseignant de la liste de sont département
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerEnseignant_Click(object sender, EventArgs e)
        {
            DepartementDTO leDepartementAChercher = CegepControleur.Instance.ObtenirDepartement(new DepartementDTO("", cbxDepartementEnseignant.Text, ""));


            if (leDepartementAChercher != null)
            {
                CegepControleur.Instance.SupprimerEnseignant(leDepartementAChercher,new EnseignantDTO(int.Parse(edtNoEmploye.Text), "", "", "", "", "", "", "", "", "", ""));
                MessageBox.Show("L'enseignant " + edtNoEmploye.Text + " à été supprimé !!!");
                AfficherListeEnseignantGestionEnseignant(leDepartementAChercher);
            }
            else
            {
                MessageBox.Show("Erreur dans la sélection du département.");
            }
        }
        #endregion Onglet Gestion enseignants...

        #region Onglet Gestion départements

        /// <summary>
        /// Méthode qui permet d'ajouter un département à la liste des départements du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDepartement_Click(object sender, EventArgs e)
        {

            if (CegepControleur.Instance.AjouterDepartement(new DepartementDTO(edtNoDepartement.Text, edtNomDepartement.Text, edtDescriptionDepartement.Text)))
            {
                RemplirListes();
                MessageBox.Show(edtNomDepartement.Text + "\na bien été crée.");
            }
            else
            {
                MessageBox.Show("Le département existe déjà et n'a pas été crée.");
            }
            Refresh();
        }

        /// <summary>
        /// Métode qui permet de supprimer un département de la liste des département du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerGestionDepartement_Click(object sender, EventArgs e)
        {
            DepartementDTO departementSelectionne = (DepartementDTO)lbxDepartement.SelectedItem;
            if(departementSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un département.");
                return;
            }

            if (CegepControleur.Instance.SupprimerDepartement(departementSelectionne))
            {
                RemplirListes();
                MessageBox.Show(departementSelectionne.Nom + "\na bien été enlevé.");
            }
            else
            {
                MessageBox.Show("Impossible de supprimer ce département.");
            }
            Refresh();
        }
        #endregion

        #region InfoCégep

        /// <summary>
        /// Méthode qui permet de créer un cégep avec le constructeur paramétré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterCegep_Click(object sender, EventArgs e)
        {
            CegepControleur.Instance.CreerCegep(new CegepDTO(edtNomCegep.Text, edtAdresseCegep.Text, edtVilleCegep.Text, edtProvinceCegep.Text, edtCodePostalCegep.Text, edtTelephoneCegep.Text, edtCourrielCegep.Text));
            MessageBox.Show(edtNomCegep.Text + "\n a bien été crée.");
        }

        /// <summary>
        /// Méthode qui permet de modifier les informations du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierCegep_Click(object sender, EventArgs e)
        {
            if (CegepControleur.Instance.ModifierCegep(new CegepDTO(edtNomCegep.Text, edtAdresseCegep.Text, edtVilleCegep.Text, edtProvinceCegep.Text, edtCodePostalCegep.Text, edtTelephoneCegep.Text, edtCourrielCegep.Text)))
                MessageBox.Show(edtNomCegep + "\n a bien été modifié.");
        }

        /// <summary>
        /// Méthode qui permet de suprimmer l'objet cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerCegep_Click(object sender, EventArgs e)
        {
            string nomCegep = CegepControleur.Instance.ObtenirCegep().Nom;
            if (CegepControleur.Instance.SupprimerCegep())
            {
                MessageBox.Show(nomCegep + " a bien été supprimé.");
                RemplirListes();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGestionCegep_FormClosing(object sender, FormClosingEventArgs e)
        {
            QuitterToolStripMenuItem_Click(this, null);
        }

        #endregion InfoCegep

    }
}
