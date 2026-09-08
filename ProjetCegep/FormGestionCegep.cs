using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace ProjetCegep
{
   public partial class FormGestionCegep : Form
   {
        Cegep monCegep;  //Objet Cégep qui comprend la structure complète d'un cégep...

        /// <summary>
        /// Constructeur du formulaire Gestion Cégep
        /// </summary>
        public FormGestionCegep()
        {
            InitializeComponent();
            if (File.Exists("Cegep.xml"))
            {
                XmlSerializer leFichierCegep = new XmlSerializer(typeof(Cegep));
                FileStream fichierLogique;

                fichierLogique = File.OpenRead("Cegep.xml");
                monCegep = (Cegep)leFichierCegep.Deserialize(fichierLogique);
                fichierLogique.Close();

                RemplirListes();
            }
        }

        /// <summary>
        /// Méthode qui permet d'enregistrer le cégep et les listes dans un fichier XML.  Par la suite, on quitte l'application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        /// <summary>
        /// Permet de remplir les différentes listes du formulaire 
        /// </summary>
        public void RemplirListes()
        {
             lbxDepartement.Items.Clear();
             lbxDepartementInfoCegep.Items.Clear();
             cbxDepartementEnseignant.Items.Clear();
             if (monCegep != null)
                 foreach (Departement departement in monCegep.ObtenirListeDepartement())
                 {
                    lbxDepartement.Items.Add(departement.ToString());
                    lbxDepartementInfoCegep.Items.Add(departement.ToString());
                    cbxDepartementEnseignant.Items.Add(departement.ToString());
                 }
        }

        //Onglet Gestion enseignants...

        /// <summary>
        /// Méthode qui permet de mettre à jour les différentes listes d'enseignants
        /// </summary>
        /// <param name="unDepartement">Le département qui à été sélectionné</param>
        public void AfficherListeEnseignantGestionEnseignant(Departement unDepartement)
        {
            lbxEnseignantsSaisie.Items.Clear();
            foreach (Enseignant enseignant in unDepartement.ObtenirListeEnseignant())
            {
                lbxEnseignantsSaisie.Items.Add(enseignant.NoEmploye + "  " + enseignant.Prenom + " " + enseignant.Nom);
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un enseignant dans un département qui a été sélectionné dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterEnseignant_Click(object sender, EventArgs e)
        {
            Departement monDepartement, leDepartementAChercher;

            leDepartementAChercher = new Departement("", cbxDepartementEnseignant.Text, "");

            monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            if (monDepartement != null)
            {
                monDepartement.AjouterEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text));

                AfficherListeEnseignantGestionEnseignant(monDepartement);
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
            Departement monDepartement, leDepartementAChercher;

            leDepartementAChercher = new Departement("", cbxDepartementEnseignant.Text, "");

            monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            AfficherListeEnseignantGestionEnseignant(monDepartement);
        }


        /// <summary>
        /// Méthode qui permet de modifier un enseignant déjà dans la liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierEnseignant_Click(object sender, EventArgs e)
        {
            Departement monDepartement, leDepartementAChercher;
            Enseignant unEnseignant;

            leDepartementAChercher = new Departement("", cbxDepartementEnseignant.Text, "");

            monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            if (monDepartement != null)
            {
                unEnseignant = monDepartement.ObtenirEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text));

                unEnseignant.NoEmploye = int.Parse(edtNoEmploye.Text);
                unEnseignant.Prenom = edtPrenomEnseignant.Text;
                unEnseignant.Adresse = edtAdresseEnseignant.Text;
                unEnseignant.Ville = edtVilleEnseignant.Text;
                unEnseignant.Province = EdtProvinceEnseignant.Text;
                unEnseignant.CodePostal = edtCodePostalEnseignant.Text;
                unEnseignant.Telephone = edtTelephoneEnseignant.Text;
                unEnseignant.Courriel = edtCourrielEnseignant.Text;

                AfficherListeEnseignantGestionEnseignant(monDepartement);
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
            Departement monDepartement, leDepartementAChercher;

            leDepartementAChercher = new Departement("", cbxDepartementEnseignant.Text, "");

            monDepartement = monCegep.ObtenirDepartement(leDepartementAChercher);

            if (monDepartement != null)
            {
                monDepartement.EnleverEnseignant(new Enseignant(int.Parse(edtNoEmploye.Text), edtPrenomEnseignant.Text, edtNomEnseignant.Text, edtAdresseEnseignant.Text, edtVilleEnseignant.Text, EdtProvinceEnseignant.Text, edtCodePostalEnseignant.Text, edtTelephoneEnseignant.Text, edtCourrielEnseignant.Text));
                MessageBox.Show("L'enseignant " + edtNoEmploye.Text + " à été supprimé !!!");
                AfficherListeEnseignantGestionEnseignant(monDepartement);
            }
            else
            {
                MessageBox.Show("Erreur dans la sélection du département.");
            }
        }

        //Onglet Gestion départements

        /// <summary>
        /// Méthode qui permet d'ajouter un départemetn à la liste des départements du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterDepartement_Click(object sender, EventArgs e)
        {
            Departement unDepartement;

            unDepartement = new Departement(edtNoDepartement.Text, edtNomDepartement.Text, edtDescriptionDepartement.Text);

            if (monCegep.AjouterDepartement(unDepartement))
            {
                RemplirListes();
                MessageBox.Show(unDepartement.ToString() + "\na bien été crée.");
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
            Departement unDepartement;

            unDepartement = new Departement(edtNoDepartement.Text, edtNomDepartement.Text, edtDescriptionDepartement.Text);

            if (monCegep.EnleverDepartement(unDepartement))
            {
                RemplirListes();
                MessageBox.Show(unDepartement.ToString() + "\na bien été enlevé.");
            }
            else
            {
                MessageBox.Show("Le département entré n'est pas dans la liste et n'a pas pu être enlevé.");
            }
            Refresh();
        }

        //Onglet Info Cégep

        /// <summary>
        /// Méthode qui permet de créer un cégep avec le constructeur paramétré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjouterCegep_Click(object sender, EventArgs e)
        {
            monCegep = new Cegep(edtNomCegep.Text, edtAdresseCegep.Text, edtVilleCegep.Text, edtProvinceCegep.Text, edtCodePostalCegep.Text, edtTelephoneCegep.Text, edtCourrielCegep.Text);
            MessageBox.Show(monCegep.ToString() + "\n a bien été crée.");
        }

        /// <summary>
        /// Méthode qui permet de modifier les informations du cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifierCegep_Click(object sender, EventArgs e)
        {
            monCegep.Nom = edtNomCegep.Text;
            monCegep.Adresse = edtAdresseCegep.Text;
            monCegep.Ville = edtVilleCegep.Text;
            monCegep.Province = edtProvinceCegep.Text;
            monCegep.CodePostal = edtCodePostalCegep.Text;
            monCegep.Telephone = edtTelephoneCegep.Text;
            monCegep.Courriel = edtCourrielCegep.Text;

            MessageBox.Show(monCegep.ToString() + "\na bien été modifié.");
        }

        /// <summary>
        /// Méthode qui permet de suprimmer l'objet cégep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSupprimerCegep_Click(object sender, EventArgs e)
        {
            string nomCegep;
            nomCegep = monCegep.Nom;

            monCegep = null;
            MessageBox.Show(nomCegep + " a bien été supprimé.");
            RemplirListes();
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
    }
}
