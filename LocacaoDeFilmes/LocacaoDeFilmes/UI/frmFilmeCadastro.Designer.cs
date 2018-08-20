namespace LocacaoDeFilmes.UI
{
    partial class frmFilmeCadastro
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
            this.lblQtd = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTipoDeMidia = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblTipoDeMidia = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(107, 133);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(27, 13);
            this.lblQtd.TabIndex = 6;
            this.lblQtd.Text = "Qtd:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Controls.Add(this.tbpConsulta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 275);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.txtQtd);
            this.tbpCadastro.Controls.Add(this.lblQtd);
            this.tbpCadastro.Controls.Add(this.btnCancelar);
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.txtTipoDeMidia);
            this.tbpCadastro.Controls.Add(this.txtObs);
            this.tbpCadastro.Controls.Add(this.txtTitulo);
            this.tbpCadastro.Controls.Add(this.txtCod);
            this.tbpCadastro.Controls.Add(this.lblTipoDeMidia);
            this.tbpCadastro.Controls.Add(this.lblObs);
            this.tbpCadastro.Controls.Add(this.lblTitulo);
            this.tbpCadastro.Controls.Add(this.lblCod);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(382, 249);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            this.tbpCadastro.Click += new System.EventHandler(this.tbpCadastro_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(153, 134);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(198, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(67, 193);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTipoDeMidia
            // 
            this.txtTipoDeMidia.Location = new System.Drawing.Point(154, 82);
            this.txtTipoDeMidia.Name = "txtTipoDeMidia";
            this.txtTipoDeMidia.Size = new System.Drawing.Size(100, 20);
            this.txtTipoDeMidia.TabIndex = 2;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(154, 108);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(100, 20);
            this.txtObs.TabIndex = 3;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(153, 56);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(153, 30);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 0;
            // 
            // lblTipoDeMidia
            // 
            this.lblTipoDeMidia.AutoSize = true;
            this.lblTipoDeMidia.Location = new System.Drawing.Point(64, 85);
            this.lblTipoDeMidia.Name = "lblTipoDeMidia";
            this.lblTipoDeMidia.Size = new System.Drawing.Size(74, 13);
            this.lblTipoDeMidia.TabIndex = 3;
            this.lblTipoDeMidia.Text = "Tipo de Midia:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(108, 107);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Obs:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(102, 59);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(108, 33);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(29, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Cod:";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.btnExcluir);
            this.tbpConsulta.Controls.Add(this.dgvResultado);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(382, 249);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(302, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(72, 29);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.Location = new System.Drawing.Point(3, 58);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(376, 192);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // frmFilmeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 275);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFilmeCadastro";
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.frmFilmeCadastro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtTipoDeMidia;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblTipoDeMidia;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvResultado;
    }
}