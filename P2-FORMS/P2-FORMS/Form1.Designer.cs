namespace P2_FORMS
{
    partial class Form1
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
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(307, 63);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(101, 152);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(125, 93);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cadastrar Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            btnProduto.Location = new Point(232, 152);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(134, 93);
            btnProduto.TabIndex = 2;
            btnProduto.Text = "Cadastrar Produto";
            btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(372, 152);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(137, 93);
            btnPedido.TabIndex = 3;
            btnPedido.Text = "Cadastrar Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(515, 152);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(135, 93);
            btnUsuario.TabIndex = 4;
            btnUsuario.Text = "Cadastar Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 395);
            Controls.Add(btnUsuario);
            Controls.Add(btnPedido);
            Controls.Add(btnProduto);
            Controls.Add(btnCliente);
            Controls.Add(lblUsuario);
            Name = "Form1";
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
    }
}