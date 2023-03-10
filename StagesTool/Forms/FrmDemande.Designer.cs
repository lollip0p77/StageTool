namespace StagesTool.Forms
{
    partial class FrmDemande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemande));
            this.lblDemande = new System.Windows.Forms.Label();
            this.grDemande = new System.Windows.Forms.GroupBox();
            this.bAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cboEntreprise = new System.Windows.Forms.ComboBox();
            this.bConfirmer = new Guna.UI2.WinForms.Guna2Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.lblDateEnvoie = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.dtDateEnvoie = new System.Windows.Forms.DateTimePicker();
            this.dgEntreprise = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsEntreprise1 = new StagesTool.DSEntreprise();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daEntreprise = new System.Data.SqlClient.SqlDataAdapter();
            this.dgDemande = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bRetirer = new Guna.UI2.WinForms.Guna2Button();
            this.bModifier = new Guna.UI2.WinForms.Guna2Button();
            this.bNouveau = new Guna.UI2.WinForms.Guna2Button();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daEntrepriseDg = new System.Data.SqlClient.SqlDataAdapter();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daDemande = new System.Data.SqlClient.SqlDataAdapter();
            this.dsDemande1 = new StagesTool.DSDemande();
            this.BSDemande = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnvoieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrepriseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDemande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntreprise1)).BeginInit();
            this.gbChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDemande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDemande1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDemande)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDemande
            // 
            this.lblDemande.AutoSize = true;
            this.lblDemande.BackColor = System.Drawing.Color.White;
            this.lblDemande.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblDemande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDemande.Location = new System.Drawing.Point(444, 9);
            this.lblDemande.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDemande.Name = "lblDemande";
            this.lblDemande.Size = new System.Drawing.Size(215, 45);
            this.lblDemande.TabIndex = 11;
            this.lblDemande.Text = "Demandes";
            // 
            // grDemande
            // 
            this.grDemande.Controls.Add(this.txtNom);
            this.grDemande.Controls.Add(this.lblNom);
            this.grDemande.Controls.Add(this.bAnnuler);
            this.grDemande.Controls.Add(this.txtId);
            this.grDemande.Controls.Add(this.txtAdresse);
            this.grDemande.Controls.Add(this.cboEntreprise);
            this.grDemande.Controls.Add(this.bConfirmer);
            this.grDemande.Controls.Add(this.lblId);
            this.grDemande.Controls.Add(this.lblEtat);
            this.grDemande.Controls.Add(this.lblDateEnvoie);
            this.grDemande.Controls.Add(this.lblEntreprise);
            this.grDemande.Controls.Add(this.dtDateEnvoie);
            this.grDemande.Enabled = false;
            this.grDemande.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.grDemande.Location = new System.Drawing.Point(45, 186);
            this.grDemande.Name = "grDemande";
            this.grDemande.Size = new System.Drawing.Size(447, 250);
            this.grDemande.TabIndex = 12;
            this.grDemande.TabStop = false;
            this.grDemande.Text = "Demande";
            // 
            // bAnnuler
            // 
            this.bAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(337, 150);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(94, 24);
            this.bAnnuler.TabIndex = 36;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.Visible = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSDemande, "Id", true));
            this.txtId.Location = new System.Drawing.Point(145, 29);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 32;
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSDemande, "Etat", true));
            this.txtAdresse.Location = new System.Drawing.Point(145, 111);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(165, 23);
            this.txtAdresse.TabIndex = 31;
            // 
            // cboEntreprise
            // 
            this.cboEntreprise.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BSDemande, "EntrepriseId", true));
            this.cboEntreprise.DataSource = this.dsDemande1;
            this.cboEntreprise.DisplayMember = "Entreprise.Nom";
            this.cboEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntreprise.FormattingEnabled = true;
            this.cboEntreprise.Location = new System.Drawing.Point(145, 197);
            this.cboEntreprise.Name = "cboEntreprise";
            this.cboEntreprise.Size = new System.Drawing.Size(165, 24);
            this.cboEntreprise.TabIndex = 30;
            this.cboEntreprise.ValueMember = "Entreprise.Id";
            // 
            // bConfirmer
            // 
            this.bConfirmer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bConfirmer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bConfirmer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(337, 99);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(94, 24);
            this.bConfirmer.TabIndex = 37;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.Visible = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(6, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 23);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "Id:";
            // 
            // lblEtat
            // 
            this.lblEtat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(6, 111);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(129, 23);
            this.lblEtat.TabIndex = 28;
            this.lblEtat.Text = "État:";
            // 
            // lblDateEnvoie
            // 
            this.lblDateEnvoie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateEnvoie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnvoie.Location = new System.Drawing.Point(6, 154);
            this.lblDateEnvoie.Name = "lblDateEnvoie";
            this.lblDateEnvoie.Size = new System.Drawing.Size(129, 23);
            this.lblDateEnvoie.TabIndex = 27;
            this.lblDateEnvoie.Text = "Date d\'envoie:";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEntreprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreprise.Location = new System.Drawing.Point(6, 197);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(129, 23);
            this.lblEntreprise.TabIndex = 26;
            this.lblEntreprise.Text = "Entreprise:";
            // 
            // dtDateEnvoie
            // 
            this.dtDateEnvoie.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateEnvoie.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BSDemande, "DateEnvoie", true));
            this.dtDateEnvoie.Location = new System.Drawing.Point(145, 154);
            this.dtDateEnvoie.Name = "dtDateEnvoie";
            this.dtDateEnvoie.Size = new System.Drawing.Size(165, 23);
            this.dtDateEnvoie.TabIndex = 13;
            // 
            // dgEntreprise
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgEntreprise.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEntreprise.AutoGenerateColumns = false;
            this.dgEntreprise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntreprise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgEntreprise.ColumnHeadersHeight = 15;
            this.dgEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgEntreprise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.actifDataGridViewCheckBoxColumn});
            this.dgEntreprise.DataMember = "Entreprise";
            this.dgEntreprise.DataSource = this.dsEntreprise1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntreprise.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgEntreprise.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntreprise.Location = new System.Drawing.Point(125, 91);
            this.dgEntreprise.MultiSelect = false;
            this.dgEntreprise.Name = "dgEntreprise";
            this.dgEntreprise.ReadOnly = true;
            this.dgEntreprise.RowHeadersVisible = false;
            this.dgEntreprise.Size = new System.Drawing.Size(853, 40);
            this.dgEntreprise.TabIndex = 34;
            this.dgEntreprise.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgEntreprise.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgEntreprise.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgEntreprise.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgEntreprise.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgEntreprise.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgEntreprise.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntreprise.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgEntreprise.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEntreprise.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEntreprise.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgEntreprise.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgEntreprise.ThemeStyle.HeaderStyle.Height = 15;
            this.dgEntreprise.ThemeStyle.ReadOnly = true;
            this.dgEntreprise.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgEntreprise.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEntreprise.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEntreprise.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgEntreprise.ThemeStyle.RowsStyle.Height = 22;
            this.dgEntreprise.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntreprise.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actifDataGridViewCheckBoxColumn
            // 
            this.actifDataGridViewCheckBoxColumn.DataPropertyName = "Actif";
            this.actifDataGridViewCheckBoxColumn.HeaderText = "Actif";
            this.actifDataGridViewCheckBoxColumn.Name = "actifDataGridViewCheckBoxColumn";
            this.actifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.actifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dsEntreprise1
            // 
            this.dsEntreprise1.DataSetName = "DSEntreprise";
            this.dsEntreprise1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.btnFirst);
            this.gbChoix.Controls.Add(this.btnDernier);
            this.gbChoix.Controls.Add(this.btnNext);
            this.gbChoix.Controls.Add(this.txtEmplacement);
            this.gbChoix.Controls.Add(this.btnBack);
            this.gbChoix.Location = new System.Drawing.Point(271, 490);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(574, 40);
            this.gbChoix.TabIndex = 35;
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
            // cn
            // 
            this.cn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Stages;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT   Id, Nom, Telephone, Email, Adresse, Ville, CodePostal, Actif\r\nFROM      " +
    "   Entreprise";
            this.sqlSelectCommand2.Connection = this.cn;
            // 
            // daEntreprise
            // 
            this.daEntreprise.SelectCommand = this.sqlSelectCommand2;
            this.daEntreprise.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Entreprise", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom"),
                        new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("Adresse", "Adresse"),
                        new System.Data.Common.DataColumnMapping("Ville", "Ville"),
                        new System.Data.Common.DataColumnMapping("CodePostal", "CodePostal"),
                        new System.Data.Common.DataColumnMapping("Actif", "Actif")})});
            // 
            // dgDemande
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgDemande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDemande.AutoGenerateColumns = false;
            this.dgDemande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDemande.ColumnHeadersHeight = 15;
            this.dgDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDemande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.etatDataGridViewTextBoxColumn,
            this.dateEnvoieDataGridViewTextBoxColumn,
            this.entrepriseIdDataGridViewTextBoxColumn});
            this.dgDemande.DataSource = this.BSDemande;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDemande.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDemande.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDemande.Location = new System.Drawing.Point(706, 186);
            this.dgDemande.MultiSelect = false;
            this.dgDemande.Name = "dgDemande";
            this.dgDemande.ReadOnly = true;
            this.dgDemande.RowHeadersVisible = false;
            this.dgDemande.Size = new System.Drawing.Size(324, 250);
            this.dgDemande.TabIndex = 36;
            this.dgDemande.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDemande.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDemande.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDemande.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDemande.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDemande.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgDemande.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDemande.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgDemande.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDemande.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDemande.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDemande.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDemande.ThemeStyle.HeaderStyle.Height = 15;
            this.dgDemande.ThemeStyle.ReadOnly = true;
            this.dgDemande.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDemande.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDemande.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDemande.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDemande.ThemeStyle.RowsStyle.Height = 22;
            this.dgDemande.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDemande.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDemande.SelectionChanged += new System.EventHandler(this.dgDemande_SelectionChanged_1);
            // 
            // bRetirer
            // 
            this.bRetirer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRetirer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRetirer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRetirer.ForeColor = System.Drawing.Color.White;
            this.bRetirer.Location = new System.Drawing.Point(549, 306);
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
            this.bModifier.Location = new System.Drawing.Point(549, 357);
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
            this.bNouveau.Location = new System.Drawing.Point(549, 258);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(94, 24);
            this.bNouveau.TabIndex = 40;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT   Id, Nom, Telephone, Email, Adresse, Ville, CodePostal, Actif\r\nFROM      " +
    "   Entreprise\r\nWHERE     (Id = @NoEntreprise)";
            this.sqlSelectCommand3.Connection = this.cn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@NoEntreprise", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // daEntrepriseDg
            // 
            this.daEntrepriseDg.SelectCommand = this.sqlSelectCommand3;
            this.daEntrepriseDg.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Entreprise", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom"),
                        new System.Data.Common.DataColumnMapping("Telephone", "Telephone"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("Adresse", "Adresse"),
                        new System.Data.Common.DataColumnMapping("Ville", "Ville"),
                        new System.Data.Common.DataColumnMapping("CodePostal", "CodePostal"),
                        new System.Data.Common.DataColumnMapping("Actif", "Actif")})});
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(6, 72);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(129, 23);
            this.lblNom.TabIndex = 38;
            this.lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSDemande, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(145, 73);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(165, 23);
            this.txtNom.TabIndex = 39;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Demande.*\r\nFROM            Demande";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Etat", System.Data.SqlDbType.NVarChar, 0, "Etat"),
            new System.Data.SqlClient.SqlParameter("@DateEnvoie", System.Data.SqlDbType.Date, 0, "DateEnvoie"),
            new System.Data.SqlClient.SqlParameter("@EntrepriseId", System.Data.SqlDbType.Int, 0, "EntrepriseId"),
            new System.Data.SqlClient.SqlParameter("@Nom", System.Data.SqlDbType.NVarChar, 0, "Nom")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Etat", System.Data.SqlDbType.NVarChar, 0, "Etat"),
            new System.Data.SqlClient.SqlParameter("@DateEnvoie", System.Data.SqlDbType.Date, 0, "DateEnvoie"),
            new System.Data.SqlClient.SqlParameter("@EntrepriseId", System.Data.SqlDbType.Int, 0, "EntrepriseId"),
            new System.Data.SqlClient.SqlParameter("@Nom", System.Data.SqlDbType.NVarChar, 0, "Nom"),
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateEnvoie", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnvoie", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EntrepriseId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EntrepriseId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nom", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Demande] WHERE (([Id] = @Original_Id) AND ([Etat] = @Original_Etat) " +
    "AND ([DateEnvoie] = @Original_DateEnvoie) AND ([EntrepriseId] = @Original_Entrep" +
    "riseId) AND ([Nom] = @Original_Nom))";
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etat", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etat", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateEnvoie", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnvoie", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EntrepriseId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EntrepriseId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nom", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null)});
            // 
            // daDemande
            // 
            this.daDemande.DeleteCommand = this.sqlDeleteCommand1;
            this.daDemande.InsertCommand = this.sqlInsertCommand1;
            this.daDemande.SelectCommand = this.sqlSelectCommand1;
            this.daDemande.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Demande", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("Etat", "Etat"),
                        new System.Data.Common.DataColumnMapping("DateEnvoie", "DateEnvoie"),
                        new System.Data.Common.DataColumnMapping("EntrepriseId", "EntrepriseId"),
                        new System.Data.Common.DataColumnMapping("Nom", "Nom")})});
            this.daDemande.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dsDemande1
            // 
            this.dsDemande1.DataSetName = "DSDemande";
            this.dsDemande1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSDemande
            // 
            this.BSDemande.DataMember = "Demande";
            this.BSDemande.DataSource = this.dsDemande1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "Etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            this.etatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEnvoieDataGridViewTextBoxColumn
            // 
            this.dateEnvoieDataGridViewTextBoxColumn.DataPropertyName = "DateEnvoie";
            this.dateEnvoieDataGridViewTextBoxColumn.HeaderText = "DateEnvoie";
            this.dateEnvoieDataGridViewTextBoxColumn.Name = "dateEnvoieDataGridViewTextBoxColumn";
            this.dateEnvoieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entrepriseIdDataGridViewTextBoxColumn
            // 
            this.entrepriseIdDataGridViewTextBoxColumn.DataPropertyName = "EntrepriseId";
            this.entrepriseIdDataGridViewTextBoxColumn.HeaderText = "EntrepriseId";
            this.entrepriseIdDataGridViewTextBoxColumn.Name = "entrepriseIdDataGridViewTextBoxColumn";
            this.entrepriseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.entrepriseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 588);
            this.Controls.Add(this.bRetirer);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.dgDemande);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.dgEntreprise);
            this.Controls.Add(this.grDemande);
            this.Controls.Add(this.lblDemande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDemande";
            this.Text = "FrmDemande";
            this.Load += new System.EventHandler(this.FrmDemande_Load);
            this.grDemande.ResumeLayout(false);
            this.grDemande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntreprise1)).EndInit();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDemande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDemande1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDemande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDemande;
        private System.Windows.Forms.GroupBox grDemande;
        private System.Windows.Forms.DateTimePicker dtDateEnvoie;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Label lblEtat;
        internal System.Windows.Forms.Label lblDateEnvoie;
        internal System.Windows.Forms.Label lblEntreprise;
        internal System.Windows.Forms.ComboBox cboEntreprise;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.TextBox txtAdresse;
        private Guna.UI2.WinForms.Guna2Button bAnnuler;
        private Guna.UI2.WinForms.Guna2Button bConfirmer;
        private Guna.UI2.WinForms.Guna2DataGridView dgEntreprise;
        internal System.Windows.Forms.GroupBox gbChoix;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnDernier;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox txtEmplacement;
        internal System.Windows.Forms.Button btnBack;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daEntreprise;
        private Guna.UI2.WinForms.Guna2DataGridView dgDemande;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actifDataGridViewCheckBoxColumn;
        private Guna.UI2.WinForms.Guna2Button bRetirer;
        private Guna.UI2.WinForms.Guna2Button bModifier;
        private Guna.UI2.WinForms.Guna2Button bNouveau;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter daEntrepriseDg;
        private DSEntreprise dsEntreprise1;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.Label lblNom;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daDemande;
        private System.Windows.Forms.BindingSource BSDemande;
        private DSDemande dsDemande1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnvoieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrepriseIdDataGridViewTextBoxColumn;
    }
}