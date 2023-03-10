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
    

    public partial class FrmEntrevue : Form
    {
        //Globales
        Action operation = Action.Aucune;
        private EventHandler dgDemande_SelectionChanged;

        public FrmEntrevue()
        {
            InitializeComponent();
        }

        private void RemplirEntreprise()
        {
            try
            {
                // Remplir les tables du dataset
                dsEntreprise1.Entreprise.Clear();

                // Specifier le parametre
                daEntrepriseDg.SelectCommand.Parameters["@NoEntreprise"].Value = cboEntreprise.SelectedValue;

                //daEntrepriseDg.SelectCommand.Parameters.AddWithValue("@NoEntreprise", cboEntreprise.SelectedValue);
                // Remplissage de la table entreprise
                daEntrepriseDg.Fill(dsEntreprise1.Entreprise);
                //bRetirer.Enabled = (dsEntreprise1.Entreprise.Rows.Count == 0);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

        private void FrmEntrevue_Load(object sender, EventArgs e)
        {
            try
            {
                //Remplir les table du dataset
                daEntreprise.Fill(dsEntrevue1.Entreprise);
                daEntrevue.Fill(dsEntrevue1.Entrevues);
                // Verifier s'il a des demandes
                if (dsEntrevue1.Entrevues.Count > 0)
                {
                    txtEmplacement.Text = "Demande" + " " + (BSEntrevue.Position + 1) + " " + "de" + " " + dsEntrevue1.Entrevues.Rows.Count;
                    RemplirEntreprise();
                }
                dgEntrevue.SelectionChanged += dgDemande_SelectionChanged;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            grEntrevue.Enabled = true;
            operation = Action.Ajout;
            // rendre visible les controle
            bAnnuler.Visible = true; bConfirmer.Visible = true;
            // rendre invisible les controle
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            txtEmplacement.Text = "*** Mode Ajout ***";
            gbChoix.Enabled = false;
            // Vider le formulaire
            BSEntrevue.AddNew();
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            grEntrevue.Enabled = true;
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
            grEntrevue.Enabled = false;
            operation = Action.Aucune;
            // Canceler l'edit
            BSEntrevue.CancelEdit();

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
                if (MessageBox.Show("Voulez-vous retirer cette entrevue?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BSEntrevue.RemoveCurrent();
                    daEntrevue.Update(dsEntrevue1.Entrevues);
                    // Feedback
                    MessageBox.Show("Entrvue retiré avec succès..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            BSEntrevue.EndEdit();
            daEntrevue.Update(dsEntrevue1.Entrevues);
            // rendre invisible les controle
            bAnnuler.Visible = false; bConfirmer.Visible = false;
            // rendre visible les controle
            bNouveau.Visible = true; bModifier.Visible = true; bRetirer.Visible = true;
            // debarrer la navigation
            gbChoix.Enabled = true;
            grEntrevue.Enabled = false;
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

        private void dgEntrevue_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgEntrevue.SelectedRows.Count > 0)
                {
                    txtEmplacement.Text = "Demande" + " " + (BSEntrevue.Position + 1) + " " + "de" + " " + dsEntrevue1.Entrevues.Rows.Count;
                    RemplirEntreprise();
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
                    BSEntrevue.MoveFirst();
                    break;
                case "precedent":
                    BSEntrevue.MovePrevious();
                    break;
                case "suivant":
                    BSEntrevue.MoveNext();
                    break;
                case "dernier":
                    BSEntrevue.MoveLast();
                    break;
            }

            txtEmplacement.Text = "Demande" + " " + (BSEntrevue.Position + 1) + " " + "de" + " " + dsEntrevue1.Entrevues.Rows.Count;
            RemplirEntreprise();
        }
    }
}
