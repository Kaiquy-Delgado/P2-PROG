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
    public partial class frmCadProduto : Form
    {

        private string caminhoArquivo = "produtos.csv";
        public frmCadProduto()
        {
            InitializeComponent();
            CarregarProdutos();
        }
        private void CarregarProdutos()
        {
            lstProdutos.Items.Clear();
            if (!File.Exists(caminhoArquivo))
                return;

            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');
                if (dados.Length >= 4)
                {
                    lstProdutos.Items.Add($"{dados[0]} - {dados[1]} - R$ {dados[2]}");
                }
            }
        }


        private void frmCadProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
