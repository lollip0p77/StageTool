using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagesTool.Forms
{
    public enum Action
    {
        Aucune = 0,
        Modif = 1,
        Ajout = 2
    }

    public partial class FrmDemande : Form
    {
        //Globales
        Action operation = Action.Aucune;
        private EventHandler dgDemande_SelectionChanged;

        public FrmDemande()
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
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            

        }

        private void Naviguer(object sender, EventArgs e)
        {
            // sender : indique l'initiateur de l'événement
            Button b = (Button)sender; // ici, je convertis l'objet en bouton (polymorphisme)
            switch (b.Tag.ToString())
            {
                case "Premier":
                    BSDemande.MoveFirst();
                    break;
                case "Precedent":
                    BSDemande.MovePrevious();
                    break;
                case "Suivant":
                    BSDemande.MoveNext();
                    break;
                case "Dernier":
                    BSDemande.MoveLast();
                    break;
            }
            txtEmplacement.Text = "Demande" + " " + (BSDemande.Position + 1) + " " + "de" + " " + dsDemande1.Demande.Rows.Count;
            RemplirEntreprise();
        }


        private void FrmDemande_Load(object sender, EventArgs e)
        {
            try
            {
                //Remplir les table du dataset
                daEntreprise.Fill(dsDemande1.Entreprise);
                daDemande.Fill(dsDemande1.Demande);
                // Verifier s'il a des demandes
                if(dsDemande1.Demande.Count > 0 )
                {
                    txtEmplacement.Text = "Demande" + " " + (BSDemande.Position + 1) + " " + "de" + " " + dsDemande1.Demande.Rows.Count;
                    RemplirEntreprise();
                }
                dgDemande.SelectionChanged += dgDemande_SelectionChanged;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bNouveau_Click(object sender, EventArgs e)
        {
            grDemande.Enabled = true;
            operation = Action.Ajout;
            // rendre visible les controle
            bAnnuler.Visible = true; bConfirmer.Visible = true;
            // rendre invisible les controle
            bNouveau.Visible = false; bModifier.Visible = false; bRetirer.Visible = false;
            txtEmplacement.Text = "*** Mode Ajout ***";
            gbChoix.Enabled = false;
            // Vider le formulaire
            BSDemande.AddNew();
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            grDemande.Enabled = true;
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
            grDemande.Enabled = false;
            operation = Action.Aucune;
            // Canceler l'edit
            BSDemande.CancelEdit();

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
                if (MessageBox.Show("Voulez-vous retirer cette DEMANDE?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BSDemande.RemoveCurrent();
                    daDemande.Update(dsDemande1.Demande);
                    // Feedback
                    MessageBox.Show("Demande retiré avec succès..");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bConfirmer_Click(object sender, EventArgs e)
        {
            BSDemande.EndEdit();
            daDemande.Update(dsDemande1.Demande);
            // rendre invisible les controle
            bAnnuler.Visible = false; bConfirmer.Visible = false;
            // rendre visible les controle
            bNouveau.Visible = true; bModifier.Visible = true; bRetirer.Visible = true;
            // debarrer la navigation
            gbChoix.Enabled = true;
            grDemande.Enabled = false;
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

        private void dgDemande_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgDemande.SelectedRows.Count > 0)
                {
                    txtEmplacement.Text = "Demande" + " " + (BSDemande.Position + 1) + " " + "de" + " " + dsDemande1.Demande.Rows.Count;
                    RemplirEntreprise();
                }
            }
            catch(Exception ex)
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
                    BSDemande.MoveFirst();
                    break;
                case "precedent":
                    BSDemande.MovePrevious();
                    break;
                case "suivant":
                    BSDemande.MoveNext();
                    break;
                case "dernier":
                    BSDemande.MoveLast();
                    break;
            }
            
            txtEmplacement.Text = "Demande" + " " + (BSDemande.Position + 1) + " " + "de" + " " + dsDemande1.Demande.Rows.Count;
            RemplirEntreprise();
        }
    }
}
