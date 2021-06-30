using System;

namespace Comercialon
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.clnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDadosEnderecos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cpf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefone";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Location = new System.Drawing.Point(69, 15);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(42, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Location = new System.Drawing.Point(69, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Location = new System.Drawing.Point(69, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Location = new System.Drawing.Point(69, 119);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAtivo.Location = new System.Drawing.Point(219, 18);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 3;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // mskCpf
            // 
            this.mskCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskCpf.Location = new System.Drawing.Point(69, 67);
            this.mskCpf.Mask = "000.000.000.00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.mskCpf);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificação";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtUF);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.mskCEP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CBTipo);
            this.groupBox2.Location = new System.Drawing.Point(356, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereços";
            // 
            // txtBairro
            // 
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Location = new System.Drawing.Point(85, 132);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(184, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // txtEstado
            // 
            this.txtEstado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstado.Location = new System.Drawing.Point(117, 180);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(118, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Estado";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(223, 180);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(46, 20);
            this.txtUF.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Location = new System.Drawing.Point(14, 180);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 6;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemento.Location = new System.Drawing.Point(11, 132);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(68, 20);
            this.txtComplemento.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.Location = new System.Drawing.Point(205, 81);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // mskCEP
            // 
            this.mskCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskCEP.Location = new System.Drawing.Point(137, 33);
            this.mskCEP.Mask = "000000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 20);
            this.mskCEP.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogradouro.Location = new System.Drawing.Point(11, 81);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(187, 20);
            this.txtLogradouro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo";
            // 
            // CBTipo
            // 
            this.CBTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Entrega",
            "Cobrança"});
            this.CBTipo.Location = new System.Drawing.Point(11, 32);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(119, 21);
            this.CBTipo.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Location = new System.Drawing.Point(97, 192);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(187, 192);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "&Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(279, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnTelefone,
            this.clnAtivo});
            this.dgvClientes.Location = new System.Drawing.Point(4, 241);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(550, 150);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 150;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 90;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 140;
            // 
            // clnTelefone
            // 
            this.clnTelefone.Frozen = true;
            this.clnTelefone.HeaderText = "Telefone";
            this.clnTelefone.Name = "clnTelefone";
            this.clnTelefone.ReadOnly = true;
            this.clnTelefone.Width = 90;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.Width = 40;
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.Image = global::Comercialon.Properties.Resources.Add;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInserir.Location = new System.Drawing.Point(6, 180);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 44);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTipo,
            this.clnCEP,
            this.clnDadosEnderecos});
            this.dgvEndereco.Location = new System.Drawing.Point(4, 397);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.RowHeadersVisible = false;
            this.dgvEndereco.Size = new System.Drawing.Size(550, 90);
            this.dgvEndereco.TabIndex = 8;
            // 
            // clnTipo
            // 
            this.clnTipo.Frozen = true;
            this.clnTipo.HeaderText = "Tipo";
            this.clnTipo.Name = "clnTipo";
            this.clnTipo.ReadOnly = true;
            this.clnTipo.Width = 80;
            // 
            // clnCEP
            // 
            this.clnCEP.Frozen = true;
            this.clnCEP.HeaderText = "CEP";
            this.clnCEP.Name = "clnCEP";
            this.clnCEP.ReadOnly = true;
            this.clnCEP.Width = 80;
            // 
            // clnDadosEnderecos
            // 
            this.clnDadosEnderecos.Frozen = true;
            this.clnDadosEnderecos.HeaderText = "Endereços";
            this.clnDadosEnderecos.Name = "clnDadosEnderecos";
            this.clnDadosEnderecos.ReadOnly = true;
            this.clnDadosEnderecos.Width = 480;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 511);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInserir);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTelefone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDadosEnderecos;
    }
}