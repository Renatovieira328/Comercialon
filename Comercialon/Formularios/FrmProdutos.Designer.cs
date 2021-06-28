namespace Comercialon.Formularios
{
    partial class FrmProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarcaName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarcaSigla = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCatSigla = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarcaName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMarcaSigla);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Location = new System.Drawing.Point(146, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // txtMarcaName
            // 
            this.txtMarcaName.Location = new System.Drawing.Point(6, 38);
            this.txtMarcaName.Name = "txtMarcaName";
            this.txtMarcaName.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sigla";
            // 
            // txtMarcaSigla
            // 
            this.txtMarcaSigla.Location = new System.Drawing.Point(6, 89);
            this.txtMarcaSigla.Name = "txtMarcaSigla";
            this.txtMarcaSigla.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaSigla.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(6, 16);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 7;
            this.Nome.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCatSigla);
            this.groupBox2.Controls.Add(this.txtCatName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias";
            // 
            // txtCatSigla
            // 
            this.txtCatSigla.Location = new System.Drawing.Point(6, 89);
            this.txtCatSigla.Name = "txtCatSigla";
            this.txtCatSigla.Size = new System.Drawing.Size(100, 20);
            this.txtCatSigla.TabIndex = 1;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(6, 38);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(100, 20);
            this.txtCatName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Image = global::Comercialon.Properties.Resources.Add;
            this.buttonAdd.Location = new System.Drawing.Point(12, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 49);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "&Adicionar";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // BTAlterar
            // 
            this.BTAlterar.Image = global::Comercialon.Properties.Resources.Edit;
            this.BTAlterar.Location = new System.Drawing.Point(124, 135);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(80, 49);
            this.BTAlterar.TabIndex = 2;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTAlterar.UseVisualStyleBackColor = true;
            this.BTAlterar.Click += new System.EventHandler(this.BTAlterar_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 201);
            this.Controls.Add(this.BTAlterar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarcaSigla;
        private System.Windows.Forms.TextBox txtMarcaName;
        private System.Windows.Forms.TextBox txtCatSigla;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.Label Nome;
    }
}