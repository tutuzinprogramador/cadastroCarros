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
    public partial class Menu_principal: Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void botãoAdicionar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void removerMarcaOuModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRemover frmRemover = new FormRemover();
            frmRemover.ShowDialog();
        }

        private void adicionarMarcaOuModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdicionar frmAdicionar = new FormAdicionar();
            frmAdicionar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            classUtil clUtil = new classUtil();

            var dlg = new OpenFileDialog();
            dlg.Filter = "TXT Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //Se usuário NÂO selecionou um arquivo... nada a fazer aqui....
            if (dlg.ShowDialog() == DialogResult.Cancel)
              return;

            //Guarda nome + caminho do arquivo de dados
            classSistema.arquivoNome = dlg.FileName;

            //Carregar dados do arquivo
            clUtil.abrirBancoDados();

            //Habilitar os demais itens de menu!
            menuNovoCarro.Enabled = true;
            menuPesquisarCarro.Enabled = true;
            //desabilitar o menu de "abrir"
            abrirToolStripMenuItem.Enabled = false;
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void verTodasAsMarcasEModelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerCarros frmForm = new FormVerCarros();
            frmForm.ShowDialog();
        }
    }
}
