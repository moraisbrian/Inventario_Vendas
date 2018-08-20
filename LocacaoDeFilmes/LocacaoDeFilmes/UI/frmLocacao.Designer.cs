namespace LocacaoDeFilmes.UI
{
    partial class frmLocacao
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
            this.nudQtdRemover = new System.Windows.Forms.NumericUpDown();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimparItens = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSelecionarFilme = new System.Windows.Forms.Button();
            this.btnSelecionarCliente = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodFilme = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodFilme = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudQtdRemover
            // 
            this.nudQtdRemover.Location = new System.Drawing.Point(6, 194);
            this.nudQtdRemover.Name = "nudQtdRemover";
            this.nudQtdRemover.Size = new System.Drawing.Size(44, 20);
            this.nudQtdRemover.TabIndex = 35;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(56, 194);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(84, 23);
            this.btnRemover.TabIndex = 34;
            this.btnRemover.Text = "Remover Item";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimparItens
            // 
            this.btnLimparItens.Location = new System.Drawing.Point(189, 194);
            this.btnLimparItens.Name = "btnLimparItens";
            this.btnLimparItens.Size = new System.Drawing.Size(75, 23);
            this.btnLimparItens.TabIndex = 32;
            this.btnLimparItens.Text = "Limpar Itens";
            this.btnLimparItens.UseVisualStyleBackColor = true;
            this.btnLimparItens.Click += new System.EventHandler(this.btnLimparItens_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(270, 194);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(90, 23);
            this.btnFinalizar.TabIndex = 31;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(259, 123);
            this.nudQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(54, 20);
            this.nudQtd.TabIndex = 30;
            this.nudQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(6, 19);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(354, 169);
            this.dgvResultado.TabIndex = 29;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(116, 191);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(110, 23);
            this.btnAdicionar.TabIndex = 28;
            this.btnAdicionar.Text = "Adicionar Item";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSelecionarFilme
            // 
            this.btnSelecionarFilme.Location = new System.Drawing.Point(31, 149);
            this.btnSelecionarFilme.Name = "btnSelecionarFilme";
            this.btnSelecionarFilme.Size = new System.Drawing.Size(282, 23);
            this.btnSelecionarFilme.TabIndex = 27;
            this.btnSelecionarFilme.Text = "Selecionar Filme";
            this.btnSelecionarFilme.UseVisualStyleBackColor = true;
            this.btnSelecionarFilme.Click += new System.EventHandler(this.btnSelecionarProduto_Click);
            // 
            // btnSelecionarCliente
            // 
            this.btnSelecionarCliente.Location = new System.Drawing.Point(31, 75);
            this.btnSelecionarCliente.Name = "btnSelecionarCliente";
            this.btnSelecionarCliente.Size = new System.Drawing.Size(282, 23);
            this.btnSelecionarCliente.TabIndex = 26;
            this.btnSelecionarCliente.Text = "Selecionar Cliente";
            this.btnSelecionarCliente.UseVisualStyleBackColor = true;
            this.btnSelecionarCliente.Click += new System.EventHandler(this.btnSelecionarCliente_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(138, 122);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(115, 20);
            this.txtTitulo.TabIndex = 25;
            // 
            // txtCodFilme
            // 
            this.txtCodFilme.Location = new System.Drawing.Point(31, 122);
            this.txtCodFilme.Name = "txtCodFilme";
            this.txtCodFilme.Size = new System.Drawing.Size(77, 20);
            this.txtCodFilme.TabIndex = 24;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(138, 49);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(175, 20);
            this.txtNomeCli.TabIndex = 23;
            // 
            // txtCodCli
            // 
            this.txtCodCli.Location = new System.Drawing.Point(31, 49);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(77, 20);
            this.txtCodCli.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(135, 106);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblCodFilme
            // 
            this.lblCodFilme.AutoSize = true;
            this.lblCodFilme.Location = new System.Drawing.Point(28, 106);
            this.lblCodFilme.Name = "lblCodFilme";
            this.lblCodFilme.Size = new System.Drawing.Size(53, 13);
            this.lblCodFilme.TabIndex = 20;
            this.lblCodFilme.Text = "Cod Filme";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(135, 33);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(70, 13);
            this.lblNomeCli.TabIndex = 19;
            this.lblNomeCli.Text = "Nome Cliente";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(28, 33);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(61, 13);
            this.lblCodCli.TabIndex = 18;
            this.lblCodCli.Text = "Cod Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQtd);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Controls.Add(this.btnSelecionarFilme);
            this.groupBox1.Controls.Add(this.btnSelecionarCliente);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Controls.Add(this.txtCodFilme);
            this.groupBox1.Controls.Add(this.txtNomeCli);
            this.groupBox1.Controls.Add(this.txtCodCli);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.lblCodFilme);
            this.groupBox1.Controls.Add(this.lblNomeCli);
            this.groupBox1.Controls.Add(this.lblCodCli);
            this.groupBox1.Location = new System.Drawing.Point(18, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 226);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locar Filme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudQtdRemover);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnLimparItens);
            this.groupBox2.Controls.Add(this.btnFinalizar);
            this.groupBox2.Controls.Add(this.dgvResultado);
            this.groupBox2.Location = new System.Drawing.Point(405, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 226);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            // 
            // frmLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(810, 315);
            this.MinimumSize = new System.Drawing.Size(810, 315);
            this.Name = "frmLocacao";
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.frmLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQtdRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimparItens;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSelecionarFilme;
        private System.Windows.Forms.Button btnSelecionarCliente;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodFilme;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodFilme;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}