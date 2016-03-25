using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;




namespace Projeto3Camadas
{
    public partial class frmCadastroCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Nome = txtNome.Text;
            dto.Email = txtEmail.Text;
            bll.Inserir(dto);

        }
    }
}
