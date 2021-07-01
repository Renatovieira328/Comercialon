namespace Comercialon.Formularios
{
    partial class FrmUsuarios
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
            this.CbNivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CkbAtivo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXBNome = new System.Windows.Forms.TextBox();
            this.TXBEmail = new System.Windows.Forms.TextBox();
            this.TXBSenha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MskCPF = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxBID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbNivel
            // 
            this.CbNivel.FormattingEnabled = true;
            this.CbNivel.Items.AddRange(new object[] {
            "Administrador",
            "Nivel 1",
            "Nivel 2",
            "Nivel 3"});
            this.CbNivel.Location = new System.Drawing.Point(190, 84);
            this.CbNivel.Name = "CbNivel";
            this.CbNivel.Size = new System.Drawing.Size(121, 21);
            this.CbNivel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nivel";
            // 
            // CkbAtivo
            // 
            this.CkbAtivo.AutoSize = true;
            this.CkbAtivo.Location = new System.Drawing.Point(131, 16);
            this.CkbAtivo.Name = "CkbAtivo";
            this.CkbAtivo.Size = new System.Drawing.Size(50, 17);
            this.CkbAtivo.TabIndex = 7;
            this.CkbAtivo.Text = "Ativo";
            this.CkbAtivo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CPF";
            // 
            // TXBNome
            // 
            this.TXBNome.Location = new System.Drawing.Point(6, 36);
            this.TXBNome.Name = "TXBNome";
            this.TXBNome.Size = new System.Drawing.Size(152, 20);
            this.TXBNome.TabIndex = 9;
            // 
            // TXBEmail
            // 
            this.TXBEmail.Location = new System.Drawing.Point(6, 83);
            this.TXBEmail.Name = "TXBEmail";
            this.TXBEmail.Size = new System.Drawing.Size(152, 20);
            this.TXBEmail.TabIndex = 10;
            // 
            // TXBSenha
            // 
            this.TXBSenha.Location = new System.Drawing.Point(6, 130);
            this.TXBSenha.Name = "TXBSenha";
            this.TXBSenha.Size = new System.Drawing.Size(152, 20);
            this.TXBSenha.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.TxBID);
            this.groupBox1.Controls.Add(this.MskCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CkbAtivo);
            this.groupBox1.Controls.Add(this.TXBNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXBSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbNivel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXBEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 206);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // MskCPF
            // 
            this.MskCPF.Location = new System.Drawing.Point(190, 130);
            this.MskCPF.Mask = "000-000-000-00";
            this.MskCPF.Name = "MskCPF";
            this.MskCPF.Size = new System.Drawing.Size(100, 20);
            this.MskCPF.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(190, 20);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(18, 13);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "ID";
            // 
            // TxBID
            // 
            this.TxBID.Location = new System.Drawing.Point(190, 39);
            this.TxBID.Name = "TxBID";
            this.TxBID.Size = new System.Drawing.Size(43, 20);
            this.TxBID.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "list";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 235);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CbNivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CkbAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXBNome;
        private System.Windows.Forms.TextBox TXBEmail;
        private System.Windows.Forms.TextBox TXBSenha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MskCPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox TxBID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}