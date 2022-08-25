using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConsultarCEP.NET
{
    public partial class Form1 : Form
    {
        public string Endereco
        {
            get { return txtEndereco.Text; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            //tentar
            try
            {
                //criando varialvel do ws dos correios
                var webService = new ServiceReference1.AtendeClienteClient();
                //executando o metodo que consulta o CEP
                //parametro: string CEP
                var res = webService.consultaCEP(txtCEP.Text);

                txtEndereco.Text = res.end;
                txtBairro.Text = res.bairro;
                txtCidade.Text = res.cidade;
                txtComplemento.Text = res.complemento2;
                txtEstado.Text = res.uf;

                //capturar o erro

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
            
            
        }
    }
}
