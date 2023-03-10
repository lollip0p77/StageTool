namespace StagesTool
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pHeader = new System.Windows.Forms.Panel();
            this.bExit = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.bDemandes = new Guna.UI2.WinForms.Guna2Button();
            this.bEntreprise = new Guna.UI2.WinForms.Guna2Button();
            this.bRetours = new Guna.UI2.WinForms.Guna2Button();
            this.bEntrevues = new Guna.UI2.WinForms.Guna2Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pHeader.Controls.Add(this.bExit);
            this.pHeader.Controls.Add(this.lblNom);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1368, 53);
            this.pHeader.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.SpringGreen;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(1317, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(51, 53);
            this.bExit.TabIndex = 4;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblNom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(752, 15);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(97, 19);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Stage Tool";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(40, 15);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(172, 154);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(253, 59);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1103, 588);
            this.pContainer.TabIndex = 3;
            // 
            // bDemandes
            // 
            this.bDemandes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bDemandes.CheckedState.CustomBorderColor = System.Drawing.Color.SpringGreen;
            this.bDemandes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bDemandes.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bDemandes.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bDemandes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bDemandes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bDemandes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bDemandes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bDemandes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bDemandes.ForeColor = System.Drawing.Color.Black;
            this.bDemandes.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.bDemandes.Location = new System.Drawing.Point(0, 280);
            this.bDemandes.Margin = new System.Windows.Forms.Padding(0);
            this.bDemandes.Name = "bDemandes";
            this.bDemandes.Size = new System.Drawing.Size(247, 45);
            this.bDemandes.TabIndex = 1;
            this.bDemandes.Text = "Demandes";
            this.bDemandes.Click += new System.EventHandler(this.bDemandes_Click);
            // 
            // bEntreprise
            // 
            this.bEntreprise.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bEntreprise.Checked = true;
            this.bEntreprise.CheckedState.CustomBorderColor = System.Drawing.Color.SpringGreen;
            this.bEntreprise.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bEntreprise.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bEntreprise.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bEntreprise.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bEntreprise.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bEntreprise.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bEntreprise.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bEntreprise.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bEntreprise.ForeColor = System.Drawing.Color.Black;
            this.bEntreprise.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.bEntreprise.Location = new System.Drawing.Point(0, 225);
            this.bEntreprise.Margin = new System.Windows.Forms.Padding(0);
            this.bEntreprise.Name = "bEntreprise";
            this.bEntreprise.Size = new System.Drawing.Size(247, 45);
            this.bEntreprise.TabIndex = 0;
            this.bEntreprise.Text = "Entreprises";
            this.bEntreprise.Click += new System.EventHandler(this.bEntreprise_Click);
            // 
            // bRetours
            // 
            this.bRetours.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bRetours.CheckedState.CustomBorderColor = System.Drawing.Color.SpringGreen;
            this.bRetours.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bRetours.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bRetours.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bRetours.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRetours.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRetours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRetours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRetours.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bRetours.ForeColor = System.Drawing.Color.Black;
            this.bRetours.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.bRetours.Location = new System.Drawing.Point(0, 335);
            this.bRetours.Margin = new System.Windows.Forms.Padding(0);
            this.bRetours.Name = "bRetours";
            this.bRetours.Size = new System.Drawing.Size(247, 45);
            this.bRetours.TabIndex = 2;
            this.bRetours.Text = "Retours";
            this.bRetours.Click += new System.EventHandler(this.bRetours_Click);
            // 
            // bEntrevues
            // 
            this.bEntrevues.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.bEntrevues.CheckedState.CustomBorderColor = System.Drawing.Color.SpringGreen;
            this.bEntrevues.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bEntrevues.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bEntrevues.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bEntrevues.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bEntrevues.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bEntrevues.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bEntrevues.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bEntrevues.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bEntrevues.ForeColor = System.Drawing.Color.Black;
            this.bEntrevues.HoverState.CustomBorderColor = System.Drawing.Color.Fuchsia;
            this.bEntrevues.Location = new System.Drawing.Point(0, 391);
            this.bEntrevues.Margin = new System.Windows.Forms.Padding(0);
            this.bEntrevues.Name = "bEntrevues";
            this.bEntrevues.Size = new System.Drawing.Size(247, 45);
            this.bEntrevues.TabIndex = 3;
            this.bEntrevues.Text = "Entrevues";
            this.bEntrevues.Click += new System.EventHandler(this.bEntrevues_Click);
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pMenu.Controls.Add(this.bEntrevues);
            this.pMenu.Controls.Add(this.guna2CirclePictureBox1);
            this.pMenu.Controls.Add(this.bDemandes);
            this.pMenu.Controls.Add(this.bEntreprise);
            this.pMenu.Controls.Add(this.bRetours);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 53);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(247, 610);
            this.pMenu.TabIndex = 4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pHeader;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1368, 663);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button bExit;
        private Guna.UI2.WinForms.Guna2Button bDemandes;
        private Guna.UI2.WinForms.Guna2Button bEntreprise;
        private Guna.UI2.WinForms.Guna2Button bRetours;
        private Guna.UI2.WinForms.Guna2Button bEntrevues;
        private System.Windows.Forms.Panel pMenu;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

