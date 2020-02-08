namespace PrincessPasswordKeeper
{
    partial class frmNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPassword));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewPassword = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChars = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRandom = new System.Windows.Forms.TabPage();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericPassLenght = new System.Windows.Forms.NumericUpDown();
            this.cbLowerCasing = new System.Windows.Forms.CheckBox();
            this.cbUpperCasing = new System.Windows.Forms.CheckBox();
            this.cbSpecialChar = new System.Windows.Forms.CheckBox();
            this.cbNumbers = new System.Windows.Forms.CheckBox();
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.passwordKeeperDataSet = new PrincessPasswordKeeper.PasswordKeeperDataSet();
            this.senhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhasTableAdapter = new PrincessPasswordKeeper.PasswordKeeperDataSetTableAdapters.senhasTableAdapter();
            this.tableAdapterManager = new PrincessPasswordKeeper.PasswordKeeperDataSetTableAdapters.TableAdapterManager();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1.SuspendLayout();
            this.tabNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordKeeperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNewPassword);
            this.tabControl1.Controls.Add(this.tabRandom);
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 415);
            this.tabControl1.TabIndex = 1;
            // 
            // tabNewPassword
            // 
            this.tabNewPassword.Controls.Add(this.pictureBox3);
            this.tabNewPassword.Controls.Add(this.btnUpdate);
            this.tabNewPassword.Controls.Add(this.label7);
            this.tabNewPassword.Controls.Add(this.lblChars);
            this.tabNewPassword.Controls.Add(this.btnSave);
            this.tabNewPassword.Controls.Add(this.cmbType);
            this.tabNewPassword.Controls.Add(this.label6);
            this.tabNewPassword.Controls.Add(this.txtUser);
            this.tabNewPassword.Controls.Add(this.label3);
            this.tabNewPassword.Controls.Add(this.txtNotes);
            this.tabNewPassword.Controls.Add(this.label2);
            this.tabNewPassword.Controls.Add(this.txtPassword);
            this.tabNewPassword.Controls.Add(this.label1);
            this.tabNewPassword.Location = new System.Drawing.Point(4, 28);
            this.tabNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tabNewPassword.Name = "tabNewPassword";
            this.tabNewPassword.Padding = new System.Windows.Forms.Padding(4);
            this.tabNewPassword.Size = new System.Drawing.Size(321, 383);
            this.tabNewPassword.TabIndex = 0;
            this.tabNewPassword.Text = "Nova Senha";
            this.tabNewPassword.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(9, 319);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(92, 331);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "char:";
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Location = new System.Drawing.Point(292, 214);
            this.lblChars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(17, 19);
            this.lblChars.TabIndex = 10;
            this.lblChars.Text = "  ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 286);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Gmail",
            "Facebook",
            "Netflix",
            "NuBank"});
            this.cmbType.Location = new System.Drawing.Point(93, 13);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(216, 27);
            this.cmbType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tipo:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(93, 53);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(216, 27);
            this.txtUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(93, 134);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.MaxLength = 50;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(216, 76);
            this.txtNotes.TabIndex = 4;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notas:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 91);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha:";
            // 
            // tabRandom
            // 
            this.tabRandom.Controls.Add(this.btnCopy);
            this.tabRandom.Controls.Add(this.btnGenerate);
            this.tabRandom.Controls.Add(this.pictureBox1);
            this.tabRandom.Controls.Add(this.numericPassLenght);
            this.tabRandom.Controls.Add(this.cbLowerCasing);
            this.tabRandom.Controls.Add(this.cbUpperCasing);
            this.tabRandom.Controls.Add(this.cbSpecialChar);
            this.tabRandom.Controls.Add(this.cbNumbers);
            this.tabRandom.Controls.Add(this.txtGeneratedPassword);
            this.tabRandom.Controls.Add(this.label4);
            this.tabRandom.Location = new System.Drawing.Point(4, 28);
            this.tabRandom.Margin = new System.Windows.Forms.Padding(4);
            this.tabRandom.Name = "tabRandom";
            this.tabRandom.Padding = new System.Windows.Forms.Padding(4);
            this.tabRandom.Size = new System.Drawing.Size(321, 383);
            this.tabRandom.TabIndex = 1;
            this.tabRandom.Text = "Gerar Senha Aleatória";
            this.tabRandom.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(13, 335);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(295, 37);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copiar para Nova Senha";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(60, 182);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(193, 37);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Gerar Senha";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 227);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // numericPassLenght
            // 
            this.numericPassLenght.Location = new System.Drawing.Point(92, 15);
            this.numericPassLenght.Margin = new System.Windows.Forms.Padding(4);
            this.numericPassLenght.Name = "numericPassLenght";
            this.numericPassLenght.Size = new System.Drawing.Size(44, 27);
            this.numericPassLenght.TabIndex = 1;
            this.numericPassLenght.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cbLowerCasing
            // 
            this.cbLowerCasing.AutoSize = true;
            this.cbLowerCasing.Checked = true;
            this.cbLowerCasing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLowerCasing.Location = new System.Drawing.Point(15, 151);
            this.cbLowerCasing.Margin = new System.Windows.Forms.Padding(4);
            this.cbLowerCasing.Name = "cbLowerCasing";
            this.cbLowerCasing.Size = new System.Drawing.Size(104, 23);
            this.cbLowerCasing.TabIndex = 5;
            this.cbLowerCasing.Text = "Caixa Baixa";
            this.cbLowerCasing.UseVisualStyleBackColor = true;
            // 
            // cbUpperCasing
            // 
            this.cbUpperCasing.AutoSize = true;
            this.cbUpperCasing.Checked = true;
            this.cbUpperCasing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperCasing.Location = new System.Drawing.Point(15, 117);
            this.cbUpperCasing.Margin = new System.Windows.Forms.Padding(4);
            this.cbUpperCasing.Name = "cbUpperCasing";
            this.cbUpperCasing.Size = new System.Drawing.Size(94, 23);
            this.cbUpperCasing.TabIndex = 4;
            this.cbUpperCasing.Text = "Caixa Alta";
            this.cbUpperCasing.UseVisualStyleBackColor = true;
            // 
            // cbSpecialChar
            // 
            this.cbSpecialChar.AutoSize = true;
            this.cbSpecialChar.Checked = true;
            this.cbSpecialChar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSpecialChar.Location = new System.Drawing.Point(15, 84);
            this.cbSpecialChar.Margin = new System.Windows.Forms.Padding(4);
            this.cbSpecialChar.Name = "cbSpecialChar";
            this.cbSpecialChar.Size = new System.Drawing.Size(223, 23);
            this.cbSpecialChar.TabIndex = 3;
            this.cbSpecialChar.Text = "Caracteres Especiais (!@#$%)";
            this.cbSpecialChar.UseVisualStyleBackColor = true;
            // 
            // cbNumbers
            // 
            this.cbNumbers.AutoSize = true;
            this.cbNumbers.Checked = true;
            this.cbNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNumbers.Location = new System.Drawing.Point(15, 50);
            this.cbNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(121, 23);
            this.cbNumbers.TabIndex = 2;
            this.cbNumbers.Text = "Números (0-9)";
            this.cbNumbers.UseVisualStyleBackColor = true;
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedPassword.Location = new System.Drawing.Point(13, 300);
            this.txtGeneratedPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(293, 27);
            this.txtGeneratedPassword.TabIndex = 7;
            this.txtGeneratedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamanho:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(950, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(70, 17);
            this.tssStatus.Text = "                     ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxtSearch,
            this.tsbSearch,
            this.toolStripSeparator1,
            this.tsbDelete,
            this.toolStripSeparator2,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(121, 24);
            this.toolStripLabel1.Text = "Buscar por Login:";
            // 
            // tstxtSearch
            // 
            this.tstxtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(132, 27);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 24);
            this.tsbSearch.Text = "Buscar";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Enabled = false;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 24);
            this.tsbDelete.Text = "Apagar";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // passwordKeeperDataSet
            // 
            this.passwordKeeperDataSet.DataSetName = "PasswordKeeperDataSet";
            this.passwordKeeperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // senhasBindingSource
            // 
            this.senhasBindingSource.DataMember = "senhas";
            this.senhasBindingSource.DataSource = this.passwordKeeperDataSet;
            // 
            // senhasTableAdapter
            // 
            this.senhasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.senhasTableAdapter = this.senhasTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrincessPasswordKeeper.PasswordKeeperDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvList.DataSource = this.senhasBindingSource;
            this.dgvList.Location = new System.Drawing.Point(337, 73);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(666, 383);
            this.dgvList.TabIndex = 16;
            this.dgvList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "TIPO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "LOGIN";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 76;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "senha";
            this.dataGridViewTextBoxColumn4.HeaderText = "SENHA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "notas";
            this.dataGridViewTextBoxColumn5.HeaderText = "NOTAS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 24);
            this.tsbRefresh.Text = "Atualizar";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // frmNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Senha";
            this.Load += new System.EventHandler(this.frmNewPassword_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNewPassword.ResumeLayout(false);
            this.tabNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabRandom.ResumeLayout(false);
            this.tabRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordKeeperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewPassword;
        private System.Windows.Forms.TabPage tabRandom;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUpperCasing;
        private System.Windows.Forms.CheckBox cbSpecialChar;
        private System.Windows.Forms.CheckBox cbNumbers;
        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericPassLenght;
        private System.Windows.Forms.CheckBox cbLowerCasing;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblChars;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Button btnUpdate;
        private PasswordKeeperDataSet passwordKeeperDataSet;
        private System.Windows.Forms.BindingSource senhasBindingSource;
        private PasswordKeeperDataSetTableAdapters.senhasTableAdapter senhasTableAdapter;
        private PasswordKeeperDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
    }
}