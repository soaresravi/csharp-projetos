
namespace projetoAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.email = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.Label();
            this.dataNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.rg = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.telFax = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.uf = new System.Windows.Forms.Label();
            this.txtTelefoneFax = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.txtNascimento);
            this.groupBox1.Controls.Add(this.telefone);
            this.groupBox1.Controls.Add(this.dataNasc);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.btEnviar);
            this.groupBox1.Controls.Add(this.rg);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.celular);
            this.groupBox1.Controls.Add(this.cpf);
            this.groupBox1.Controls.Add(this.telFax);
            this.groupBox1.Controls.Add(this.txtUF);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.uf);
            this.groupBox1.Controls.Add(this.txtTelefoneFax);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.endereco);
            this.groupBox1.Controls.Add(this.cep);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.bairro);
            this.groupBox1.Controls.Add(this.cidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 349);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de cadastro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(9, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(497, 20);
            this.txtEmail.TabIndex = 58;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(536, 26);
            this.pictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(250, 279);
            this.pictureBox.TabIndex = 34;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(11, 292);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 13);
            this.email.TabIndex = 57;
            this.email.Text = "E-MAIL";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(8, 64);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(101, 13);
            this.nome.TabIndex = 31;
            this.nome.Text = "NOME COMPLETO";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(373, 260);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(137, 20);
            this.txtNascimento.TabIndex = 56;
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Location = new System.Drawing.Point(6, 103);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(63, 13);
            this.telefone.TabIndex = 32;
            this.telefone.Text = "TELEFONE";
            // 
            // dataNasc
            // 
            this.dataNasc.AutoSize = true;
            this.dataNasc.Location = new System.Drawing.Point(370, 244);
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(128, 13);
            this.dataNasc.TabIndex = 55;
            this.dataNasc.Text = "DATA DE NASCIMENTO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(500, 20);
            this.txtNome.TabIndex = 33;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(202, 260);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(149, 20);
            this.txtRG.TabIndex = 54;
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(604, 311);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(102, 32);
            this.btEnviar.TabIndex = 35;
            this.btEnviar.Text = "ENVIAR";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Location = new System.Drawing.Point(199, 244);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(23, 13);
            this.rg.TabIndex = 53;
            this.rg.Text = "RG";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(9, 119);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(158, 20);
            this.txtTelefone.TabIndex = 36;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(11, 260);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(174, 20);
            this.txtCPF.TabIndex = 52;
            // 
            // celular
            // 
            this.celular.AutoSize = true;
            this.celular.Location = new System.Drawing.Point(170, 103);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(56, 13);
            this.celular.TabIndex = 37;
            this.celular.Text = "CELULAR";
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Location = new System.Drawing.Point(8, 244);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(27, 13);
            this.cpf.TabIndex = 51;
            this.cpf.Text = "CPF";
            // 
            // telFax
            // 
            this.telFax.AutoSize = true;
            this.telFax.Location = new System.Drawing.Point(343, 103);
            this.telFax.Name = "telFax";
            this.telFax.Size = new System.Drawing.Size(52, 13);
            this.telFax.TabIndex = 38;
            this.telFax.Text = "TEL/FAX";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(417, 208);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(89, 20);
            this.txtUF.TabIndex = 50;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(173, 119);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(162, 20);
            this.txtCelular.TabIndex = 39;
            // 
            // uf
            // 
            this.uf.AutoSize = true;
            this.uf.Location = new System.Drawing.Point(414, 192);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(21, 13);
            this.uf.TabIndex = 49;
            this.uf.Text = "UF";
            // 
            // txtTelefoneFax
            // 
            this.txtTelefoneFax.Location = new System.Drawing.Point(341, 119);
            this.txtTelefoneFax.Name = "txtTelefoneFax";
            this.txtTelefoneFax.Size = new System.Drawing.Size(165, 20);
            this.txtTelefoneFax.TabIndex = 40;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(272, 208);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(139, 20);
            this.txtCep.TabIndex = 48;
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Location = new System.Drawing.Point(8, 142);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(67, 13);
            this.endereco.TabIndex = 41;
            this.endereco.Text = "ENDEREÇO";
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Location = new System.Drawing.Point(269, 192);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(28, 13);
            this.cep.TabIndex = 47;
            this.cep.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(11, 158);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(329, 20);
            this.txtEndereco.TabIndex = 42;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(11, 208);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(249, 20);
            this.txtCidade.TabIndex = 46;
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Location = new System.Drawing.Point(343, 142);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(48, 13);
            this.bairro.TabIndex = 43;
            this.bairro.Text = "BAIRRO";
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Location = new System.Drawing.Point(8, 192);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(47, 13);
            this.cidade.TabIndex = 45;
            this.cidade.Text = "CIDADE";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(346, 158);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(162, 20);
            this.txtBairro.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 351);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Label dataNasc;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label uf;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.TextBox txtTelefoneFax;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label telFax;
        private System.Windows.Forms.Label celular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label nome;
    }
}

