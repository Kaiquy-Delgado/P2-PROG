using System;
using System.IO;
using System.Windows.Forms;

namespace P2_FORMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuario == "ADMIN" && senha == "123")
            {
                AbrirPrincipal(usuario);
                return;
            }

            string caminho = Path.Combine(Application.StartupPath, "usuarios.csv");

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo de usu�rios n�o encontrado.");
                return;
            }

            bool autenticado = false;

            using (StreamReader sr = new StreamReader(caminho))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    if (linha.StartsWith("usuario")) continue; // pula o cabe�alho

                    string[] dados = linha.Split(',');

                    if (dados.Length >= 2 && dados[0] == usuario && dados[1] == senha)
                    {
                        autenticado = true;
                        break;
                    }
                }
            }

            if (autenticado)
            {
                AbrirPrincipal(usuario);
            }
            else
            {
                lblErro.Text = "Usu�rio ou senha inv�lidos!";
                lblErro.Visible = true;
            }
        }

        private void AbrirPrincipal(string usuario)
        {
            frmPrincipal principal = new frmPrincipal(usuario);
            principal.Show();
            this.Hide();
        }
    }
}
