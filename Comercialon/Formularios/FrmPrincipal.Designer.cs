namespace Comercialon.Formularios
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmCadrastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadrastrosCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadrastoProdutosNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadrastoProdutosLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadrastoUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOperacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadrastro,
            this.tsmOperacoes,
            this.tsmMovimento,
            this.tsmRelatorio,
            this.tsmConfiguracoes,
            this.tsmAjuda});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1176, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsmCadrastro
            // 
            this.tsmCadrastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadrastrosCliente,
            this.tsmProdutos,
            this.tsmCadrastoUsuario});
            this.tsmCadrastro.Name = "tsmCadrastro";
            this.tsmCadrastro.Size = new System.Drawing.Size(75, 20);
            this.tsmCadrastro.Text = "&Cadrastros";
            // 
            // tsmCadrastrosCliente
            // 
            this.tsmCadrastrosCliente.Name = "tsmCadrastrosCliente";
            this.tsmCadrastrosCliente.Size = new System.Drawing.Size(180, 22);
            this.tsmCadrastrosCliente.Text = "&Clientes";
            this.tsmCadrastrosCliente.Click += new System.EventHandler(this.tsmCadrastrosCliente_Click);
            // 
            // tsmProdutos
            // 
            this.tsmProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadrastoProdutosNovo,
            this.tsmCadrastoProdutosLista});
            this.tsmProdutos.Name = "tsmProdutos";
            this.tsmProdutos.Size = new System.Drawing.Size(180, 22);
            this.tsmProdutos.Text = "&Produtos";
            // 
            // tsmCadrastoProdutosNovo
            // 
            this.tsmCadrastoProdutosNovo.Name = "tsmCadrastoProdutosNovo";
            this.tsmCadrastoProdutosNovo.Size = new System.Drawing.Size(103, 22);
            this.tsmCadrastoProdutosNovo.Text = "&Novo";
            this.tsmCadrastoProdutosNovo.Click += new System.EventHandler(this.tsmCadrastoProdutosNovo_Click);
            // 
            // tsmCadrastoProdutosLista
            // 
            this.tsmCadrastoProdutosLista.Name = "tsmCadrastoProdutosLista";
            this.tsmCadrastoProdutosLista.Size = new System.Drawing.Size(103, 22);
            this.tsmCadrastoProdutosLista.Text = "&Lista";
            // 
            // tsmCadrastoUsuario
            // 
            this.tsmCadrastoUsuario.Name = "tsmCadrastoUsuario";
            this.tsmCadrastoUsuario.Size = new System.Drawing.Size(180, 22);
            this.tsmCadrastoUsuario.Text = "&Usuário";
            this.tsmCadrastoUsuario.Click += new System.EventHandler(this.tsmCadrastoUsuario_Click);
            // 
            // tsmOperacoes
            // 
            this.tsmOperacoes.Name = "tsmOperacoes";
            this.tsmOperacoes.Size = new System.Drawing.Size(75, 20);
            this.tsmOperacoes.Text = "&Operações";
            // 
            // tsmMovimento
            // 
            this.tsmMovimento.Name = "tsmMovimento";
            this.tsmMovimento.Size = new System.Drawing.Size(81, 20);
            this.tsmMovimento.Text = "&Movimento";
            // 
            // tsmRelatorio
            // 
            this.tsmRelatorio.Name = "tsmRelatorio";
            this.tsmRelatorio.Size = new System.Drawing.Size(71, 20);
            this.tsmRelatorio.Text = "&Relatórios";
            // 
            // tsmConfiguracoes
            // 
            this.tsmConfiguracoes.Name = "tsmConfiguracoes";
            this.tsmConfiguracoes.Size = new System.Drawing.Size(96, 20);
            this.tsmConfiguracoes.Text = "Con&figurações";
            // 
            // tsmAjuda
            // 
            this.tsmAjuda.Name = "tsmAjuda";
            this.tsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.tsmAjuda.Text = "&Ajuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 469);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCadrastro;
        private System.Windows.Forms.ToolStripMenuItem tsmOperacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmMovimento;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem tsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadrastrosCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmCadrastoProdutosNovo;
        private System.Windows.Forms.ToolStripMenuItem tsmCadrastoProdutosLista;
        private System.Windows.Forms.ToolStripMenuItem tsmCadrastoUsuario;
    }
}