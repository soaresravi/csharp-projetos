namespace cadastro_clientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            pbImagem = new PictureBox();
            panel2 = new Panel();
            lblTitulo = new Label();
            txtEstoqueMax = new TextBox();
            btnSair = new Button();
            txtEstoqueMin = new TextBox();
            btnLimpar = new Button();
            lblEstoqueMax = new Label();
            btnSalvar = new Button();
            lblEstoqueMin = new Label();
            txtValorMax = new TextBox();
            lblValorMax = new Label();
            txtValorMin = new TextBox();
            lblValorMin = new Label();
            txtLucro = new TextBox();
            lblLucro = new Label();
            txtPrecoVenda = new TextBox();
            txtPrecoCusto = new TextBox();
            lblPrecoVenda = new Label();
            lblPrecoCusto = new Label();
            txtUnidade = new TextBox();
            lblUnidade = new Label();
            pbImagem2 = new PictureBox();
            txtPeso = new TextBox();
            lblPeso = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtID = new TextBox();
            lblID = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(896, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(80, 24);
            consultaToolStripMenuItem.Text = "Consulta";
            consultaToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // pbImagem
            // 
            pbImagem.Image = (Image)resources.GetObject("pbImagem.Image");
            pbImagem.Location = new Point(46, 54);
            pbImagem.Margin = new Padding(3, 4, 3, 4);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(67, 69);
            pbImagem.TabIndex = 7;
            pbImagem.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTitulo);
            panel2.Location = new Point(149, 68);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 55);
            panel2.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(247, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de produtos";
            // 
            // txtEstoqueMax
            // 
            txtEstoqueMax.Location = new Point(179, 425);
            txtEstoqueMax.Margin = new Padding(3, 4, 3, 4);
            txtEstoqueMax.Name = "txtEstoqueMax";
            txtEstoqueMax.Size = new Size(109, 27);
            txtEstoqueMax.TabIndex = 52;
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ControlLight;
            btnSair.Image = Properties.Resources.sair;
            btnSair.Location = new Point(722, 425);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 93);
            btnSair.TabIndex = 31;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click_1;
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(46, 425);
            txtEstoqueMin.Margin = new Padding(3, 4, 3, 4);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.Size = new Size(107, 27);
            txtEstoqueMin.TabIndex = 51;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ControlLight;
            btnLimpar.Image = Properties.Resources.limpeza_de_dados;
            btnLimpar.Location = new Point(629, 425);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 93);
            btnLimpar.TabIndex = 29;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // lblEstoqueMax
            // 
            lblEstoqueMax.AutoSize = true;
            lblEstoqueMax.Location = new Point(179, 401);
            lblEstoqueMax.Name = "lblEstoqueMax";
            lblEstoqueMax.Size = new Size(120, 20);
            lblEstoqueMax.TabIndex = 50;
            lblEstoqueMax.Text = "Estoque Máximo";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ControlLight;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(532, 425);
            btnSalvar.Margin = new Padding(3, 4, 3, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 92);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Location = new Point(46, 401);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(117, 20);
            lblEstoqueMin.TabIndex = 49;
            lblEstoqueMin.Text = "Estoque mínimo";
            // 
            // txtValorMax
            // 
            txtValorMax.Location = new Point(511, 339);
            txtValorMax.Margin = new Padding(3, 4, 3, 4);
            txtValorMax.Name = "txtValorMax";
            txtValorMax.Size = new Size(79, 27);
            txtValorMax.TabIndex = 48;
            // 
            // lblValorMax
            // 
            lblValorMax.AutoSize = true;
            lblValorMax.Location = new Point(509, 315);
            lblValorMax.Name = "lblValorMax";
            lblValorMax.Size = new Size(78, 20);
            lblValorMax.TabIndex = 47;
            lblValorMax.Text = "Valor Max.";
            // 
            // txtValorMin
            // 
            txtValorMin.Location = new Point(418, 339);
            txtValorMin.Margin = new Padding(3, 4, 3, 4);
            txtValorMin.Name = "txtValorMin";
            txtValorMin.Size = new Size(79, 27);
            txtValorMin.TabIndex = 46;
            // 
            // lblValorMin
            // 
            lblValorMin.AutoSize = true;
            lblValorMin.Location = new Point(415, 315);
            lblValorMin.Name = "lblValorMin";
            lblValorMin.Size = new Size(75, 20);
            lblValorMin.TabIndex = 45;
            lblValorMin.Text = "Valor Min.";
            // 
            // txtLucro
            // 
            txtLucro.Location = new Point(283, 339);
            txtLucro.Margin = new Padding(3, 4, 3, 4);
            txtLucro.Name = "txtLucro";
            txtLucro.Size = new Size(79, 27);
            txtLucro.TabIndex = 44;
            // 
            // lblLucro
            // 
            lblLucro.AutoSize = true;
            lblLucro.Location = new Point(283, 315);
            lblLucro.Name = "lblLucro";
            lblLucro.Size = new Size(71, 20);
            lblLucro.TabIndex = 43;
            lblLucro.Text = "Lucro (%)";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Location = new Point(142, 339);
            txtPrecoVenda.Margin = new Padding(3, 4, 3, 4);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(79, 27);
            txtPrecoVenda.TabIndex = 42;
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.Location = new Point(45, 339);
            txtPrecoCusto.Margin = new Padding(3, 4, 3, 4);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(79, 27);
            txtPrecoCusto.TabIndex = 41;
            // 
            // lblPrecoVenda
            // 
            lblPrecoVenda.AutoSize = true;
            lblPrecoVenda.Location = new Point(142, 315);
            lblPrecoVenda.Name = "lblPrecoVenda";
            lblPrecoVenda.Size = new Size(90, 20);
            lblPrecoVenda.TabIndex = 40;
            lblPrecoVenda.Text = "Preço venda";
            // 
            // lblPrecoCusto
            // 
            lblPrecoCusto.AutoSize = true;
            lblPrecoCusto.Location = new Point(45, 315);
            lblPrecoCusto.Name = "lblPrecoCusto";
            lblPrecoCusto.Size = new Size(85, 20);
            lblPrecoCusto.TabIndex = 39;
            lblPrecoCusto.Text = "Preço custo";
            // 
            // txtUnidade
            // 
            txtUnidade.Location = new Point(439, 267);
            txtUnidade.Margin = new Padding(3, 4, 3, 4);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(151, 27);
            txtUnidade.TabIndex = 38;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.BackColor = SystemColors.AppWorkspace;
            lblUnidade.Location = new Point(439, 243);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(65, 20);
            lblUnidade.TabIndex = 37;
            lblUnidade.Text = "Unidade";
            // 
            // pbImagem2
            // 
            pbImagem2.Image = (Image)resources.GetObject("pbImagem2.Image");
            pbImagem2.Location = new Point(629, 193);
            pbImagem2.Margin = new Padding(3, 4, 3, 4);
            pbImagem2.Name = "pbImagem2";
            pbImagem2.Size = new Size(161, 159);
            pbImagem2.TabIndex = 36;
            pbImagem2.TabStop = false;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(439, 193);
            txtPeso.Margin = new Padding(3, 4, 3, 4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(151, 27);
            txtPeso.TabIndex = 35;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(439, 165);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(71, 20);
            lblPeso.TabIndex = 34;
            lblPeso.Text = "Peso (KG)";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(45, 267);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(374, 27);
            txtDescricao.TabIndex = 33;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(45, 243);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 32;
            lblDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(142, 193);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(277, 27);
            txtNome.TabIndex = 30;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(142, 165);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(45, 193);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(79, 27);
            txtID.TabIndex = 26;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(45, 165);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 25;
            lblID.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(896, 657);
            Controls.Add(txtEstoqueMax);
            Controls.Add(btnSair);
            Controls.Add(txtEstoqueMin);
            Controls.Add(btnLimpar);
            Controls.Add(lblEstoqueMax);
            Controls.Add(btnSalvar);
            Controls.Add(lblEstoqueMin);
            Controls.Add(txtValorMax);
            Controls.Add(lblValorMax);
            Controls.Add(txtValorMin);
            Controls.Add(lblValorMin);
            Controls.Add(txtLucro);
            Controls.Add(lblLucro);
            Controls.Add(txtPrecoVenda);
            Controls.Add(txtPrecoCusto);
            Controls.Add(lblPrecoVenda);
            Controls.Add(lblPrecoCusto);
            Controls.Add(txtUnidade);
            Controls.Add(lblUnidade);
            Controls.Add(pbImagem2);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtID);
            Controls.Add(lblID);
            Controls.Add(pbImagem);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Cadastro";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private PictureBox pbImagem;
        private Panel panel2;
        private Label lblTitulo;
        private TextBox txtEstoqueMax;
        private Button btnSair;
        private TextBox txtEstoqueMin;
        private Button btnLimpar;
        private Label lblEstoqueMax;
        private Button btnSalvar;
        private Label lblEstoqueMin;
        private TextBox txtValorMax;
        private Label lblValorMax;
        private TextBox txtValorMin;
        private Label lblValorMin;
        private TextBox txtLucro;
        private Label lblLucro;
        private TextBox txtPrecoVenda;
        private TextBox txtPrecoCusto;
        private Label lblPrecoVenda;
        private Label lblPrecoCusto;
        private TextBox txtUnidade;
        private Label lblUnidade;
        private PictureBox pbImagem2;
        private TextBox txtPeso;
        private Label lblPeso;
        private TextBox txtDescricao;
        private Label lblDescricao;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtID;
        private Label lblID;
    }
}
