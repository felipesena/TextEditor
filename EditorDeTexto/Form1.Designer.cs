namespace EditorDeTexto
{
    partial class frmEditorDeTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditorDeTexto));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirAjudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFerramentas = new System.Windows.Forms.ToolStrip();
            this.toolStripNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNegrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEsquerda = new System.Windows.Forms.ToolStripButton();
            this.toolStripCentro = new System.Windows.Forms.ToolStripButton();
            this.toolStripDireita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProcura = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSplitBusca = new System.Windows.Forms.ToolStripSplitButton();
            this.forçaBrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMSearchBoyerMooreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.análiseDeDesempenhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProximo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoStripBuscaLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripBuscaTempo = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.msMenu.SuspendLayout();
            this.tsFerramentas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.DarkGray;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(797, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.toolStripSeparator2,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.fonteToolStripMenuItem.Text = "Fonte...";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirAjudaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // exibirAjudaToolStripMenuItem
            // 
            this.exibirAjudaToolStripMenuItem.Name = "exibirAjudaToolStripMenuItem";
            this.exibirAjudaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exibirAjudaToolStripMenuItem.Text = "Exibir Ajuda";
            // 
            // tsFerramentas
            // 
            this.tsFerramentas.BackColor = System.Drawing.Color.DarkGray;
            this.tsFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNovo,
            this.toolStripAbrir,
            this.toolStripSalvar,
            this.toolStripSeparator,
            this.toolStripNegrito,
            this.toolStripItalico,
            this.toolStripSublinhado,
            this.toolStripSeparator3,
            this.toolStripEsquerda,
            this.toolStripCentro,
            this.toolStripDireita,
            this.toolStripSeparator4,
            this.toolStripProcura,
            this.toolStripSplitBusca,
            this.toolStripProximo});
            this.tsFerramentas.Location = new System.Drawing.Point(0, 24);
            this.tsFerramentas.Name = "tsFerramentas";
            this.tsFerramentas.Size = new System.Drawing.Size(797, 25);
            this.tsFerramentas.TabIndex = 2;
            this.tsFerramentas.Text = "toolStrip1";
            // 
            // toolStripNovo
            // 
            this.toolStripNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNovo.Image")));
            this.toolStripNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNovo.Name = "toolStripNovo";
            this.toolStripNovo.Size = new System.Drawing.Size(23, 22);
            this.toolStripNovo.Text = "&Novo";
            this.toolStripNovo.Click += new System.EventHandler(this.toolStripNovo_Click);
            // 
            // toolStripAbrir
            // 
            this.toolStripAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbrir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbrir.Image")));
            this.toolStripAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbrir.Name = "toolStripAbrir";
            this.toolStripAbrir.Size = new System.Drawing.Size(23, 22);
            this.toolStripAbrir.Text = "&Abrir";
            this.toolStripAbrir.Click += new System.EventHandler(this.toolStripAbrir_Click);
            // 
            // toolStripSalvar
            // 
            this.toolStripSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalvar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalvar.Image")));
            this.toolStripSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalvar.Name = "toolStripSalvar";
            this.toolStripSalvar.Size = new System.Drawing.Size(23, 22);
            this.toolStripSalvar.Text = "&Salvar";
            this.toolStripSalvar.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripNegrito
            // 
            this.toolStripNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNegrito.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNegrito.Image")));
            this.toolStripNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNegrito.Name = "toolStripNegrito";
            this.toolStripNegrito.Size = new System.Drawing.Size(23, 22);
            this.toolStripNegrito.Text = "Negrito";
            this.toolStripNegrito.Click += new System.EventHandler(this.toolStripNegrito_Click);
            // 
            // toolStripItalico
            // 
            this.toolStripItalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalico.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalico.Image")));
            this.toolStripItalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalico.Name = "toolStripItalico";
            this.toolStripItalico.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalico.Text = "Itálico";
            this.toolStripItalico.Click += new System.EventHandler(this.toolStripItalico_Click);
            // 
            // toolStripSublinhado
            // 
            this.toolStripSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSublinhado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSublinhado.Image")));
            this.toolStripSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSublinhado.Name = "toolStripSublinhado";
            this.toolStripSublinhado.Size = new System.Drawing.Size(23, 22);
            this.toolStripSublinhado.Text = "Sublinhado";
            this.toolStripSublinhado.Click += new System.EventHandler(this.toolStripSublinhado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripEsquerda
            // 
            this.toolStripEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEsquerda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEsquerda.Image")));
            this.toolStripEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEsquerda.Name = "toolStripEsquerda";
            this.toolStripEsquerda.Size = new System.Drawing.Size(23, 22);
            this.toolStripEsquerda.Text = "Alinhar a Esquerda";
            this.toolStripEsquerda.Click += new System.EventHandler(this.toolStripEsquerda_Click);
            // 
            // toolStripCentro
            // 
            this.toolStripCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCentro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCentro.Image")));
            this.toolStripCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCentro.Name = "toolStripCentro";
            this.toolStripCentro.Size = new System.Drawing.Size(23, 22);
            this.toolStripCentro.Text = "Centralizar";
            this.toolStripCentro.Click += new System.EventHandler(this.toolStripCentro_Click);
            // 
            // toolStripDireita
            // 
            this.toolStripDireita.BackColor = System.Drawing.Color.White;
            this.toolStripDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDireita.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDireita.Image")));
            this.toolStripDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDireita.Name = "toolStripDireita";
            this.toolStripDireita.Size = new System.Drawing.Size(23, 22);
            this.toolStripDireita.Text = "Alinhar a Direita";
            this.toolStripDireita.Click += new System.EventHandler(this.toolStripDireita_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProcura
            // 
            this.toolStripProcura.Name = "toolStripProcura";
            this.toolStripProcura.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSplitBusca
            // 
            this.toolStripSplitBusca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitBusca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forçaBrutaToolStripMenuItem,
            this.bMSearchBoyerMooreToolStripMenuItem,
            this.toolStripSeparator5,
            this.análiseDeDesempenhoToolStripMenuItem});
            this.toolStripSplitBusca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitBusca.Image")));
            this.toolStripSplitBusca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitBusca.Name = "toolStripSplitBusca";
            this.toolStripSplitBusca.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitBusca.Text = "Procurar";
            this.toolStripSplitBusca.ButtonClick += new System.EventHandler(this.toolStripSplitBusca_ButtonClick);
            // 
            // forçaBrutaToolStripMenuItem
            // 
            this.forçaBrutaToolStripMenuItem.Name = "forçaBrutaToolStripMenuItem";
            this.forçaBrutaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.forçaBrutaToolStripMenuItem.Text = "Força Bruta";
            this.forçaBrutaToolStripMenuItem.Click += new System.EventHandler(this.forçaBrutaToolStripMenuItem_Click);
            // 
            // bMSearchBoyerMooreToolStripMenuItem
            // 
            this.bMSearchBoyerMooreToolStripMenuItem.Name = "bMSearchBoyerMooreToolStripMenuItem";
            this.bMSearchBoyerMooreToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bMSearchBoyerMooreToolStripMenuItem.Text = "BM Search(Boyer-Moore)";
            this.bMSearchBoyerMooreToolStripMenuItem.Click += new System.EventHandler(this.bMSearchBoyerMooreToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(205, 6);
            // 
            // análiseDeDesempenhoToolStripMenuItem
            // 
            this.análiseDeDesempenhoToolStripMenuItem.Name = "análiseDeDesempenhoToolStripMenuItem";
            this.análiseDeDesempenhoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.análiseDeDesempenhoToolStripMenuItem.Text = "Análise de Desempenho";
            this.análiseDeDesempenhoToolStripMenuItem.Click += new System.EventHandler(this.análiseDeDesempenhoToolStripMenuItem_Click);
            // 
            // toolStripProximo
            // 
            this.toolStripProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripProximo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripProximo.Image")));
            this.toolStripProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripProximo.Name = "toolStripProximo";
            this.toolStripProximo.Size = new System.Drawing.Size(23, 22);
            this.toolStripProximo.Text = "Próximo";
            this.toolStripProximo.Visible = false;
            this.toolStripProximo.Click += new System.EventHandler(this.toolStripProximo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStripStatusLabel,
            this.infoStripBuscaLabel,
            this.toolStripBuscaTempo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoStripStatusLabel
            // 
            this.infoStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoStripStatusLabel.Name = "infoStripStatusLabel";
            this.infoStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.infoStripStatusLabel.Text = "Pronto";
            // 
            // infoStripBuscaLabel
            // 
            this.infoStripBuscaLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoStripBuscaLabel.Name = "infoStripBuscaLabel";
            this.infoStripBuscaLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripBuscaTempo
            // 
            this.toolStripBuscaTempo.BackColor = System.Drawing.Color.Transparent;
            this.toolStripBuscaTempo.Name = "toolStripBuscaTempo";
            this.toolStripBuscaTempo.Size = new System.Drawing.Size(0, 17);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rtbTexto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(12, 69);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(773, 228);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            this.rtbTexto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbTexto_MouseDown);
            // 
            // frmEditorDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(797, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsFerramentas);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmEditorDeTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditorDeTexto_FormClosing);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.tsFerramentas.ResumeLayout(false);
            this.tsFerramentas.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsFerramentas;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirAjudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripNovo;
        private System.Windows.Forms.ToolStripButton toolStripAbrir;
        private System.Windows.Forms.ToolStripButton toolStripSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoStripStatusLabel;
        private System.Windows.Forms.ToolStripButton toolStripNegrito;
        private System.Windows.Forms.ToolStripButton toolStripItalico;
        private System.Windows.Forms.ToolStripButton toolStripSublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripEsquerda;
        private System.Windows.Forms.ToolStripButton toolStripCentro;
        private System.Windows.Forms.ToolStripButton toolStripDireita;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripProximo;
        private System.Windows.Forms.ToolStripStatusLabel infoStripBuscaLabel;
        private System.Windows.Forms.ToolStripMenuItem forçaBrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMSearchBoyerMooreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem análiseDeDesempenhoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.ToolStripStatusLabel toolStripBuscaTempo;
        private System.Windows.Forms.ToolStripTextBox toolStripProcura;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitBusca;
    }
}

