namespace P2_FORMS
{
    partial class frmPrincipal
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
            lblUsuario = new Label();
            btnCliente = new Button();
            btnProduto = new Button();
            btnPedido = new Button();
            btnUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(336, 52);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(92, 163);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(123, 114);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(241, 163);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(119, 114);
            btnProduto.TabIndex = 2;
            btnProduto.Text = "Cadastrar Produto";
            btnProduto.UseVisualStyleBackColor = true;
            btnProduto.Click += btnProduto_Click;
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(392, 163);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(116, 114);
            btnPedido.TabIndex = 3;
            btnPedido.Text = "Cadastrar Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(539, 163);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(122, 114);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Cadastrar Usuário";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 140);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 5;
            label1.Text = "(Não Programado)";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 140);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 6;
            label2.Text = "(Não Programado)";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUsuario);
            Controls.Add(btnPedido);
            Controls.Add(btnProduto);
            Controls.Add(btnCliente);
            Controls.Add(lblUsuario);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Button btnCliente;
        private Button btnProduto;
        private Button btnPedido;
        private Button btnUsuario;
        private Label label1;
        private Label label2;
    }
}