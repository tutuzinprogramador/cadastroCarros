using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Lista_de_Carros_v2.classes
{
    class classUtil
    {
        public string validarNovoCarro(classCarros clCarro)
        {
            if (string.IsNullOrEmpty(clCarro.cor))
                return "Campo 'cor' não foi preeenchido";

            if (clCarro.marca == "")
                return "Campo 'marca' não foi preeenchido";

            if (clCarro.modelo == "")
                return "Campo 'modelo' não foi preeenchido";

            if (clCarro.portas == 0)
                return "Campo 'portas' não pode ser zero";

            if (clCarro.potencia == "")
                return "Campo 'potencia' não foi preeenchido";

            return "";
        }

        //Adiciona novo objeto à lista
        public void addNovoCarro(classCarros clCarro)
        {
            classSistema.lstLista.Add(clCarro);

            salvarBancoDados();

        }

        public void salvarBancoDados()
        {
            string dados = "";

            //Serializa a lista de OBJETOS
            dados = JsonConvert.SerializeObject(classSistema.lstLista);


            //Salva lista
            File.WriteAllText(classSistema.arquivoNome, dados);
        }

        public void abrirBancoDados()
        {
            string dados;

            //Cria objeto de leitura
            StreamReader arquivoTexto = new StreamReader(classSistema.arquivoNome);
            dados = arquivoTexto.ReadToEnd();
            arquivoTexto.Close();

            //Valida
            if (string.IsNullOrEmpty(dados))
                return;

            //Carrega dados para a lista
            classSistema.lstLista = JsonConvert.DeserializeObject<List<classCarros>>(dados);

        }

        public int getMaiorIDCadastrado()
        {
            int maiorID = 0;
            int x;

            for (x = 0; x < classSistema.lstLista.Count(); x++)
            {
                if (classSistema.lstLista[x].id > maiorID)
                {
                    maiorID = classSistema.lstLista[x].id;
                }
            }
            return maiorID;
        }

    }
    static class classSistema
    {
        public static string arquivoNome { get; set; }

        public static List<classCarros> lstLista = new List<classCarros>();
    }

}
