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
    public partial class frmCadPedido: Form
    {
        private string usuarioLogado;

        public frmCadPedido(string usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
        }

        private void frmCadPedido_Load(object sender, EventArgs e)
        {
            
        }
    }
}
