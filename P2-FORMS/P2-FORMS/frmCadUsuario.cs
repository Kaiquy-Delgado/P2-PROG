using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_FORMS
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            lstUsuarios.Items.Clear();
            string caminho = Path.Combine(Application.StartupPath, "usuarios.csv");

            if (!File.Exists(caminho))
                return;

            var linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas.Skip(1)) // pula o cabeçalho
            {
                string[] dados = linha.Split(',');
                if (dados.Length >= 2)
                {
                    lstUsuarios.Items.Add(dados[0]); // adiciona só o nome do usuário
                }
            }
        }

        }

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha usuário e senha.");
                return;
            }

            string caminho = Path.Combine(Application.StartupPath, "usuarios.csv");

            List<string> linhas = new List<string>();
            bool atualizado = false;

            if (!File.Exists(caminho))
            {
                linhas.Add("usuario,senha");
            }
            else
            {
                linhas = File.ReadAllLines(caminho).ToList();

                for (int i = 1; i < linhas.Count; i++)
                {
                    string[] dados = linhas[i].Split(',');
                    if (dados[0] == usuario)
                    {
                        linhas[i] = $"{usuario},{senha}";
                        atualizado = true;
                        break;
                    }
                }
            }

            if (!atualizado)
                linhas.Add($"{usuario},{senha}");

            File.WriteAllLines(caminho, linhas);
            CarregarUsuarios();
            LimparCampos();

            MessageBox.Show(atualizado ? "Senha atualizada." : "Usuário cadastrado.");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string usuarioSelecionado = lstUsuarios.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(usuarioSelecionado))
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            if (usuarioSelecionado == "ADMIN")
            {
                MessageBox.Show("O usuário ADMIN não pode ser excluído.");
                return;
            }

            string caminho = Path.Combine(Application.StartupPath, "usuarios.csv");
            var linhas = File.ReadAllLines(caminho).ToList();

            for (int i = 1; i < linhas.Count; i++)
            {
                string[] dados = linhas[i].Split(',');
                if (dados[0] == usuarioSelecionado)
                {
                    linhas.RemoveAt(i);
                    break;
                }
            }

            File.WriteAllLines(caminho, linhas);
            CarregarUsuarios();
            LimparCampos();
            MessageBox.Show("Usuário excluído com sucesso.");
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usuario = lstUsuarios.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(usuario))
                return;

            string caminho = Path.Combine(Application.StartupPath, "usuarios.csv");
            var linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas.Skip(1))
            {
                string[] dados = linha.Split(',');
                if (dados[0] == usuario)
                {
                    txtUsuario.Text = dados[0];
                    txtSenha.Text = dados[1];
                    break;
                }
            }
        }
    }
}
