using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum Operation
{
    Aucune = 0,
    Modif = 1,
    Ajout = 2
}

namespace StagesTool.Forms
{
    public partial class FrmEntreprise : Form
    {
        //Globales
        int ligneCourante;
        Operation action = Operation.Aucune;
        private EventHandler dgEntreprise_SelectionChanged;

        public FrmEntreprise()
        {
            InitializeComponent();
        }

        private void dgEntreprise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
        private void RemplirEcran()
        {
            DS.EntrepriseRow ligne;
            ligne = (DS.EntrepriseRow)ds1.Entreprise.Rows[ligneCourante];
            txtNom.Text = ligne.Nom;
            mskTelephone.Text = ligne.Telephone;
            txtEmail.Text = ligne.Email;
            txtAdresse.Text = ligne.Adresse;
            txtVille.Text = ligne.Ville;
            mskCP.Text = ligne.CodePostal;
            if(ligne.Actif == true)
            {
                cboActif.SelectedIndex = 0;
            }
            else
            {
                cboActif.SelectedIndex = 1;
            }
            
            txtEmplacement.Text = "Entreprise" + " " + (ligneCourante + 1) + " " + "de" + " " + ds1.Entreprise.Rows.Count;
        }

        private void ViderEcran()
        {
            foreach(Control c in this.grEntreprise.Controls)
            {
                if(c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            cboActif.SelectedIndex = 0;
        }

        private void EnleverEntreprise()
        {
            try
            {
                // Retirer l'entreprise 
                ds1.Entreprise.Rows[ligneCourante].Delete();
                // Updater la bd
                daEntreprise.Update(ds1.Entreprise);
                //Feedback
                MessageBox.Show("Entreprise retiré avec succès..");
                if(ds1.Entreprise.Rows.Count > 0)
                {
                    ligneCourante = 0;
                    RemplirEcran();
                }
                else
                {
                    ligneCourante = -1;
                    ViderEcran();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public bool ValiderFormulaire()
        {
            Boolean ok = true;
            erp.Clear();

            if(txtNom.Text.Trim() == "")
            {
                ok = false;
                erp.SetError(txtNom, "Nom obligatoire..");
            }
            if (mskTelephone.MaskFull == false)
            {
                ok = false;
                erp.SetError(mskTelephone, "Téléphone invalide..");
            }           
            if (txtEmail.Text.Trim() == "")
            {
                ok = false;
                erp.SetError(txtEmail, "Courriel obligatoire..");
            }
            if (txtAdresse.Text.Trim() == "")
            {
                ok = false;
                erp.SetError(txtAdresse, "Adresse obligatoire..");
            }
            if (txtVille.Text.Trim() == "")
            {
                ok = false;
                erp.SetError(txtVille, "Ville obligatoire..");
            }
            if (mskCP.MaskFull == false)
            {
                ok = false;
                erp.SetError(mskCP, "Code postal invalide..");
            }
            if(cboActif.SelectedIndex == -1)
            {
                ok = false;
                erp.SetError(cboActif, "Entrez si l'entreprise est active ou nom..");
            }
            return ok;
        }

        private void AjouterEntreprise()
        {
            try
            {
                DS.EntrepriseRow ligne;
                ligne = ds1.Entreprise.NewEntrepriseRow();
                // Assignation des valeurs dans la ligne
                ligne.Nom = txtNom.Text.Trim();
                ligne.Telephone = mskTelephone.Text;
                ligne.Email = txtEmail.Text.Trim();
                ligne.Adresse = txtAdresse.Text.Trim();
                ligne.Ville = txtVille.Text.Trim();
                ligne.CodePostal = mskCP.Text;
                if (cboActif.SelectedIndex == 0)
                {
                    ligne.Actif = true;
                }
                else
                {
                    ligne.Actif = false;
                }
                // Ajout de la nouvelle ligne
                ds1.Entreprise.Rows.Add(ligne);
                // Ajout de l'entreprise à la bd
                daEntreprise.Update(ds1.Entreprise);
                // Feedback 
                MessageBox.Show("Entrprise ajouté avec succès..");
                ligneCourante = ds1.Entreprise.Rows.Count - 1;
                bAnnuler.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ModifierEntreprise()
        {
            try
            {
                DS.EntrepriseRow ligne;
                ligne = (DS.EntrepriseRow)ds1.Entreprise.Rows[ligneCourante];
                // Assignation des valeurs dans la ligne
                ligne.Nom = txtNom.Text.Trim();
                ligne.Telephone = mskTelephone.Text;
                ligne.Email = txtEmail.Text.Trim();
                ligne.Adresse = txtAdresse.Text.Trim();
                ligne.Ville = txtVille.Text.Trim();
                ligne.CodePostal = mskCP.Text;
                if (cboActif.SelectedIndex == 0)
                {
                    ligne.Actif = true;
                }
                else
                {
                    ligne.Actif = false;
                }
                // Ajout de la nouvelle ligne
                ds1.Entreprise.Rows.Add(ligne);
                // Ajout de l'entreprise à la bd
                daEntreprise.Update(ds1.Entreprise);
                // Feedback 
                MessageBox.Show("Entrprise ajouté avec succès..");
                ligneCourante = ds1.Entreprise.Rows.Count - 1;
                bAnnuler.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmEntreprise_Load(object sender, EventArgs e)
        {
            try
            {
                daEntreprise.Fill(ds1.Entreprise);
                //Validation
                if(ds1.Entreprise.Rows.Count > 0)
                {
                    ligneCourante = 0;
                    RemplirEcran();
                }
                else
                {
                    ligneCourante = -1;
                }
                dgEntreprise.SelectionChanged += dgEntreprise_SelectionChanged;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Tag)
            {
                case "premier":
                    ligneCourante = 0;
                    break;
                case "precedent":
                    if (ligneCourante > 0)
                    {
                        ligneCourante -= 1;
                    }
                    break;
                case "suivant":
                    if (ligneCourante < ds1.Entreprise.Rows.Count - 1)
                    {
                        ligneCourante += 1;
                    }
                    break;
                case "dernier":
                    ligneCourante = ds1.Entreprise.Rows.Count - 1;
                    break;

            }
            RemplirEcran();
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            grEntreprise.Enabled = true;
            // Masquer les controles
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            // Rendre les controle visible
            bConfirmer.Visible = true; bAnnuler.Visible = true;
            // Vide le formulaire
            ViderEcran();
            txtEmplacement.Text = "*** Mode Ajout ***";

            action = Operation.Ajout;
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            grEntreprise.Enabled = true;
            // Masquer les controles
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            // Rendre les controle visible
            bConfirmer.Visible = true; bAnnuler.Visible = true;
            txtNom.Focus();
            txtEmplacement.Text = "*** Mode Modif ***";

            action = Operation.Modif;
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            grEntreprise.Enabled = false;
            // Masquer les controles
            bConfirmer.Visible = false; bAnnuler.Visible = false;
            // Rendre les controle visible
            bNouveau.Visible = true; bModifier.Visible = true; bRetirer.Visible = true;
            if(ligneCourante > -1) { 
                RemplirEcran();
            }
            else
            {
                ViderEcran();
            }
            action = Operation.Aucune;
            erp.Clear();
        }

        private void bRetirer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-vous retirer cette entreprise?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EnleverEntreprise();
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            if(!ValiderFormulaire()) 
            {
                return;
            }
            if(action == Operation.Ajout)
            {
                AjouterEntreprise();
            }
            else
            {
                ModifierEntreprise();
            }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back) return;
            if(!char.IsLetter(e.KeyChar) )
            {
                e.KeyChar = '\0';
            }
        }

        private void dgEntreprise_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgEntreprise.SelectedRows.Count > 0)
                {
                    ligneCourante = dgEntreprise.CurrentRow.Index;
                    RemplirEcran();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dgEntreprise_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ligneCourante = dgEntreprise.CurrentRow.Index;
            RemplirEcran();
        }
    }
}
