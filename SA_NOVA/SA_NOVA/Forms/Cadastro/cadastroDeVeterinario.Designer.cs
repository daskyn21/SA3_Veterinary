﻿
namespace SA_NOVA
{
    partial class cadastroDeVeterinario
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
            System.Windows.Forms.Label idClientesLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label insercaoLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbImagemCliente = new System.Windows.Forms.PictureBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.idVeterinarioTextBox = new System.Windows.Forms.TextBox();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdVeterinariaDataSet = new SA_NOVA.bdVeterinariaDataSet();
            this.tableAdapterManager = new SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager();
            this.tbClientesTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.crmvTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataInsercao = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.gridViewVeterinario = new System.Windows.Forms.DataGridView();
            this.idVeterinarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocrmvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainsercaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbVeterinarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVeterinarioTableAdapter = new SA_NOVA.bdVeterinariaDataSetTableAdapters.tbVeterinarioTableAdapter();
            idClientesLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            insercaoLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeterinarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idClientesLabel
            // 
            idClientesLabel.AutoSize = true;
            idClientesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            idClientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClientesLabel.Location = new System.Drawing.Point(25, 150);
            idClientesLabel.Name = "idClientesLabel";
            idClientesLabel.Size = new System.Drawing.Size(76, 24);
            idClientesLabel.TabIndex = 31;
            idClientesLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nomeLabel.Location = new System.Drawing.Point(25, 189);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(67, 24);
            nomeLabel.TabIndex = 33;
            nomeLabel.Text = "Nome:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            data_nascimentoLabel.Location = new System.Drawing.Point(25, 246);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(100, 24);
            data_nascimentoLabel.TabIndex = 35;
            data_nascimentoLabel.Text = "Data Nasc.";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            telefoneLabel.Location = new System.Drawing.Point(25, 289);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(90, 24);
            telefoneLabel.TabIndex = 37;
            telefoneLabel.Text = "Telefone:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sexoLabel.Location = new System.Drawing.Point(434, 289);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(59, 24);
            sexoLabel.TabIndex = 39;
            sexoLabel.Text = "Sexo:";
            // 
            // insercaoLabel
            // 
            insercaoLabel.AutoSize = true;
            insercaoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            insercaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            insercaoLabel.Location = new System.Drawing.Point(434, 246);
            insercaoLabel.Name = "insercaoLabel";
            insercaoLabel.Size = new System.Drawing.Size(87, 24);
            insercaoLabel.TabIndex = 41;
            insercaoLabel.Text = "Inserção:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            rgLabel.Location = new System.Drawing.Point(25, 349);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(52, 24);
            rgLabel.TabIndex = 43;
            rgLabel.Text = "CPF:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cpfLabel.Location = new System.Drawing.Point(25, 389);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(70, 24);
            cpfLabel.TabIndex = 45;
            cpfLabel.Text = "CRMV:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            emailLabel.Location = new System.Drawing.Point(25, 571);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 24);
            emailLabel.TabIndex = 49;
            emailLabel.Text = "E-mail:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            enderecoLabel.Location = new System.Drawing.Point(25, 440);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(99, 24);
            enderecoLabel.TabIndex = 47;
            enderecoLabel.Text = "Endereço:";
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCancelar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbCancelar.Location = new System.Drawing.Point(165, 26);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(80, 20);
            this.lbCancelar.TabIndex = 59;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastro.Location = new System.Drawing.Point(1, 84);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(239, 25);
            this.lbCadastro.TabIndex = 56;
            this.lbCadastro.Text = "Cadastro de Veterinario";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(804, 237);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(65, 32);
            this.lbSize.TabIndex = 55;
            this.lbSize.Text = "SIZE:\r\n158X193";
            this.lbSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(6, 16);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(132, 41);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar (F2)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbImagemCliente
            // 
            this.pbImagemCliente.Location = new System.Drawing.Point(758, 141);
            this.pbImagemCliente.Name = "pbImagemCliente";
            this.pbImagemCliente.Size = new System.Drawing.Size(158, 193);
            this.pbImagemCliente.TabIndex = 53;
            this.pbImagemCliente.TabStop = false;
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarImagem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionarImagem.Location = new System.Drawing.Point(758, 340);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(158, 33);
            this.btnAdicionarImagem.TabIndex = 52;
            this.btnAdicionarImagem.Text = "Selecionar Imagem";
            this.btnAdicionarImagem.UseVisualStyleBackColor = false;
            // 
            // idVeterinarioTextBox
            // 
            this.idVeterinarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "idClientes", true));
            this.idVeterinarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idVeterinarioTextBox.Location = new System.Drawing.Point(129, 141);
            this.idVeterinarioTextBox.Multiline = true;
            this.idVeterinarioTextBox.Name = "idVeterinarioTextBox";
            this.idVeterinarioTextBox.Size = new System.Drawing.Size(146, 33);
            this.idVeterinarioTextBox.TabIndex = 32;
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // bdVeterinariaDataSet
            // 
            this.bdVeterinariaDataSet.DataSetName = "bdVeterinariaDataSet";
            this.bdVeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbAnimaisTableAdapter = null;
            this.tableAdapterManager.tbClientesTableAdapter = this.tbClientesTableAdapter;
            this.tableAdapterManager.tbConsultasTableAdapter = null;
            this.tableAdapterManager.tbLoginTableAdapter = null;
            this.tableAdapterManager.tbVeterinarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SA_NOVA.bdVeterinariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbClientesTableAdapter
            // 
            this.tbClientesTableAdapter.ClearBeforeFill = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nomeTextBox.Location = new System.Drawing.Point(129, 180);
            this.nomeTextBox.Multiline = true;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(585, 33);
            this.nomeTextBox.TabIndex = 34;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbClientesBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(129, 235);
            this.data_nascimentoDateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(238, 34);
            this.data_nascimentoDateTimePicker.TabIndex = 36;
            this.data_nascimentoDateTimePicker.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.telefoneTextBox.Location = new System.Drawing.Point(129, 280);
            this.telefoneTextBox.Multiline = true;
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(237, 33);
            this.telefoneTextBox.TabIndex = 38;
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "celular", true));
            this.celularTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.celularTextBox.Location = new System.Drawing.Point(525, 280);
            this.celularTextBox.Multiline = true;
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(189, 33);
            this.celularTextBox.TabIndex = 40;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "rg", true));
            this.cpfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cpfTextBox.Location = new System.Drawing.Point(129, 340);
            this.cpfTextBox.Multiline = true;
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(237, 33);
            this.cpfTextBox.TabIndex = 44;
            // 
            // crmvTextBox
            // 
            this.crmvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "cpf", true));
            this.crmvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.crmvTextBox.Location = new System.Drawing.Point(129, 380);
            this.crmvTextBox.Multiline = true;
            this.crmvTextBox.Name = "crmvTextBox";
            this.crmvTextBox.Size = new System.Drawing.Size(238, 33);
            this.crmvTextBox.TabIndex = 46;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "endereco", true));
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.enderecoTextBox.Location = new System.Drawing.Point(129, 440);
            this.enderecoTextBox.Multiline = true;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(464, 98);
            this.enderecoTextBox.TabIndex = 48;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClientesBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailTextBox.Location = new System.Drawing.Point(129, 562);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(464, 33);
            this.emailTextBox.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA_NOVA.Properties.Resources.utility;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(988, 648);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // dataInsercao
            // 
            this.dataInsercao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInsercao.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbClientesBindingSource, "data_nascimento", true));
            this.dataInsercao.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInsercao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInsercao.Location = new System.Drawing.Point(525, 242);
            this.dataInsercao.Margin = new System.Windows.Forms.Padding(1);
            this.dataInsercao.Name = "dataInsercao";
            this.dataInsercao.Size = new System.Drawing.Size(189, 34);
            this.dataInsercao.TabIndex = 60;
            this.dataInsercao.Value = new System.DateTime(2020, 12, 17, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(616, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 33);
            this.button1.TabIndex = 61;
            this.button1.Text = "Veterinarios Cadastros";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gridViewVeterinario
            // 
            this.gridViewVeterinario.AutoGenerateColumns = false;
            this.gridViewVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVeterinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVeterinarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numerocrmvDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datainsercaoDataGridViewTextBoxColumn});
            this.gridViewVeterinario.DataSource = this.tbVeterinarioBindingSource;
            this.gridViewVeterinario.Location = new System.Drawing.Point(616, 473);
            this.gridViewVeterinario.Name = "gridViewVeterinario";
            this.gridViewVeterinario.Size = new System.Drawing.Size(300, 122);
            this.gridViewVeterinario.TabIndex = 62;
            // 
            // idVeterinarioDataGridViewTextBoxColumn
            // 
            this.idVeterinarioDataGridViewTextBoxColumn.DataPropertyName = "idVeterinario";
            this.idVeterinarioDataGridViewTextBoxColumn.HeaderText = "idVeterinario";
            this.idVeterinarioDataGridViewTextBoxColumn.Name = "idVeterinarioDataGridViewTextBoxColumn";
            this.idVeterinarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // numerocrmvDataGridViewTextBoxColumn
            // 
            this.numerocrmvDataGridViewTextBoxColumn.DataPropertyName = "numerocrmv";
            this.numerocrmvDataGridViewTextBoxColumn.HeaderText = "numerocrmv";
            this.numerocrmvDataGridViewTextBoxColumn.Name = "numerocrmvDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // datainsercaoDataGridViewTextBoxColumn
            // 
            this.datainsercaoDataGridViewTextBoxColumn.DataPropertyName = "datainsercao";
            this.datainsercaoDataGridViewTextBoxColumn.HeaderText = "datainsercao";
            this.datainsercaoDataGridViewTextBoxColumn.Name = "datainsercaoDataGridViewTextBoxColumn";
            // 
            // tbVeterinarioBindingSource
            // 
            this.tbVeterinarioBindingSource.DataMember = "tbVeterinario";
            this.tbVeterinarioBindingSource.DataSource = this.bdVeterinariaDataSet;
            // 
            // tbVeterinarioTableAdapter
            // 
            this.tbVeterinarioTableAdapter.ClearBeforeFill = true;
            // 
            // cadastroDeVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridViewVeterinario);
            this.Controls.Add(this.dataInsercao);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbImagemCliente);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(idClientesLabel);
            this.Controls.Add(this.idVeterinarioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(insercaoLabel);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.crmvTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadastroDeVeterinario";
            this.Text = "cadastroDeVeterinario";
            this.Load += new System.EventHandler(this.cadastroDeVeterinario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdVeterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeterinarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pbImagemCliente;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.TextBox idVeterinarioTextBox;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private bdVeterinariaDataSet bdVeterinariaDataSet;
        private bdVeterinariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private bdVeterinariaDataSetTableAdapters.tbClientesTableAdapter tbClientesTableAdapter;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox crmvTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dataInsercao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridViewVeterinario;
        private System.Windows.Forms.BindingSource tbVeterinarioBindingSource;
        private bdVeterinariaDataSetTableAdapters.tbVeterinarioTableAdapter tbVeterinarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVeterinarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocrmvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainsercaoDataGridViewTextBoxColumn;
    }
}