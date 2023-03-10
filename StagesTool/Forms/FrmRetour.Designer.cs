namespace StagesTool.Forms
{
    partial class FrmRetour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetour));
            this.lblRetour = new System.Windows.Forms.Label();
            this.grRetour = new System.Windows.Forms.GroupBox();
            this.dtDateRetour = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.bAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.txtConcluant = new System.Windows.Forms.TextBox();
            this.bConfirmer = new Guna.UI2.WinForms.Guna2Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.lblNomDemande = new System.Windows.Forms.Label();
            this.cboNomDemande = new System.Windows.Forms.ComboBox();
            this.lblConcluant = new System.Windows.Forms.Label();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.bRetirer = new Guna.UI2.WinForms.Guna2Button();
            this.bModifier = new Guna.UI2.WinForms.Guna2Button();
            this.bNouveau = new Guna.UI2.WinForms.Guna2Button();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgRetour = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daRetours = new System.Data.SqlClient.SqlDataAdapter();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daDemande = new System.Data.SqlClient.SqlDataAdapter();
            this.dsRetours1 = new StagesTool.DSRetours();
            this.BSRetours = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRetourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concluantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grRetour.SuspendLayout();
            this.gbChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetours1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSRetours)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.BackColor = System.Drawing.Color.White;
            this.lblRetour.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblRetour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRetour.Location = new System.Drawing.Point(468, 9);
            this.lblRetour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(166, 45);
            this.lblRetour.TabIndex = 12;
            this.lblRetour.Text = "Retours";
            // 
            // grRetour
            // 
            this.grRetour.BackColor = System.Drawing.Color.White;
            this.grRetour.Controls.Add(this.dtDateRetour);
            this.grRetour.Controls.Add(this.txtId);
            this.grRetour.Controls.Add(this.lblId);
            this.grRetour.Controls.Add(this.bAnnuler);
            this.grRetour.Controls.Add(this.txtConcluant);
            this.grRetour.Controls.Add(this.bConfirmer);
            this.grRetour.Controls.Add(this.txtContact);
            this.grRetour.Controls.Add(this.txtEtat);
            this.grRetour.Controls.Add(this.lblNomDemande);
            this.grRetour.Controls.Add(this.cboNomDemande);
            this.grRetour.Controls.Add(this.lblConcluant);
            this.grRetour.Controls.Add(this.lblDateRetour);
            this.grRetour.Controls.Add(this.lblEtat);
            this.grRetour.Controls.Add(this.lblContact);
            this.grRetour.Enabled = false;
            this.grRetour.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grRetour.ForeColor = System.Drawing.Color.Black;
            this.grRetour.Location = new System.Drawing.Point(25, 101);
            this.grRetour.Name = "grRetour";
            this.grRetour.Size = new System.Drawing.Size(1052, 165);
            this.grRetour.TabIndex = 36;
            this.grRetour.TabStop = false;
            this.grRetour.Text = "Retour";
            // 
            // dtDateRetour
            // 
            this.dtDateRetour.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateRetour.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BSRetours, "DateRetour", true));
            this.dtDateRetour.Location = new System.Drawing.Point(683, 27);
            this.dtDateRetour.Name = "dtDateRetour";
            this.dtDateRetour.Size = new System.Drawing.Size(165, 23);
            this.dtDateRetour.TabIndex = 38;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSRetours, "Id", true));
            this.txtId.Location = new System.Drawing.Point(192, 27);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 37;
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(53, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 23);
            this.lblId.TabIndex = 36;
            this.lblId.Text = "Id:";
            // 
            // bAnnuler
            // 
            this.bAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(561, 129);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(94, 24);
            this.bAnnuler.TabIndex = 34;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.Visible = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // txtConcluant
            // 
            this.txtConcluant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSRetours, "Concluant", true));
            this.txtConcluant.Location = new System.Drawing.Point(683, 63);
            this.txtConcluant.Multiline = true;
            this.txtConcluant.Name = "txtConcluant";
            this.txtConcluant.Size = new System.Drawing.Size(289, 23);
            this.txtConcluant.TabIndex = 30;
            // 
            // bConfirmer
            // 
            this.bConfirmer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bConfirmer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bConfirmer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(410, 129);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(94, 24);
            this.bConfirmer.TabIndex = 35;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.Visible = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSRetours, "Contact", true));
            this.txtContact.Location = new System.Drawing.Point(188, 96);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(289, 23);
            this.txtContact.TabIndex = 29;
            // 
            // txtEtat
            // 
            this.txtEtat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSRetours, "Etat", true));
            this.txtEtat.Location = new System.Drawing.Point(188, 63);
            this.txtEtat.Multiline = true;
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.Size = new System.Drawing.Size(289, 23);
            this.txtEtat.TabIndex = 28;
            // 
            // lblNomDemande
            // 
            this.lblNomDemande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomDemande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDemande.Location = new System.Drawing.Point(548, 96);
            this.lblNomDemande.Name = "lblNomDemande";
            this.lblNomDemande.Size = new System.Drawing.Size(129, 23);
            this.lblNomDemande.TabIndex = 25;
            this.lblNomDemande.Text = "Nom de demande:";
            // 
            // cboNomDemande
            // 
            this.cboNomDemande.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BSRetours, "DemandeId", true));
            this.cboNomDemande.DataSource = this.dsRetours1;
            this.cboNomDemande.DisplayMember = "Demande.Nom";
            this.cboNomDemande.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomDemande.FormattingEnabled = true;
            this.cboNomDemande.Location = new System.Drawing.Point(683, 95);
            this.cboNomDemande.Name = "cboNomDemande";
            this.cboNomDemande.Size = new System.Drawing.Size(289, 24);
            this.cboNomDemande.TabIndex = 23;
            this.cboNomDemande.ValueMember = "Demande.Id";
            // 
            // lblConcluant
            // 
            this.lblConcluant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConcluant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcluant.Location = new System.Drawing.Point(548, 63);
            this.lblConcluant.Name = "lblConcluant";
            this.lblConcluant.Size = new System.Drawing.Size(129, 23);
            this.lblConcluant.TabIndex = 7;
            this.lblConcluant.Text = "Concluant:";
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRetour.Location = new System.Drawing.Point(548, 27);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(129, 23);
            this.lblDateRetour.TabIndex = 6;
            this.lblDateRetour.Text = "Date du retour:";
            // 
            // lblEtat
            // 
            this.lblEtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(53, 63);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(129, 23);
            this.lblEtat.TabIndex = 5;
            this.lblEtat.Text = "État:";
            // 
            // lblContact
            // 
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(53, 96);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(129, 23);
            this.lblContact.TabIndex = 3;
            this.lblContact.Text = "Contact:";
            // 
            // bRetirer
            // 
            this.bRetirer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRetirer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRetirer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRetirer.ForeColor = System.Drawing.Color.White;
            this.bRetirer.Location = new System.Drawing.Point(649, 283);
            this.bRetirer.Name = "bRetirer";
            this.bRetirer.Size = new System.Drawing.Size(94, 24);
            this.bRetirer.TabIndex = 38;
            this.bRetirer.Text = "Retirer";
            this.bRetirer.Click += new System.EventHandler(this.bRetirer_Click);
            // 
            // bModifier
            // 
            this.bModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bModifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bModifier.ForeColor = System.Drawing.Color.White;
            this.bModifier.Location = new System.Drawing.Point(500, 283);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(94, 24);
            this.bModifier.TabIndex = 39;
            this.bModifier.Text = "Modifier";
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // bNouveau
            // 
            this.bNouveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bNouveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bNouveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bNouveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bNouveau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bNouveau.ForeColor = System.Drawing.Color.White;
            this.bNouveau.Location = new System.Drawing.Point(360, 283);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(94, 24);
            this.bNouveau.TabIndex = 37;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.btnFirst);
            this.gbChoix.Controls.Add(this.btnDernier);
            this.gbChoix.Controls.Add(this.btnNext);
            this.gbChoix.Controls.Add(this.txtEmplacement);
            this.gbChoix.Controls.Add(this.btnBack);
            this.gbChoix.Location = new System.Drawing.Point(264, 536);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(574, 40);
            this.gbChoix.TabIndex = 40;
            this.gbChoix.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(6, 9);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(71, 26);
            this.btnFirst.TabIndex = 9;
            this.btnFirst.Tag = "premier";
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(497, 9);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(71, 26);
            this.btnDernier.TabIndex = 10;
            this.btnDernier.Tag = "dernier";
            this.btnDernier.Text = ">|";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(420, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 26);
            this.btnNext.TabIndex = 11;
            this.btnNext.Tag = "suivant";
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtEmplacement
            // 
            this.txtEmplacement.Enabled = false;
            this.txtEmplacement.Location = new System.Drawing.Point(160, 9);
            this.txtEmplacement.Multiline = true;
            this.txtEmplacement.Name = "txtEmplacement";
            this.txtEmplacement.Size = new System.Drawing.Size(254, 26);
            this.txtEmplacement.TabIndex = 13;
            this.txtEmplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(83, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 26);
            this.btnBack.TabIndex = 12;
            this.btnBack.Tag = "precedent";
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgRetour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgRetour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRetour.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRetour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRetour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.dateRetourDataGridViewTextBoxColumn,
            this.concluantDataGridViewTextBoxColumn,
            this.demandeIdDataGridViewTextBoxColumn});
            this.dgRetour.DataSource = this.BSRetours;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRetour.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRetour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgRetour.Location = new System.Drawing.Point(69, 325);
            this.dgRetour.MultiSelect = false;
            this.dgRetour.Name = "dgRetour";
            this.dgRetour.ReadOnly = true;
            this.dgRetour.RowHeadersVisible = false;
            this.dgRetour.Size = new System.Drawing.Size(964, 202);
            this.dgRetour.TabIndex = 41;
            this.dgRetour.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgRetour.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgRetour.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgRetour.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgRetour.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgRetour.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgRetour.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgRetour.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgRetour.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgRetour.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRetour.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgRetour.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRetour.ThemeStyle.HeaderStyle.Height = 15;
            this.dgRetour.ThemeStyle.ReadOnly = true;
            this.dgRetour.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgRetour.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRetour.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRetour.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgRetour.ThemeStyle.RowsStyle.Height = 22;
            this.dgRetour.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgRetour.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgRetour.SelectionChanged += new System.EventHandler(this.dgRetour_SelectionChanged);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Retours.*\r\nFROM            Retours";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Etat", System.Data.SqlDbType.NVarChar, 0, "Etat"),
            new System.Data.SqlClient.SqlParameter("@Contact", System.Data.SqlDbType.NVarChar, 0, "Contact"),
            new System.Data.SqlClient.SqlParameter("@DateRetour", System.Data.SqlDbType.Date, 0, "DateRetour"),
            new System.Data.SqlClient.SqlParameter("@Concluant", System.Data.SqlDbType.NVarChar, 0, "Concluant"),
            new System.Data.SqlClient.SqlParameter("@DemandeId", System.Data.SqlDbType.Int, 0, "DemandeId")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Etat", System.Data.SqlDbType.NVarChar, 0, "Etat"),
            new System.Data.SqlClient.SqlParameter("@Contact", System.Data.SqlDbType.NVarChar, 0, "Contact"),
            new System.Data.SqlClient.SqlParameter("@DateRetour", System.Data.SqlDbType.Date, 0, "DateRetour"),
            new System.Data.SqlClient.SqlParameter("@Concluant", System.Data.SqlDbType.NVarChar, 0, "Concluant"),
            new System.Data.SqlClient.SqlParameter("@DemandeId", System.Data.SqlDbType.Int, 0, "DemandeId"),
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Contact", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateRetour", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateRetour", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concluant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concluant", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DemandeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DemandeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Contact", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Contact", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateRetour", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateRetour", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Concluant", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Concluant", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DemandeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DemandeId", System.Data.DataRowVersion.Original, null)});
            // 
            // daRetours
            // 
            this.daRetours.DeleteCommand = this.sqlDeleteCommand1;
            this.daRetours.InsertCommand = this.sqlInsertCommand1;
            this.daRetours.SelectCommand = this.sqlSelectCommand1;
            this.daRetours.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Retours", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Etat", "Etat"),
                        new System.Data.Common.DataColumnMapping("Contact", "Contact"),
                        new System.Data.Common.DataColumnMapping("DateRetour", "DateRetour"),
                        new System.Data.Common.DataColumnMapping("Concluant", "Concluant"),
                        new System.Data.Common.DataColumnMapping("DemandeId", "DemandeId")})});
            this.daRetours.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Stages;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        Demande.*\r\nFROM            Demande";
            this.sqlSelectCommand2.Connection = this.cn;
            // 
            // daDemande
            // 
            this.daDemande.SelectCommand = this.sqlSelectCommand2;
            this.daDemande.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Demande", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Etat", "Etat"),
                        new System.Data.Common.DataColumnMapping("DateEnvoie", "DateEnvoie"),
                        new System.Data.Common.DataColumnMapping("EntrepriseId", "EntrepriseId"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
            // 
            // dsRetours1
            // 
            this.dsRetours1.DataSetName = "DSRetours";
            this.dsRetours1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSRetours
            // 
            this.BSRetours.DataMember = "Retours";
            this.BSRetours.DataSource = this.dsRetours1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            this.etatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRetourDataGridViewTextBoxColumn
            // 
            this.dateRetourDataGridViewTextBoxColumn.DataPropertyName = "DateRetour";
            this.dateRetourDataGridViewTextBoxColumn.HeaderText = "DateRetour";
            this.dateRetourDataGridViewTextBoxColumn.Name = "dateRetourDataGridViewTextBoxColumn";
            this.dateRetourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // concluantDataGridViewTextBoxColumn
            // 
            this.concluantDataGridViewTextBoxColumn.DataPropertyName = "Concluant";
            this.concluantDataGridViewTextBoxColumn.HeaderText = "Concluant";
            this.concluantDataGridViewTextBoxColumn.Name = "concluantDataGridViewTextBoxColumn";
            this.concluantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demandeIdDataGridViewTextBoxColumn
            // 
            this.demandeIdDataGridViewTextBoxColumn.DataPropertyName = "DemandeId";
            this.demandeIdDataGridViewTextBoxColumn.HeaderText = "DemandeId";
            this.demandeIdDataGridViewTextBoxColumn.Name = "demandeIdDataGridViewTextBoxColumn";
            this.demandeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.demandeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmRetour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 588);
            this.Controls.Add(this.dgRetour);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.bRetirer);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.grRetour);
            this.Controls.Add(this.lblRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRetour";
            this.Text = "FrmRetour";
            this.Load += new System.EventHandler(this.FrmRetour_Load);
            this.grRetour.ResumeLayout(false);
            this.grRetour.PerformLayout();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRetours1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSRetours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.GroupBox grRetour;
        private Guna.UI2.WinForms.Guna2Button bAnnuler;
        internal System.Windows.Forms.TextBox txtConcluant;
        private Guna.UI2.WinForms.Guna2Button bConfirmer;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtEtat;
        internal System.Windows.Forms.Label lblNomDemande;
        internal System.Windows.Forms.ComboBox cboNomDemande;
        internal System.Windows.Forms.Label lblConcluant;
        internal System.Windows.Forms.Label lblDateRetour;
        internal System.Windows.Forms.Label lblEtat;
        internal System.Windows.Forms.Label lblContact;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dtDateRetour;
        private Guna.UI2.WinForms.Guna2Button bRetirer;
        private Guna.UI2.WinForms.Guna2Button bModifier;
        private Guna.UI2.WinForms.Guna2Button bNouveau;
        internal System.Windows.Forms.GroupBox gbChoix;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnDernier;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox txtEmplacement;
        internal System.Windows.Forms.Button btnBack;
        private Guna.UI2.WinForms.Guna2DataGridView dgRetour;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daRetours;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daDemande;
        private DSRetours dsRetours1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRetourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concluantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource BSRetours;
    }
}