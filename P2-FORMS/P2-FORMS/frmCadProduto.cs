﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            string codigo = txtCodigo.Text.Trim();
            string nome = txtNome.Text.Trim();
            string precoTexto = txtPreco.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(precoTexto))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (!decimal.TryParse(precoTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            List<string> linhas = new List<string>();
            bool atualizado = false;

            if (File.Exists(caminhoArquivo))
            {
                var todasLinhas = File.ReadAllLines(caminhoArquivo);
                foreach (var linha in todasLinhas)
                {
                    var dados = linha.Split(',');
                    if (dados[0] == codigo)
                    {
                        linhas.Add($"{codigo},{nome},{preco.ToString(CultureInfo.InvariantCulture)},{descricao}");
                        atualizado = true;
                    }
                    else
                    {
                        linhas.Add(linha);
                    }
                }
            }

            if (!atualizado)
            {
                linhas.Add($"{codigo},{nome},{preco.ToString(CultureInfo.InvariantCulture)},{descricao}");
            }

            File.WriteAllLines(caminhoArquivo, linhas);
            MessageBox.Show(atualizado ? "Produto atualizado." : "Produto cadastrado.");
            LimparCampos();
            CarregarProdutos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Digite o código do produto a ser excluído.");
                return;
            }

            if (!File.Exists(caminhoArquivo)) return;

            var linhas = File.ReadAllLines(caminhoArquivo).Where(l => !l.StartsWith(codigo + ",")).ToList();
            File.WriteAllLines(caminhoArquivo, linhas);

            MessageBox.Show("Produto excluído com sucesso.");
            LimparCampos();
            CarregarProdutos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
            lstProdutos.ClearSelected();
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedItem == null) return;

            string linhaSelecionada = lstProdutos.SelectedItem.ToString();
            string codigoSelecionado = linhaSelecionada.Split('-')[0].Trim();

            if (!File.Exists(caminhoArquivo)) return;

            var linhas = File.ReadAllLines(caminhoArquivo);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');
                if (dados[0] == codigoSelecionado)
                {
                    txtCodigo.Text = dados[0];
                    txtNome.Text = dados[1];
                    txtPreco.Text = dados[2];
                    txtDescricao.Text = dados[3];
                    break;
                }
            }
        }
    }
}
