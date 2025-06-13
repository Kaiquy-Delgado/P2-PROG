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
    public partial class frmPrincipal : Form
    {
        string usuarioLogado;
        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            lblUsuario.Text = $"Usuário: {usuarioLogado}";

            if (usuarioLogado != "ADMIN")
            {
                btnUsuario.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmCadProduto produto = new frmCadProduto();
            produto.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmCadPedido pedido = new frmCadPedido(usuarioLogado);
            pedido.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCadUsuario usuario = new frmCadUsuario();
            usuario.ShowDialog();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
