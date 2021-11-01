
namespace AQUINO
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTopMenuLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRenovacao = new System.Windows.Forms.Button();
            this.btnCamisetas = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnDeclaração = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelTopMenuLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnRenovacao);
            this.panelMenu.Controls.Add(this.btnCamisetas);
            this.panelMenu.Controls.Add(this.btnFinanceiro);
            this.panelMenu.Controls.Add(this.btnDeclaração);
            this.panelMenu.Controls.Add(this.btnCadastrar);
            this.panelMenu.Controls.Add(this.btnBuscar);
            this.panelMenu.Controls.Add(this.panelTopMenuLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 682);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTopMenuLogo
            // 
            this.panelTopMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
            this.panelTopMenuLogo.Controls.Add(this.pictureBox1);
            this.panelTopMenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenuLogo.Location = new System.Drawing.Point(0, 0);
            this.panelTopMenuLogo.Name = "panelTopMenuLogo";
            this.panelTopMenuLogo.Size = new System.Drawing.Size(220, 80);
            this.panelTopMenuLogo.TabIndex = 0;
            this.panelTopMenuLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(185)))), ((int)(((byte)(177)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1044, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(415, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox2);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1044, 602);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::AQUINO.Properties.Resources.aquino__1044_x_602_px_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1044, 602);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::AQUINO.Properties.Resources.userlmn_f31484bd01e51dc6931e4caaf4dfdecf1;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::AQUINO.Properties.Resources.userlmn_68b22d38b41efc8a6d2e08f2364d40c1;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 440);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "     Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRenovacao
            // 
            this.btnRenovacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRenovacao.FlatAppearance.BorderSize = 0;
            this.btnRenovacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRenovacao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRenovacao.Image = global::AQUINO.Properties.Resources.userlmn_39be6e0d46fed8da67e3446ebc7e997c;
            this.btnRenovacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovacao.Location = new System.Drawing.Point(0, 380);
            this.btnRenovacao.Name = "btnRenovacao";
            this.btnRenovacao.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRenovacao.Size = new System.Drawing.Size(220, 60);
            this.btnRenovacao.TabIndex = 6;
            this.btnRenovacao.Text = "     Renovação";
            this.btnRenovacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenovacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenovacao.UseVisualStyleBackColor = true;
            this.btnRenovacao.Click += new System.EventHandler(this.btnRenovacao_Click);
            // 
            // btnCamisetas
            // 
            this.btnCamisetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCamisetas.FlatAppearance.BorderSize = 0;
            this.btnCamisetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamisetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCamisetas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCamisetas.Image = global::AQUINO.Properties.Resources.userlmn_fbc47a304c77cfd8d6c6aa255293654e;
            this.btnCamisetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamisetas.Location = new System.Drawing.Point(0, 320);
            this.btnCamisetas.Name = "btnCamisetas";
            this.btnCamisetas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCamisetas.Size = new System.Drawing.Size(220, 60);
            this.btnCamisetas.TabIndex = 5;
            this.btnCamisetas.Text = "     Camisetas";
            this.btnCamisetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamisetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCamisetas.UseVisualStyleBackColor = true;
            this.btnCamisetas.Click += new System.EventHandler(this.btnCamisetas_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFinanceiro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinanceiro.Image = global::AQUINO.Properties.Resources.userlmn_63a987eafcb8adc1219d57e542247656;
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(0, 260);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFinanceiro.Size = new System.Drawing.Size(220, 60);
            this.btnFinanceiro.TabIndex = 4;
            this.btnFinanceiro.Text = "     Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnDeclaração
            // 
            this.btnDeclaração.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeclaração.FlatAppearance.BorderSize = 0;
            this.btnDeclaração.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclaração.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeclaração.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeclaração.Image = global::AQUINO.Properties.Resources.userlmn_8329a1413b27399e16a6ab0d433b02ea;
            this.btnDeclaração.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeclaração.Location = new System.Drawing.Point(0, 200);
            this.btnDeclaração.Name = "btnDeclaração";
            this.btnDeclaração.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDeclaração.Size = new System.Drawing.Size(220, 60);
            this.btnDeclaração.TabIndex = 3;
            this.btnDeclaração.Text = "     Declaração";
            this.btnDeclaração.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeclaração.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeclaração.UseVisualStyleBackColor = true;
            this.btnDeclaração.Click += new System.EventHandler(this.btnDeclaração_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrar.Image = global::AQUINO.Properties.Resources.userlmn_d8e380d15cdb868994137fc53d401fd4;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 140);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(220, 60);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "     Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Image = global::AQUINO.Properties.Resources.userlmn_9f8bc873a13b8cb557e69ece20513fc5;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(0, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBuscar.Size = new System.Drawing.Size(220, 60);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "     Buscar Dados";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AQUINO.Properties.Resources.aquino__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, -74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Text = "AQUINO";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTopMenuLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTopMenuLogo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRenovacao;
        private System.Windows.Forms.Button btnCamisetas;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnDeclaração;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}

