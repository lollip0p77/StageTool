namespace StagesTool.Forms
{
    partial class FrmEntrevue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrevue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEntrevue = new System.Windows.Forms.Label();
            this.grEntrevue = new System.Windows.Forms.GroupBox();
            this.mskHeure = new System.Windows.Forms.MaskedTextBox();
            this.BSEntrevue = new System.Windows.Forms.BindingSource(this.components);
            this.dsEntrevue1 = new StagesTool.DSEntrevue();
            this.bAnnuler = new Guna.UI2.WinForms.Guna2Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cboEntreprise = new System.Windows.Forms.ComboBox();
            this.bConfirmer = new Guna.UI2.WinForms.Guna2Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDateEnvoie = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.dtDateEnvoie = new System.Windows.Forms.DateTimePicker();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daEntrevue = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daEntreprise = new System.Data.SqlClient.SqlDataAdapter();
            this.daEntrepriseDg = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.dsEntreprise1 = new StagesTool.DSEntreprise();
            this.bRetirer = new Guna.UI2.WinForms.Guna2Button();
            this.bModifier = new Guna.UI2.WinForms.Guna2Button();
            this.bNouveau = new Guna.UI2.WinForms.Guna2Button();
            this.dgEntreprise = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgEntrevue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrepriseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChoix = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmplacement = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.grEntrevue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSEntrevue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntrevue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntreprise1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrevue)).BeginInit();
            this.gbChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntrevue
            // 
            this.lblEntrevue.AutoSize = true;
            this.lblEntrevue.BackColor = System.Drawing.Color.White;
            this.lblEntrevue.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblEntrevue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEntrevue.Location = new System.Drawing.Point(448, 9);
            this.lblEntrevue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrevue.Name = "lblEntrevue";
            this.lblEntrevue.Size = new System.Drawing.Size(206, 45);
            this.lblEntrevue.TabIndex = 13;
            this.lblEntrevue.Text = "Entrevues";
            // 
            // grEntrevue
            // 
            this.grEntrevue.Controls.Add(this.mskHeure);
            this.grEntrevue.Controls.Add(this.bAnnuler);
            this.grEntrevue.Controls.Add(this.txtId);
            this.grEntrevue.Controls.Add(this.cboEntreprise);
            this.grEntrevue.Controls.Add(this.bConfirmer);
            this.grEntrevue.Controls.Add(this.lblId);
            this.grEntrevue.Controls.Add(this.lblHeure);
            this.grEntrevue.Controls.Add(this.lblDateEnvoie);
            this.grEntrevue.Controls.Add(this.lblEntreprise);
            this.grEntrevue.Controls.Add(this.dtDateEnvoie);
            this.grEntrevue.Enabled = false;
            this.grEntrevue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.grEntrevue.Location = new System.Drawing.Point(33, 186);
            this.grEntrevue.Name = "grEntrevue";
            this.grEntrevue.Size = new System.Drawing.Size(447, 250);
            this.grEntrevue.TabIndex = 14;
            this.grEntrevue.TabStop = false;
            this.grEntrevue.Text = "Entrevue";
            // 
            // mskHeure
            // 
            this.mskHeure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskHeure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSEntrevue, "Heure", true));
            this.mskHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHeure.Location = new System.Drawing.Point(145, 100);
            this.mskHeure.Mask = "00:00";
            this.mskHeure.Name = "mskHeure";
            this.mskHeure.Size = new System.Drawing.Size(165, 24);
            this.mskHeure.TabIndex = 25;
            // 
            // BSEntrevue
            // 
            this.BSEntrevue.DataMember = "Entrevues";
            this.BSEntrevue.DataSource = this.dsEntrevue1;
            // 
            // dsEntrevue1
            // 
            this.dsEntrevue1.DataSetName = "DSEntrevue";
            this.dsEntrevue1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSEntrevue, "Id", true));
            this.txtId.Location = new System.Drawing.Point(145, 56);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(165, 23);
            this.txtId.TabIndex = 32;
            // 
            // cboEntreprise
            // 
            this.cboEntreprise.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BSEntrevue, "EntrepriseId", true));
            this.cboEntreprise.DataSource = this.dsEntrevue1;
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
            this.lblId.Location = new System.Drawing.Point(6, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(129, 23);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "Id:";
            // 
            // lblHeure
            // 
            this.lblHeure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(6, 100);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(129, 23);
            this.lblHeure.TabIndex = 28;
            this.lblHeure.Text = "Heure:";
            // 
            // lblDateEnvoie
            // 
            this.lblDateEnvoie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateEnvoie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateEnvoie.Location = new System.Drawing.Point(6, 150);
            this.lblDateEnvoie.Name = "lblDateEnvoie";
            this.lblDateEnvoie.Size = new System.Drawing.Size(129, 23);
            this.lblDateEnvoie.TabIndex = 27;
            this.lblDateEnvoie.Text = "Date de l\'entrevue:";
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
            this.dtDateEnvoie.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BSEntrevue, "Date", true));
            this.dtDateEnvoie.Location = new System.Drawing.Point(145, 150);
            this.dtDateEnvoie.Name = "dtDateEnvoie";
            this.dtDateEnvoie.Size = new System.Drawing.Size(165, 23);
            this.dtDateEnvoie.TabIndex = 13;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT   Entrevues.*\r\nFROM         Entrevues";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=Stages;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Entrevues] ([EntrepriseId], [Date], [Heure]) VALUES (@EntrepriseId, " +
    "@Date, @Heure);\r\nSELECT Id, EntrepriseId, Date, Heure FROM Entrevues WHERE (Id =" +
    " SCOPE_IDENTITY())";
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EntrepriseId", System.Data.SqlDbType.Int, 0, "EntrepriseId"),
            new System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Date, 0, "Date"),
            new System.Data.SqlClient.SqlParameter("@Heure", System.Data.SqlDbType.NVarChar, 0, "Heure")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EntrepriseId", System.Data.SqlDbType.Int, 0, "EntrepriseId"),
            new System.Data.SqlClient.SqlParameter("@Date", System.Data.SqlDbType.Date, 0, "Date"),
            new System.Data.SqlClient.SqlParameter("@Heure", System.Data.SqlDbType.NVarChar, 0, "Heure"),
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EntrepriseId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EntrepriseId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Heure", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Heure", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Entrevues] WHERE (([Id] = @Original_Id) AND ([EntrepriseId] = @Origi" +
    "nal_EntrepriseId) AND ([Date] = @Original_Date) AND ([Heure] = @Original_Heure))" +
    "";
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_EntrepriseId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EntrepriseId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Date", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Heure", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Heure", System.Data.DataRowVersion.Original, null)});
            // 
            // daEntrevue
            // 
            this.daEntrevue.DeleteCommand = this.sqlDeleteCommand1;
            this.daEntrevue.InsertCommand = this.sqlInsertCommand1;
            this.daEntrevue.SelectCommand = this.sqlSelectCommand1;
            this.daEntrevue.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Entrevues", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("EntrepriseId", "EntrepriseId"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("Heure", "Heure")})});
            this.daEntrevue.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT   Entreprise.*\r\nFROM         Entreprise";
            this.sqlSelectCommand2.Connection = this.cn;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.cn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Nom", System.Data.SqlDbType.NVarChar, 0, "Nom"),
            new System.Data.SqlClient.SqlParameter("@Telephone", System.Data.SqlDbType.NVarChar, 0, "Telephone"),
            new System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"),
            new System.Data.SqlClient.SqlParameter("@Adresse", System.Data.SqlDbType.NVarChar, 0, "Adresse"),
            new System.Data.SqlClient.SqlParameter("@Ville", System.Data.SqlDbType.NVarChar, 0, "Ville"),
            new System.Data.SqlClient.SqlParameter("@CodePostal", System.Data.SqlDbType.NVarChar, 0, "CodePostal"),
            new System.Data.SqlClient.SqlParameter("@Actif", System.Data.SqlDbType.Bit, 0, "Actif")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.cn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.cn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
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
            this.daEntreprise.DeleteCommand = this.sqlDeleteCommand2;
            this.daEntreprise.InsertCommand = this.sqlInsertCommand2;
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
            this.daEntreprise.UpdateCommand = this.sqlUpdateCommand2;
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
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT   Id, Nom, Telephone, Email, Adresse, Ville, CodePostal, Actif\r\nFROM      " +
    "   Entreprise\r\nWHERE     (Id = @NoEntreprise)";
            this.sqlSelectCommand3.Connection = this.cn;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@NoEntreprise", System.Data.SqlDbType.Int, 4, "Id")});
            // 
            // dsEntreprise1
            // 
            this.dsEntreprise1.DataSetName = "DSEntreprise";
            this.dsEntreprise1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bRetirer
            // 
            this.bRetirer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bRetirer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bRetirer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bRetirer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bRetirer.ForeColor = System.Drawing.Color.White;
            this.bRetirer.Location = new System.Drawing.Point(542, 310);
            this.bRetirer.Name = "bRetirer";
            this.bRetirer.Size = new System.Drawing.Size(94, 24);
            this.bRetirer.TabIndex = 41;
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
            this.bModifier.Location = new System.Drawing.Point(542, 361);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(94, 24);
            this.bModifier.TabIndex = 42;
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
            this.bNouveau.Location = new System.Drawing.Point(542, 262);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(94, 24);
            this.bNouveau.TabIndex = 43;
            this.bNouveau.Text = "Nouveau";
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
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
            this.dgEntreprise.Location = new System.Drawing.Point(125, 105);
            this.dgEntreprise.MultiSelect = false;
            this.dgEntreprise.Name = "dgEntreprise";
            this.dgEntreprise.ReadOnly = true;
            this.dgEntreprise.RowHeadersVisible = false;
            this.dgEntreprise.Size = new System.Drawing.Size(853, 40);
            this.dgEntreprise.TabIndex = 44;
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
            // dgEntrevue
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgEntrevue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgEntrevue.AutoGenerateColumns = false;
            this.dgEntrevue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEntrevue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgEntrevue.ColumnHeadersHeight = 15;
            this.dgEntrevue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgEntrevue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.entrepriseIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn});
            this.dgEntrevue.DataSource = this.BSEntrevue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEntrevue.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgEntrevue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntrevue.Location = new System.Drawing.Point(697, 186);
            this.dgEntrevue.MultiSelect = false;
            this.dgEntrevue.Name = "dgEntrevue";
            this.dgEntrevue.ReadOnly = true;
            this.dgEntrevue.RowHeadersVisible = false;
            this.dgEntrevue.Size = new System.Drawing.Size(378, 250);
            this.dgEntrevue.TabIndex = 45;
            this.dgEntrevue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgEntrevue.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgEntrevue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgEntrevue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgEntrevue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgEntrevue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgEntrevue.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntrevue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgEntrevue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEntrevue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEntrevue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgEntrevue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgEntrevue.ThemeStyle.HeaderStyle.Height = 15;
            this.dgEntrevue.ThemeStyle.ReadOnly = true;
            this.dgEntrevue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgEntrevue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEntrevue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgEntrevue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgEntrevue.ThemeStyle.RowsStyle.Height = 22;
            this.dgEntrevue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgEntrevue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgEntrevue.SelectionChanged += new System.EventHandler(this.dgEntrevue_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // entrepriseIdDataGridViewTextBoxColumn
            // 
            this.entrepriseIdDataGridViewTextBoxColumn.DataPropertyName = "EntrepriseId";
            this.entrepriseIdDataGridViewTextBoxColumn.HeaderText = "EntrepriseId";
            this.entrepriseIdDataGridViewTextBoxColumn.Name = "entrepriseIdDataGridViewTextBoxColumn";
            this.entrepriseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.entrepriseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "Heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "Heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gbChoix
            // 
            this.gbChoix.Controls.Add(this.btnFirst);
            this.gbChoix.Controls.Add(this.btnDernier);
            this.gbChoix.Controls.Add(this.btnNext);
            this.gbChoix.Controls.Add(this.txtEmplacement);
            this.gbChoix.Controls.Add(this.btnBack);
            this.gbChoix.Location = new System.Drawing.Point(267, 490);
            this.gbChoix.Name = "gbChoix";
            this.gbChoix.Size = new System.Drawing.Size(574, 40);
            this.gbChoix.TabIndex = 46;
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
            // FrmEntrevue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 588);
            this.Controls.Add(this.gbChoix);
            this.Controls.Add(this.dgEntrevue);
            this.Controls.Add(this.dgEntreprise);
            this.Controls.Add(this.bRetirer);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.grEntrevue);
            this.Controls.Add(this.lblEntrevue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEntrevue";
            this.Text = "FrmEntrevue";
            this.Load += new System.EventHandler(this.FrmEntrevue_Load);
            this.grEntrevue.ResumeLayout(false);
            this.grEntrevue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSEntrevue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntrevue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEntreprise1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrevue)).EndInit();
            this.gbChoix.ResumeLayout(false);
            this.gbChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrevue;
        private System.Windows.Forms.GroupBox grEntrevue;
        private Guna.UI2.WinForms.Guna2Button bAnnuler;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.ComboBox cboEntreprise;
        private Guna.UI2.WinForms.Guna2Button bConfirmer;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.Label lblHeure;
        internal System.Windows.Forms.Label lblDateEnvoie;
        internal System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.DateTimePicker dtDateEnvoie;
        internal System.Windows.Forms.MaskedTextBox mskHeure;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daEntrevue;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daEntreprise;
        private System.Windows.Forms.BindingSource BSEntrevue;
        private DSEntrevue dsEntrevue1;
        private System.Data.SqlClient.SqlDataAdapter daEntrepriseDg;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private DSEntreprise dsEntreprise1;
        private Guna.UI2.WinForms.Guna2Button bRetirer;
        private Guna.UI2.WinForms.Guna2Button bModifier;
        private Guna.UI2.WinForms.Guna2Button bNouveau;
        private Guna.UI2.WinForms.Guna2DataGridView dgEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actifDataGridViewCheckBoxColumn;
        private Guna.UI2.WinForms.Guna2DataGridView dgEntrevue;
        internal System.Windows.Forms.GroupBox gbChoix;
        internal System.Windows.Forms.Button btnFirst;
        internal System.Windows.Forms.Button btnDernier;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.TextBox txtEmplacement;
        internal System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrepriseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
    }
}