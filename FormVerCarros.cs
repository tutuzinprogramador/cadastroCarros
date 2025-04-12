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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_de_Carros_v2
{
    public partial class FormVerCarros: Form
    {
        int removerId = -1;

        public FormVerCarros()
        {
            InitializeComponent();
        }

        private void FormVerCarros_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void lblCarros_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregaListaTela();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //label1.Text = classSistema.lstLista[e.ItemIndex].modelo; it´s working !!!!

            //int ID = classSistema.lstLista[e.ItemIndex].id;

            

            button2.Enabled = true;

            this.removerId = e.ItemIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classUtil clUtil = new classUtil();

            if (this.removerId < 0)
            {
                MessageBox.Show("Selecione um veiculo para remover!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Você tem certeza?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //REMOVE
            classSistema.lstLista.RemoveAt(this.removerId);

            //Reseta variavel de controle
            this.removerId = -1;

            //Atualiza a tela
            carregaListaTela();

            //Salva no banco de dados
            clUtil.salvarBancoDados();
        }

        private void carregaListaTela()
        {
            string[] dados = new string[7];
            int x;
            string pesquisaText = edtPesquisa.Text;

            //Limpar a lista da tela
            listView1.Items.Clear();

            //laço de interção da lista
            for (x = 0; x < classSistema.lstLista.Count(); x++)
            {
                //Criar novo objeto array
                dados = new string[7];

                //Carrega no array os dados do objeto da lista na posição X
                dados[0] = classSistema.lstLista[x].cor;
                dados[1] = classSistema.lstLista[x].marca;
                dados[2] = classSistema.lstLista[x].modelo;
                dados[3] = classSistema.lstLista[x].ano;
                dados[4] = Convert.ToString(classSistema.lstLista[x].portas);
                dados[5] = classSistema.lstLista[x].potencia;
                dados[6] = classSistema.lstLista[x].id.ToString();

                //Filtro
                if (pesquisaText == "")
                {
                    //Criar novo item da lista
                    ListViewItem itm = new ListViewItem(dados);

                    //Adiciona novo item da lista da tela
                    listView1.Items.Add(itm);
                }
                else
                {
                    //Aplica filtro
                    if (classSistema.lstLista[x].marca.ToLower().Contains(pesquisaText.ToLower()))
                    {
                        //Criar novo item da lista
                        ListViewItem itm = new ListViewItem(dados);

                        //Adiciobna novo item da lista da tela
                        listView1.Items.Add(itm);
                    }
                }

            }
        }
    }
}
