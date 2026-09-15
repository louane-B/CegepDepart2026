
namespace ProjetCegep
{
   partial class FormGestionCegep
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageInfoCegep = new System.Windows.Forms.TabPage();
            this.btnModifierCegep = new System.Windows.Forms.Button();
            this.btnSupprimerCegep = new System.Windows.Forms.Button();
            this.btnAjouterCegep = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.lbxDepartementInfoCegep = new System.Windows.Forms.ListBox();
            this.edtCourrielCegep = new System.Windows.Forms.TextBox();
            this.edtTelephoneCegep = new System.Windows.Forms.TextBox();
            this.edtCodePostalCegep = new System.Windows.Forms.TextBox();
            this.edtProvinceCegep = new System.Windows.Forms.TextBox();
            this.edtVilleCegep = new System.Windows.Forms.TextBox();
            this.edtAdresseCegep = new System.Windows.Forms.TextBox();
            this.edtNomCegep = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.tabGestionCegepDepartement = new System.Windows.Forms.TabPage();
            this.btnSupprimerGestionDepartement = new System.Windows.Forms.Button();
            this.btnAjouterDepartement = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.lbxDepartement = new System.Windows.Forms.ListBox();
            this.edtDescriptionDepartement = new System.Windows.Forms.TextBox();
            this.edtNomDepartement = new System.Windows.Forms.TextBox();
            this.edtNoDepartement = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tabGestionEnseignant = new System.Windows.Forms.TabPage();
            this.btnModifierEnseignant = new System.Windows.Forms.Button();
            this.cbxDepartementEnseignant = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btnSupprimerEnseignant = new System.Windows.Forms.Button();
            this.btnAjouterEnseignant = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbxEnseignantsSaisie = new System.Windows.Forms.ListBox();
            this.edtCourrielEnseignant = new System.Windows.Forms.TextBox();
            this.edtTelephoneEnseignant = new System.Windows.Forms.TextBox();
            this.edtCodePostalEnseignant = new System.Windows.Forms.TextBox();
            this.EdtProvinceEnseignant = new System.Windows.Forms.TextBox();
            this.edtVilleEnseignant = new System.Windows.Forms.TextBox();
            this.edtAdresseEnseignant = new System.Windows.Forms.TextBox();
            this.edtNomEnseignant = new System.Windows.Forms.TextBox();
            this.edtPrenomEnseignant = new System.Windows.Forms.TextBox();
            this.edtNoEmploye = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabGestionCegep = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPageInfoCegep.SuspendLayout();
            this.tabGestionCegepDepartement.SuspendLayout();
            this.tabGestionEnseignant.SuspendLayout();
            this.tabGestionCegep.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1169, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // tabPageInfoCegep
            // 
            this.tabPageInfoCegep.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPageInfoCegep.Controls.Add(this.btnModifierCegep);
            this.tabPageInfoCegep.Controls.Add(this.btnSupprimerCegep);
            this.tabPageInfoCegep.Controls.Add(this.btnAjouterCegep);
            this.tabPageInfoCegep.Controls.Add(this.label50);
            this.tabPageInfoCegep.Controls.Add(this.lbxDepartementInfoCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtCourrielCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtTelephoneCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtCodePostalCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtProvinceCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtVilleCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtAdresseCegep);
            this.tabPageInfoCegep.Controls.Add(this.edtNomCegep);
            this.tabPageInfoCegep.Controls.Add(this.label53);
            this.tabPageInfoCegep.Controls.Add(this.label54);
            this.tabPageInfoCegep.Controls.Add(this.label55);
            this.tabPageInfoCegep.Controls.Add(this.label56);
            this.tabPageInfoCegep.Controls.Add(this.label57);
            this.tabPageInfoCegep.Controls.Add(this.label58);
            this.tabPageInfoCegep.Controls.Add(this.label59);
            this.tabPageInfoCegep.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfoCegep.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageInfoCegep.Name = "tabPageInfoCegep";
            this.tabPageInfoCegep.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageInfoCegep.Size = new System.Drawing.Size(1075, 611);
            this.tabPageInfoCegep.TabIndex = 5;
            this.tabPageInfoCegep.Text = "Info Cégep";
            // 
            // btnModifierCegep
            // 
            this.btnModifierCegep.Location = new System.Drawing.Point(181, 528);
            this.btnModifierCegep.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierCegep.Name = "btnModifierCegep";
            this.btnModifierCegep.Size = new System.Drawing.Size(100, 28);
            this.btnModifierCegep.TabIndex = 90;
            this.btnModifierCegep.Text = "Modifier";
            this.btnModifierCegep.UseVisualStyleBackColor = true;
            this.btnModifierCegep.Click += new System.EventHandler(this.BtnModifierCegep_Click);
            // 
            // btnSupprimerCegep
            // 
            this.btnSupprimerCegep.Location = new System.Drawing.Point(311, 528);
            this.btnSupprimerCegep.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerCegep.Name = "btnSupprimerCegep";
            this.btnSupprimerCegep.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimerCegep.TabIndex = 87;
            this.btnSupprimerCegep.Text = "Supprimer";
            this.btnSupprimerCegep.UseVisualStyleBackColor = true;
            this.btnSupprimerCegep.Click += new System.EventHandler(this.BtnSupprimerCegep_Click);
            // 
            // btnAjouterCegep
            // 
            this.btnAjouterCegep.Location = new System.Drawing.Point(57, 528);
            this.btnAjouterCegep.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterCegep.Name = "btnAjouterCegep";
            this.btnAjouterCegep.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterCegep.TabIndex = 86;
            this.btnAjouterCegep.Text = "Ajouter";
            this.btnAjouterCegep.UseVisualStyleBackColor = true;
            this.btnAjouterCegep.Click += new System.EventHandler(this.BtnAjouterCegep_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(675, 52);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(120, 16);
            this.label50.TabIndex = 85;
            this.label50.Text = "Liste département :";
            // 
            // lbxDepartementInfoCegep
            // 
            this.lbxDepartementInfoCegep.FormattingEnabled = true;
            this.lbxDepartementInfoCegep.ItemHeight = 16;
            this.lbxDepartementInfoCegep.Location = new System.Drawing.Point(679, 71);
            this.lbxDepartementInfoCegep.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDepartementInfoCegep.Name = "lbxDepartementInfoCegep";
            this.lbxDepartementInfoCegep.Size = new System.Drawing.Size(328, 484);
            this.lbxDepartementInfoCegep.Sorted = true;
            this.lbxDepartementInfoCegep.TabIndex = 84;
            // 
            // edtCourrielCegep
            // 
            this.edtCourrielCegep.Location = new System.Drawing.Point(356, 133);
            this.edtCourrielCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtCourrielCegep.Name = "edtCourrielCegep";
            this.edtCourrielCegep.Size = new System.Drawing.Size(200, 22);
            this.edtCourrielCegep.TabIndex = 80;
            this.edtCourrielCegep.Text = "info@cegeprdl.ca";
            // 
            // edtTelephoneCegep
            // 
            this.edtTelephoneCegep.Location = new System.Drawing.Point(356, 71);
            this.edtTelephoneCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtTelephoneCegep.Name = "edtTelephoneCegep";
            this.edtTelephoneCegep.Size = new System.Drawing.Size(132, 22);
            this.edtTelephoneCegep.TabIndex = 79;
            this.edtTelephoneCegep.Text = "418-862-6903";
            // 
            // edtCodePostalCegep
            // 
            this.edtCodePostalCegep.Location = new System.Drawing.Point(57, 330);
            this.edtCodePostalCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtCodePostalCegep.Name = "edtCodePostalCegep";
            this.edtCodePostalCegep.Size = new System.Drawing.Size(132, 22);
            this.edtCodePostalCegep.TabIndex = 78;
            this.edtCodePostalCegep.Text = "G5R 5E7";
            // 
            // edtProvinceCegep
            // 
            this.edtProvinceCegep.Location = new System.Drawing.Point(57, 267);
            this.edtProvinceCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtProvinceCegep.Name = "edtProvinceCegep";
            this.edtProvinceCegep.Size = new System.Drawing.Size(200, 22);
            this.edtProvinceCegep.TabIndex = 77;
            this.edtProvinceCegep.Text = "Québec";
            // 
            // edtVilleCegep
            // 
            this.edtVilleCegep.Location = new System.Drawing.Point(57, 201);
            this.edtVilleCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtVilleCegep.Name = "edtVilleCegep";
            this.edtVilleCegep.Size = new System.Drawing.Size(200, 22);
            this.edtVilleCegep.TabIndex = 76;
            this.edtVilleCegep.Text = "Rivière-du-Loup";
            // 
            // edtAdresseCegep
            // 
            this.edtAdresseCegep.Location = new System.Drawing.Point(57, 134);
            this.edtAdresseCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtAdresseCegep.Name = "edtAdresseCegep";
            this.edtAdresseCegep.Size = new System.Drawing.Size(200, 22);
            this.edtAdresseCegep.TabIndex = 75;
            this.edtAdresseCegep.Text = "80 Frontenac";
            // 
            // edtNomCegep
            // 
            this.edtNomCegep.Location = new System.Drawing.Point(57, 71);
            this.edtNomCegep.Margin = new System.Windows.Forms.Padding(4);
            this.edtNomCegep.Name = "edtNomCegep";
            this.edtNomCegep.Size = new System.Drawing.Size(200, 22);
            this.edtNomCegep.TabIndex = 74;
            this.edtNomCegep.Text = "Cégep Rivière-du-Loup";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(352, 113);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 16);
            this.label53.TabIndex = 69;
            this.label53.Text = "Courriel :";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(352, 52);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(79, 16);
            this.label54.TabIndex = 68;
            this.label54.Text = "Téléphone :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(53, 310);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(86, 16);
            this.label55.TabIndex = 67;
            this.label55.Text = "Code postal :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(53, 247);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(66, 16);
            this.label56.TabIndex = 66;
            this.label56.Text = "Province :";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(53, 183);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(39, 16);
            this.label57.TabIndex = 65;
            this.label57.Text = "Ville :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(53, 114);
            this.label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(67, 16);
            this.label58.TabIndex = 64;
            this.label58.Text = "Adresse : ";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(53, 52);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(45, 16);
            this.label59.TabIndex = 63;
            this.label59.Text = "Nom : ";
            // 
            // tabGestionCegepDepartement
            // 
            this.tabGestionCegepDepartement.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabGestionCegepDepartement.Controls.Add(this.btnSupprimerGestionDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.btnAjouterDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.label26);
            this.tabGestionCegepDepartement.Controls.Add(this.lbxDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.edtDescriptionDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.edtNomDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.edtNoDepartement);
            this.tabGestionCegepDepartement.Controls.Add(this.label34);
            this.tabGestionCegepDepartement.Controls.Add(this.label35);
            this.tabGestionCegepDepartement.Controls.Add(this.label36);
            this.tabGestionCegepDepartement.Location = new System.Drawing.Point(4, 25);
            this.tabGestionCegepDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.tabGestionCegepDepartement.Name = "tabGestionCegepDepartement";
            this.tabGestionCegepDepartement.Padding = new System.Windows.Forms.Padding(4);
            this.tabGestionCegepDepartement.Size = new System.Drawing.Size(1075, 611);
            this.tabGestionCegepDepartement.TabIndex = 2;
            this.tabGestionCegepDepartement.Text = "Gestion départements";
            // 
            // btnSupprimerGestionDepartement
            // 
            this.btnSupprimerGestionDepartement.Location = new System.Drawing.Point(189, 517);
            this.btnSupprimerGestionDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerGestionDepartement.Name = "btnSupprimerGestionDepartement";
            this.btnSupprimerGestionDepartement.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimerGestionDepartement.TabIndex = 79;
            this.btnSupprimerGestionDepartement.Text = "Supprimer";
            this.btnSupprimerGestionDepartement.UseVisualStyleBackColor = true;
            this.btnSupprimerGestionDepartement.Click += new System.EventHandler(this.BtnSupprimerGestionDepartement_Click);
            // 
            // btnAjouterDepartement
            // 
            this.btnAjouterDepartement.Location = new System.Drawing.Point(69, 517);
            this.btnAjouterDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterDepartement.Name = "btnAjouterDepartement";
            this.btnAjouterDepartement.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterDepartement.TabIndex = 78;
            this.btnAjouterDepartement.Text = "Ajouter";
            this.btnAjouterDepartement.UseVisualStyleBackColor = true;
            this.btnAjouterDepartement.Click += new System.EventHandler(this.BtnAjouterDepartement_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(384, 52);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(127, 16);
            this.label26.TabIndex = 77;
            this.label26.Text = "Liste départements :";
            // 
            // lbxDepartement
            // 
            this.lbxDepartement.FormattingEnabled = true;
            this.lbxDepartement.ItemHeight = 16;
            this.lbxDepartement.Location = new System.Drawing.Point(388, 71);
            this.lbxDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.lbxDepartement.Name = "lbxDepartement";
            this.lbxDepartement.Size = new System.Drawing.Size(257, 484);
            this.lbxDepartement.TabIndex = 76;
            // 
            // edtDescriptionDepartement
            // 
            this.edtDescriptionDepartement.Location = new System.Drawing.Point(69, 197);
            this.edtDescriptionDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.edtDescriptionDepartement.Name = "edtDescriptionDepartement";
            this.edtDescriptionDepartement.Size = new System.Drawing.Size(297, 22);
            this.edtDescriptionDepartement.TabIndex = 68;
            this.edtDescriptionDepartement.Text = "Informatique de gestion.  ";
            // 
            // edtNomDepartement
            // 
            this.edtNomDepartement.Location = new System.Drawing.Point(69, 135);
            this.edtNomDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.edtNomDepartement.Name = "edtNomDepartement";
            this.edtNomDepartement.Size = new System.Drawing.Size(200, 22);
            this.edtNomDepartement.TabIndex = 67;
            this.edtNomDepartement.Text = "Techniques de l\'informatique";
            // 
            // edtNoDepartement
            // 
            this.edtNoDepartement.Location = new System.Drawing.Point(69, 71);
            this.edtNoDepartement.Margin = new System.Windows.Forms.Padding(4);
            this.edtNoDepartement.Name = "edtNoDepartement";
            this.edtNoDepartement.Size = new System.Drawing.Size(132, 22);
            this.edtNoDepartement.TabIndex = 66;
            this.edtNoDepartement.Text = "420-RL";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(65, 177);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 16);
            this.label34.TabIndex = 58;
            this.label34.Text = "Description : ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(65, 116);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 16);
            this.label35.TabIndex = 57;
            this.label35.Text = "Nom :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(65, 52);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(110, 16);
            this.label36.TabIndex = 56;
            this.label36.Text = "No département :";
            // 
            // tabGestionEnseignant
            // 
            this.tabGestionEnseignant.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabGestionEnseignant.Controls.Add(this.btnModifierEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.cbxDepartementEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.label37);
            this.tabGestionEnseignant.Controls.Add(this.btnSupprimerEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.btnAjouterEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.label13);
            this.tabGestionEnseignant.Controls.Add(this.lbxEnseignantsSaisie);
            this.tabGestionEnseignant.Controls.Add(this.edtCourrielEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtTelephoneEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtCodePostalEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.EdtProvinceEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtVilleEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtAdresseEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtNomEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtPrenomEnseignant);
            this.tabGestionEnseignant.Controls.Add(this.edtNoEmploye);
            this.tabGestionEnseignant.Controls.Add(this.label16);
            this.tabGestionEnseignant.Controls.Add(this.label17);
            this.tabGestionEnseignant.Controls.Add(this.label18);
            this.tabGestionEnseignant.Controls.Add(this.label19);
            this.tabGestionEnseignant.Controls.Add(this.label20);
            this.tabGestionEnseignant.Controls.Add(this.label21);
            this.tabGestionEnseignant.Controls.Add(this.label22);
            this.tabGestionEnseignant.Controls.Add(this.label23);
            this.tabGestionEnseignant.Controls.Add(this.label24);
            this.tabGestionEnseignant.Location = new System.Drawing.Point(4, 25);
            this.tabGestionEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.tabGestionEnseignant.Name = "tabGestionEnseignant";
            this.tabGestionEnseignant.Padding = new System.Windows.Forms.Padding(4);
            this.tabGestionEnseignant.Size = new System.Drawing.Size(1075, 611);
            this.tabGestionEnseignant.TabIndex = 1;
            this.tabGestionEnseignant.Text = "Gestion enseignants";
            // 
            // btnModifierEnseignant
            // 
            this.btnModifierEnseignant.Location = new System.Drawing.Point(191, 387);
            this.btnModifierEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierEnseignant.Name = "btnModifierEnseignant";
            this.btnModifierEnseignant.Size = new System.Drawing.Size(100, 28);
            this.btnModifierEnseignant.TabIndex = 61;
            this.btnModifierEnseignant.Text = "Modifier";
            this.btnModifierEnseignant.UseVisualStyleBackColor = true;
            this.btnModifierEnseignant.Click += new System.EventHandler(this.BtnModifierEnseignant_Click);
            // 
            // cbxDepartementEnseignant
            // 
            this.cbxDepartementEnseignant.FormattingEnabled = true;
            this.cbxDepartementEnseignant.Location = new System.Drawing.Point(164, 21);
            this.cbxDepartementEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDepartementEnseignant.Name = "cbxDepartementEnseignant";
            this.cbxDepartementEnseignant.Size = new System.Drawing.Size(265, 24);
            this.cbxDepartementEnseignant.TabIndex = 51;
            this.cbxDepartementEnseignant.SelectedIndexChanged += new System.EventHandler(this.CbxDepartementEnseignant_SelectedIndexChanged);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(65, 24);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(91, 16);
            this.label37.TabIndex = 56;
            this.label37.Text = "Département :";
            // 
            // btnSupprimerEnseignant
            // 
            this.btnSupprimerEnseignant.Location = new System.Drawing.Point(311, 387);
            this.btnSupprimerEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerEnseignant.Name = "btnSupprimerEnseignant";
            this.btnSupprimerEnseignant.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimerEnseignant.TabIndex = 53;
            this.btnSupprimerEnseignant.Text = "Supprimer";
            this.btnSupprimerEnseignant.UseVisualStyleBackColor = true;
            this.btnSupprimerEnseignant.Click += new System.EventHandler(this.BtnSupprimerEnseignant_Click);
            // 
            // btnAjouterEnseignant
            // 
            this.btnAjouterEnseignant.Location = new System.Drawing.Point(68, 387);
            this.btnAjouterEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterEnseignant.Name = "btnAjouterEnseignant";
            this.btnAjouterEnseignant.Size = new System.Drawing.Size(100, 28);
            this.btnAjouterEnseignant.TabIndex = 52;
            this.btnAjouterEnseignant.Text = "Ajouter";
            this.btnAjouterEnseignant.UseVisualStyleBackColor = true;
            this.btnAjouterEnseignant.Click += new System.EventHandler(this.BtnAjouterEnseignant_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(675, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "Liste enseignants :";
            // 
            // lbxEnseignantsSaisie
            // 
            this.lbxEnseignantsSaisie.FormattingEnabled = true;
            this.lbxEnseignantsSaisie.ItemHeight = 16;
            this.lbxEnseignantsSaisie.Location = new System.Drawing.Point(679, 71);
            this.lbxEnseignantsSaisie.Margin = new System.Windows.Forms.Padding(4);
            this.lbxEnseignantsSaisie.Name = "lbxEnseignantsSaisie";
            this.lbxEnseignantsSaisie.Size = new System.Drawing.Size(328, 484);
            this.lbxEnseignantsSaisie.Sorted = true;
            this.lbxEnseignantsSaisie.TabIndex = 50;
            // 
            // edtCourrielEnseignant
            // 
            this.edtCourrielEnseignant.Location = new System.Drawing.Point(356, 133);
            this.edtCourrielEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtCourrielEnseignant.Name = "edtCourrielEnseignant";
            this.edtCourrielEnseignant.Size = new System.Drawing.Size(200, 22);
            this.edtCourrielEnseignant.TabIndex = 46;
            this.edtCourrielEnseignant.Text = "denmor@gmail.com";
            // 
            // edtTelephoneEnseignant
            // 
            this.edtTelephoneEnseignant.Location = new System.Drawing.Point(356, 71);
            this.edtTelephoneEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtTelephoneEnseignant.Name = "edtTelephoneEnseignant";
            this.edtTelephoneEnseignant.Size = new System.Drawing.Size(132, 22);
            this.edtTelephoneEnseignant.TabIndex = 45;
            this.edtTelephoneEnseignant.Text = "418-868-9922";
            // 
            // edtCodePostalEnseignant
            // 
            this.edtCodePostalEnseignant.Location = new System.Drawing.Point(357, 323);
            this.edtCodePostalEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtCodePostalEnseignant.Name = "edtCodePostalEnseignant";
            this.edtCodePostalEnseignant.Size = new System.Drawing.Size(132, 22);
            this.edtCodePostalEnseignant.TabIndex = 44;
            this.edtCodePostalEnseignant.Text = "G5R 5E7";
            // 
            // EdtProvinceEnseignant
            // 
            this.EdtProvinceEnseignant.Location = new System.Drawing.Point(357, 261);
            this.EdtProvinceEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.EdtProvinceEnseignant.Name = "EdtProvinceEnseignant";
            this.EdtProvinceEnseignant.Size = new System.Drawing.Size(200, 22);
            this.EdtProvinceEnseignant.TabIndex = 43;
            this.EdtProvinceEnseignant.Text = "Québec";
            // 
            // edtVilleEnseignant
            // 
            this.edtVilleEnseignant.Location = new System.Drawing.Point(357, 194);
            this.edtVilleEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtVilleEnseignant.Name = "edtVilleEnseignant";
            this.edtVilleEnseignant.Size = new System.Drawing.Size(200, 22);
            this.edtVilleEnseignant.TabIndex = 42;
            this.edtVilleEnseignant.Text = "Rivière-du-Loup";
            // 
            // edtAdresseEnseignant
            // 
            this.edtAdresseEnseignant.Location = new System.Drawing.Point(69, 260);
            this.edtAdresseEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtAdresseEnseignant.Name = "edtAdresseEnseignant";
            this.edtAdresseEnseignant.Size = new System.Drawing.Size(200, 22);
            this.edtAdresseEnseignant.TabIndex = 41;
            this.edtAdresseEnseignant.Text = "127, Lafontaine";
            // 
            // edtNomEnseignant
            // 
            this.edtNomEnseignant.Location = new System.Drawing.Point(69, 197);
            this.edtNomEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtNomEnseignant.Name = "edtNomEnseignant";
            this.edtNomEnseignant.Size = new System.Drawing.Size(200, 22);
            this.edtNomEnseignant.TabIndex = 40;
            this.edtNomEnseignant.Text = "Morissette";
            // 
            // edtPrenomEnseignant
            // 
            this.edtPrenomEnseignant.Location = new System.Drawing.Point(69, 135);
            this.edtPrenomEnseignant.Margin = new System.Windows.Forms.Padding(4);
            this.edtPrenomEnseignant.Name = "edtPrenomEnseignant";
            this.edtPrenomEnseignant.Size = new System.Drawing.Size(200, 22);
            this.edtPrenomEnseignant.TabIndex = 39;
            this.edtPrenomEnseignant.Text = "Denis";
            // 
            // edtNoEmploye
            // 
            this.edtNoEmploye.Location = new System.Drawing.Point(69, 71);
            this.edtNoEmploye.Margin = new System.Windows.Forms.Padding(4);
            this.edtNoEmploye.Name = "edtNoEmploye";
            this.edtNoEmploye.Size = new System.Drawing.Size(132, 22);
            this.edtNoEmploye.TabIndex = 38;
            this.edtNoEmploye.Text = "1122";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(352, 113);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Courriel :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(352, 52);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Téléphone :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(353, 304);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 16);
            this.label18.TabIndex = 33;
            this.label18.Text = "Code postal :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(353, 241);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "Province :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(353, 177);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 16);
            this.label20.TabIndex = 31;
            this.label20.Text = "Ville :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(65, 240);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 16);
            this.label21.TabIndex = 30;
            this.label21.Text = "Adresse : ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(65, 177);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 29;
            this.label22.Text = "Nom : ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(65, 116);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 16);
            this.label23.TabIndex = 28;
            this.label23.Text = "Prénom :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(65, 52);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 16);
            this.label24.TabIndex = 27;
            this.label24.Text = "No employé :";
            // 
            // tabGestionCegep
            // 
            this.tabGestionCegep.Controls.Add(this.tabPageInfoCegep);
            this.tabGestionCegep.Controls.Add(this.tabGestionCegepDepartement);
            this.tabGestionCegep.Controls.Add(this.tabGestionEnseignant);
            this.tabGestionCegep.Location = new System.Drawing.Point(36, 73);
            this.tabGestionCegep.Margin = new System.Windows.Forms.Padding(4);
            this.tabGestionCegep.Name = "tabGestionCegep";
            this.tabGestionCegep.SelectedIndex = 0;
            this.tabGestionCegep.Size = new System.Drawing.Size(1083, 640);
            this.tabGestionCegep.TabIndex = 1;
            // 
            // FormGestionCegep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 745);
            this.Controls.Add(this.tabGestionCegep);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionCegep";
            this.Text = "Gestion Cégep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionCegep_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageInfoCegep.ResumeLayout(false);
            this.tabPageInfoCegep.PerformLayout();
            this.tabGestionCegepDepartement.ResumeLayout(false);
            this.tabGestionCegepDepartement.PerformLayout();
            this.tabGestionEnseignant.ResumeLayout(false);
            this.tabGestionEnseignant.PerformLayout();
            this.tabGestionCegep.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageInfoCegep;
        private System.Windows.Forms.Button btnModifierCegep;
        private System.Windows.Forms.Button btnSupprimerCegep;
        private System.Windows.Forms.Button btnAjouterCegep;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ListBox lbxDepartementInfoCegep;
        private System.Windows.Forms.TextBox edtCourrielCegep;
        private System.Windows.Forms.TextBox edtTelephoneCegep;
        private System.Windows.Forms.TextBox edtCodePostalCegep;
        private System.Windows.Forms.TextBox edtProvinceCegep;
        private System.Windows.Forms.TextBox edtVilleCegep;
        private System.Windows.Forms.TextBox edtAdresseCegep;
        private System.Windows.Forms.TextBox edtNomCegep;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TabPage tabGestionCegepDepartement;
        private System.Windows.Forms.Button btnSupprimerGestionDepartement;
        private System.Windows.Forms.Button btnAjouterDepartement;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListBox lbxDepartement;
        private System.Windows.Forms.TextBox edtDescriptionDepartement;
        private System.Windows.Forms.TextBox edtNomDepartement;
        private System.Windows.Forms.TextBox edtNoDepartement;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage tabGestionEnseignant;
        private System.Windows.Forms.Button btnModifierEnseignant;
        private System.Windows.Forms.ComboBox cbxDepartementEnseignant;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnSupprimerEnseignant;
        private System.Windows.Forms.Button btnAjouterEnseignant;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbxEnseignantsSaisie;
        private System.Windows.Forms.TextBox edtCourrielEnseignant;
        private System.Windows.Forms.TextBox edtTelephoneEnseignant;
        private System.Windows.Forms.TextBox edtCodePostalEnseignant;
        private System.Windows.Forms.TextBox EdtProvinceEnseignant;
        private System.Windows.Forms.TextBox edtVilleEnseignant;
        private System.Windows.Forms.TextBox edtAdresseEnseignant;
        private System.Windows.Forms.TextBox edtNomEnseignant;
        private System.Windows.Forms.TextBox edtPrenomEnseignant;
        private System.Windows.Forms.TextBox edtNoEmploye;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabControl tabGestionCegep;
    }
}

