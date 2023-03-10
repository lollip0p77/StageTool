using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagesTool.Forms
{
    public partial class FrmRetour : Form
    {
        // Globale
        Action operation;
        private EventHandler dgDemande_SelectionChanged;

        public FrmRetour()
        {
            InitializeComponent();
        }

        private void FrmRetour_Load(object sender, EventArgs e)
        {
            try
            {
                //Remplir les table du dataset
                daDemande.Fill(dsRetours1.Demande);
                daRetours.Fill(dsRetours1.Retours);
                
                // Verifier s'il a des demandes

                txtEmplacement.Text = "Retours" + " " + (BSRetours.Position + 1) + " " + "de" + " " + dsRetours1.Retours.Rows.Count;                  
                dgRetour.SelectionChanged += dgDemande_SelectionChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            grRetour.Enabled = true;
            operation = Action.Ajout;
            // rendre visible les controle
            bAnnuler.Visible = true; bConfirmer.Visible = true;
            // rendre invisible les controle
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            txtEmplacement.Text = "*** Mode Ajout ***";
            gbChoix.Enabled = false;
            // Vider le formulaire
            BSRetours.AddNew();
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            grRetour.Enabled = true;
            operation = Action.Modif;
            // rendre visible les controle
            bAnnuler.Visible = true; bConfirmer.Visible = true;
            // rendre invisible les controle
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            // barrer le controle
            gbChoix.Enabled = false;
            txtEmplacement.Text = "*** Mode Modif ***";
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            grRetour.Enabled = false;
            operation = Action.Aucune;
            // Canceler l'edit
            BSRetours.CancelEdit();

            // rendre invisible les controle
            bAnnuler.Visible = false; bConfirmer.Visible = false;
            // rendre visible les controle
            bNouveau.Visible = true; bModifier.Visible = true; bRetirer.Visible = true;
            // debarrer la navigation
            gbChoix.Enabled = true;
            btnFirst.PerformClick();
        }

        private void bRetirer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous retirer ce retour ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BSRetours.RemoveCurrent();
                    daRetours.Update(dsRetours1.Retours);
                    // Feedback
                    MessageBox.Show("Demande retiré avec succès..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            BSRetours.EndEdit();
            daRetours.Update(dsRetours1.Retours);
            // rendre invisible les controle
            bAnnuler.Visible = false; bConfirmer.Visible = false;
            // rendre visible les controle
            bNouveau.Visible = true; bModifier.Visible = true; bRetirer.Visible = true;
            // debarrer la navigation
            gbChoix.Enabled = true;
            grRetour.Enabled = false;
            if (operation == Action.Ajout)
            {
                MessageBox.Show("Demande ajouté avec succès..");
                btnDernier.PerformClick();
            }
            else
            {
                MessageBox.Show("Demande modifié avec succès..");
            }
        }

        private void dgRetour_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgRetour.SelectedRows.Count > 0)
                {
                    txtEmplacement.Text = "Retours" + " " + (BSRetours.Position + 1) + " " + "de" + " " + dsRetours1.Retours.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // sender : indique l'initiateur de l'événement
            Button b = (Button)sender; // ici, je convertis l'objet en bouton (polymorphisme)
            switch (b.Tag)
            {
                case "premier":
                    BSRetours.MoveFirst();
                    break;
                case "precedent":
                    BSRetours.MovePrevious();
                    break;
                case "suivant":
                    BSRetours.MoveNext();
                    break;
                case "dernier":
                    BSRetours.MoveLast();
                    break;
            }

            txtEmplacement.Text = "Retours" + " " + (BSRetours.Position + 1) + " " + "de" + " " + dsRetours1.Retours.Rows.Count;
        }
    }
}
