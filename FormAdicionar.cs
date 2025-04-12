using Lista_de_Carros_v2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Carros_v2
{
    public partial class FormAdicionar: Form
    {
        public FormAdicionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classUtil clUtil = new classUtil();
            classCarros clCarro;
            string erro;

            //Cria nova instancia do objeto
            clCarro = new classCarros();




            //Obtem dados
            clCarro.id         = clUtil.getMaiorIDCadastrado() + 1;
            clCarro.cor        = edtCor.Text;
            clCarro.marca      = edtMarca.Text;
            clCarro.modelo     = edtModelo.Text;
            clCarro.ano        = edtAno.Text;
            clCarro.aerofolio  = chbAerofolio.Checked;
            clCarro.portas     = Convert.ToInt16(numPortas.Value);
            clCarro.potencia   = edtPotencia.Text;

            //Validar dados
            erro = clUtil.validarNovoCarro(clCarro);
            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            //salva novo veiculo
            clUtil.addNovoCarro(clCarro);

            //Envia mensagem para usuário
            MessageBox.Show("O veículo foi cadastrado com sucesso!");

            //Fechar o form
            this.Close();
        }

        private void numPortas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAdicionar_Load(object sender, EventArgs e)
        {

        }
    }
}
