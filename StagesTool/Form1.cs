using StagesTool.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StagesTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FrmEntreprise frm = new FrmEntreprise();
            addForms(frm);
        }

        private void addForms(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.AutoScroll = true;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bEntreprise_Click(object sender, EventArgs e)
        {
            FrmEntreprise frm = new FrmEntreprise();
            addForms(frm);
        }

        private void bDemandes_Click(object sender, EventArgs e)
        {
            FrmDemande frm = new FrmDemande();
            addForms(frm);
        }

        private void bEntrevues_Click(object sender, EventArgs e)
        {
            FrmEntrevue frm = new FrmEntrevue();
            addForms(frm);
        }

        private void bRetours_Click(object sender, EventArgs e)
        {
            FrmRetour frm = new FrmRetour();
            addForms(frm);
        }
    }
}
