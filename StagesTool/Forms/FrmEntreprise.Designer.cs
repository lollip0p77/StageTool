namespace StagesTool.Forms
{
    partial class FrmEntreprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntreprise));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ds1 = new StagesTool.DS();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daEntreprise = new System.Data.SqlClient.SqlDataAdapter();
            this.actifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grEntreprise = new System.Windows.Forms.GroupBox();
            this.bAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.bConfirmer = new Guna.UI2.WinForms.Guna2Button();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.mskCP = new System.Windows.Forms.MaskedTextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.cboActif = new System.Windows.Forms.ComboBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblActif = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.bModifier = new Guna.UI2.WinForms.Guna2Button();
            this.bRetirer = new Guna.UI2.WinForms.Guna2Button();
            this.bNouveau = new Guna.UI2.WinForms.Guna2Button();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgEntreprise = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.grEntreprise.SuspendLayout();
            this.gbChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DS";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT   Entreprise.*\r\nFROM         Entreprise";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Stages;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Nom", System.Data.SqlDbType.NVarChar, 0, "Nom"),
            new System.Data.SqlClient.SqlParameter("@Telephone", System.Data.SqlDbType.NVarChar, 0, "Telephone"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@Adresse", System.Data.SqlDbType.NVarChar, 0, "Adresse"),
            new System.Data.SqlClient.SqlParameter("@Ville", System.Data.SqlDbType.NVarChar, 0, "Ville"),
            new System.Data.SqlClient.SqlParameter("@CodePostal", System.Data.SqlDbType.NVarChar, 0, "CodePostal"),
            new System.Data.SqlClient.SqlParameter("@Actif", System.Data.SqlDbType.Bit, 0, "Actif")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Nom", System.Data.SqlDbType.NVarChar, 0, "Nom"),
            new System.Data.SqlClient.SqlParameter("@Telephone", System.Data.SqlDbType.NVarChar, 0, "Telephone"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@Adresse", System.Data.SqlDbType.NVarChar, 0, "Adresse"),
            new System.Data.SqlClient.SqlParameter("@Ville", System.Data.SqlDbType.NVarChar, 0, "Ville"),
            new System.Data.SqlClient.SqlParameter("@CodePostal", System.Data.SqlDbType.NVarChar, 0, "CodePostal"),
            new System.Data.SqlClient.SqlParameter("@Actif", System.Data.SqlDbType.Bit, 0, "Actif"),
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nom", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Telephone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Adresse", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ville", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CodePostal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CodePostal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Actif", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Actif", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Nom", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Nom", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Telephone", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Telephone", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Adresse", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Ville", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ville", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CodePostal", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CodePostal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Actif", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Actif", System.Data.DataRowVersion.Original, null)});
            // 
            // daEntreprise
            // 
            this.daEntreprise.DeleteCommand = this.sqlDeleteCommand1;
            this.daEntreprise.InsertCommand = this.sqlInsertCommand1;
            this.daEntreprise.SelectCommand = this.sqlSelectCommand1;
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
            this.daEntreprise.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // actifDataGridViewCheckBoxColumn
            // 
            this.actifDataGridViewCheckBoxColumn.DataPropertyName = "Actif";
            this.actifDataGridViewCheckBoxColumn.HeaderText = "Actif";
            this.actifDataGridViewCheckBoxColumn.Name = "actifDataGridViewCheckBoxColumn";
            this.actifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.actifDataGridViewCheckBoxColumn.Visible = false;
            // 
            // grEntreprise
            // 
            this.grEntreprise.BackColor = System.Drawing.Color.White;
            this.grEntreprise.Controls.Add(this.bAnnuler);
            this.grEntreprise.Controls.Add(this.txtVille);
            this.grEntreprise.Controls.Add(this.bConfirmer);
            this.grEntreprise.Controls.Add(this.txtAdresse);
            this.grEntreprise.Controls.Add(this.txtEmail);
            this.grEntreprise.Controls.Add(this.txtNom);
            this.grEntreprise.Controls.Add(this.mskCP);
            this.grEntreprise.Controls.Add(this.lblCodePostal);
            this.grEntreprise.Controls.Add(this.mskTelephone);
            this.grEntreprise.Controls.Add(this.cboActif);
            this.grEntreprise.Controls.Add(this.lblVille);
            this.grEntreprise.Controls.Add(this.lblAdresse);
            this.grEntreprise.Controls.Add(this.lblTelephone);
            this.grEntreprise.Controls.Add(this.lblActif);
            this.grEntreprise.Controls.Add(this.lblEmail);
            this.grEntreprise.Controls.Add(this.lblNom);
            this.grEntreprise.Enabled = false;
            this.grEntreprise.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grEntreprise.ForeColor = System.Drawing.Color.Black;
            this.grEntreprise.Location = new System.Drawing.Point(25, 62);
            this.grEntreprise.Name = "grEntreprise";
            this.grEntreprise.Size = new System.Drawing.Size(1052, 186);
            this.grEntreprise.TabIndex = 35;
            this.grEntreprise.TabStop = false;
            this.grEntreprise.Text = "Entreprise";
            // 
            // bAnnuler
            // 
            this.bAnnuler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bAnnuler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bAnnuler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bAnnuler.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bAnnuler.ForeColor = System.Drawing.Color.White;
            this.bAnnuler.Location = new System.Drawing.Point(937, 150);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(94, 24);
            this.bAnnuler.TabIndex = 34;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.Visible = false;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(668, 80);
            this.txtVille.Multiline = true;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(289, 23);
            this.txtVille.TabIndex = 30;
            // 
            // bConfirmer
            // 
            this.bConfirmer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bConfirmer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bConfirmer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bConfirmer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bConfirmer.ForeColor = System.Drawing.Color.White;
            this.bConfirmer.Location = new System.Drawing.Point(837, 150);
            this.bConfirmer.Name = "bConfirmer";
            this.bConfirmer.Size = new System.Drawing.Size(94, 24);
            this.bConfirmer.TabIndex = 35;
            this.bConfirmer.Text = "Confirmer";
            this.bConfirmer.Visible = false;
            this.bConfirmer.Click += new System.EventHandler(this.bConfirmer_Click);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(668, 44);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(289, 23);
            this.txtAdresse.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(173, 113);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 23);
            this.txtEmail.TabIndex = 28;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(173, 44);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(289, 23);
            this.txtNom.TabIndex = 27;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // mskCP
            // 
            this.mskCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCP.Location = new System.Drawing.Point(668, 113);
            this.mskCP.Mask = "A0A-0A0";
            this.mskCP.Name = "mskCP";
            this.mskCP.Size = new System.Drawing.Size(127, 24);
            this.mskCP.TabIndex = 26;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(533, 113);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(129, 23);
            this.lblCodePostal.TabIndex = 25;
            this.lblCodePostal.Text = "Code Postal:";
            // 
            // mskTelephone
            // 
            this.mskTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelephone.Location = new System.Drawing.Point(173, 80);
            this.mskTelephone.Mask = "(000) 000-0000";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(165, 24);
            this.mskTelephone.TabIndex = 24;
            // 
            // cboActif
            // 
            this.cboActif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActif.FormattingEnabled = true;
            this.cboActif.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.cboActif.Location = new System.Drawing.Point(533, 151);
            this.cboActif.Name = "cboActif";
            this.cboActif.Size = new System.Drawing.Size(127, 24);
            this.cboActif.TabIndex = 23;
            // 
            // lblVille
            // 
            this.lblVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(533, 80);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(129, 23);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(533, 44);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(129, 23);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(38, 80);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(129, 23);
            this.lblTelephone.TabIndex = 5;
            this.lblTelephone.Text = "Téléphone:";
            // 
            // lblActif
            // 
            this.lblActif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActif.Location = new System.Drawing.Point(399, 151);
            this.lblActif.Name = "lblActif";
            this.lblActif.Size = new System.Drawing.Size(129, 23);
            this.lblActif.TabIndex = 4;
            this.lblActif.Text = "Actif:";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(38, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Courriel:";
            // 
            // lblNom
            // 
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(38, 44);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(129, 23);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom:";
            // 
            // bModifier
            // 
            this.bModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bModifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bModifier.ForeColor = System.Drawing.Color.White;
            this.bModifier.Location = new System.Drawing.Point(505, 258);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(94, 24);
            this.bModifier.TabIndex = 33;
            this.bModifier.Text = "Modifier";
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // bRetirer
            // 
            this.bRetirer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRetirer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRetirer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRetirer.ForeColor = System.Drawing.Color.White;
            this.bRetirer.Location = new System.Drawing.Point(652, 258);
            this.bRetirer.Name = "bRetirer";
            this.bRetirer.Size = new System.Drawing.Size(94, 24);
            this.bRetirer.TabIndex = 32;
            this.bRetirer.Text = "Retirer";
            this.bRetirer.Click += new System.EventHandler(this.bRetirer_Click);
            // 
            // bNouveau
            // 
            this.bNouveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bNouveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bNouveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bNouveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bNouveau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bNouveau.ForeColor = System.Drawing.Color.White;
            this.bNouveau.Location = new System.Drawing.Point(357, 258);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(94, 24);
            this.bNouveau.TabIndex = 31;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.gbChoix.TabIndex = 34;
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
            this.btnFirst.Click += new System.EventHandler(this.cmdBack_Click);
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
            this.btnDernier.Click += new System.EventHandler(this.cmdBack_Click);
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
            this.btnNext.Click += new System.EventHandler(this.cmdBack_Click);
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
            this.btnBack.Click += new System.EventHandler(this.cmdBack_Click);
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
            this.dgEntreprise.DataSource = this.ds1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntreprise.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgEntreprise.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntreprise.Location = new System.Drawing.Point(25, 299);
            this.dgEntreprise.MultiSelect = false;
            this.dgEntreprise.Name = "dgEntreprise";
            this.dgEntreprise.ReadOnly = true;
            this.dgEntreprise.RowHeadersVisible = false;
            this.dgEntreprise.Size = new System.Drawing.Size(1052, 228);
            this.dgEntreprise.TabIndex = 33;
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
            this.dgEntreprise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEntreprise_CellContentClick_1);
            this.dgEntreprise.SelectionChanged += new System.EventHandler(this.dgEntreprise_SelectionChanged_1);
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
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.BackColor = System.Drawing.Color.White;
            this.lblEntreprise.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntreprise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEntreprise.Location = new System.Drawing.Point(446, 11);
            this.lblEntreprise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(211, 45);
            this.lblEntreprise.TabIndex = 32;
            this.lblEntreprise.Text = "Entreprise";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // FrmEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 588);
            this.Controls.Add(this.grEntreprise);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.bRetirer);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.dgEntreprise);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.bNouveau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntreprise";
            this.Text = "FrmEntreprise";
            this.Load += new System.EventHandler(this.FrmEntreprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.grEntreprise.ResumeLayout(false);
            this.grEntreprise.PerformLayout();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daEntreprise;
        private DS ds1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox grEntreprise;
        private Guna.UI2.WinForms.Guna2Button bConfirmer;
        private Guna.UI2.WinForms.Guna2Button bAnnuler;
        private Guna.UI2.WinForms.Guna2Button bModifier;
        private Guna.UI2.WinForms.Guna2Button bRetirer;
        private Guna.UI2.WinForms.Guna2Button bNouveau;
        internal System.Windows.Forms.TextBox txtVille;
        internal System.Windows.Forms.TextBox txtAdresse;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.MaskedTextBox mskCP;
        internal System.Windows.Forms.Label lblCodePostal;
        internal System.Windows.Forms.MaskedTextBox mskTelephone;
        internal System.Windows.Forms.ComboBox cboActif;
        internal System.Windows.Forms.Label lblVille;
        internal System.Windows.Forms.Label lblAdresse;
        internal System.Windows.Forms.Label lblTelephone;
        internal System.Windows.Forms.Label lblActif;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.GroupBox gbChoix;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnDernier;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox txtEmplacement;
        internal System.Windows.Forms.Button btnBack;
        private Guna.UI2.WinForms.Guna2DataGridView dgEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.ErrorProvider erp;
    }
}