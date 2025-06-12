namespace P2_FORMS
{
    partial class frmCadProduto
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
            lblCodigo = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            lstProdutos = new ListBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(98, 58);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(98, 117);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(98, 179);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(98, 245);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(98, 81);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(380, 27);
            txtCodigo.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 140);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(380, 27);
            txtNome.TabIndex = 5;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(98, 202);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(380, 27);
            txtPreco.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(98, 268);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(380, 27);
            txtDescricao.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(128, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(312, 326);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(226, 386);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(95, 30);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(114, 475);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(326, 104);
            lstProdutos.TabIndex = 11;
            // 
            // frmCadProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 591);
            Controls.Add(lstProdutos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtDescricao);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescricao);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Name = "frmCadProduto";
            Text = "Form2";
            Load += frmCadProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private Label lblPreco;
        private Label lblDescricao;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnLimpar;
        private ListBox lstProdutos;
    }
}