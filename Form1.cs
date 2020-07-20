using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCliente
{



    public partial class FFCliente : Form
    {
        // Cria objeto cliente  de array 15 
        Cliente[] cliente = new Cliente[15];
        //cria lista global onde será mostrada os clientes
        public List<Cliente> listaClientes = new List<Cliente>();


        public FFCliente()
        {
            InitializeComponent();
          

        }


        private void FFCliente_Load(object sender, EventArgs e)
        {
          
        }
        

       

        #region [QUESTÃO 1]
        /* Questão 1 Item a

           Crie uma função que receba a data de fundação e o valor do faturamento,
           retorne todos os clientes ativos ordenados por data de alteração onde a data de
           fundação e o faturamento sejam maiores ou iguais aos enviados por parâmetro.

           */
        public List<Cliente> PesquisaFaturamento(decimal faturaLimite,DateTime dateLimite)
        {
            // filtrando a lista
            List<Cliente> result = listaClientes.FindAll(
            delegate (Cliente c)
            {
                // incluindo filtro direto no retorno 
                return (c.DataFundacao >= dateLimite) && (c.Ativo == true) && (c.Faturamento >= faturaLimite);
            });

            // ordena a lista resultante por data de alteração a lista
            result = result.OrderBy(c1 => c1.Alteracao).ToList();

            //returna o resultado
           return result;
        }
        /* QUESTÃO 1 item b
         * Crie uma função que receba uma lista de clientes e retorne os 10 maiores
           faturamentos.*/
        //Função recebe uma lista de Clientes e retorna uma lista ordenando o faturamento
        public List<Cliente> OrdenaFaturamento(List<Cliente> result)
        {
            //criando uma nova lista com tamanho limitado de 10;
            List<Cliente> listaResult = new List<Cliente> ();

            // ordena a lista recebida e atribui na nova lista
            listaResult = result.OrderByDescending(c => c.Faturamento).ToList();
           
            
            // define a quantidade restante de item que seram removidos para manter a lista em 10 elementos
            var range = listaResult.Count- 10; 

            //remove os elementos restantes
            listaResult.RemoveRange(10, range);
            return listaResult;
        }
        #endregion



        #region [Codigo dos Botões]


        //[PESQUISAR]: chama a função "Pesquisar Faturamento" e retorna o resultado no grid
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
          
            // Cria uma Nova Lista
            List<Cliente> listaPesquisa = new List<Cliente>();

            //Pega os valores limitantes da pesquisa e atribui numa variavel;
            var faturaLimite = decimal.Parse(textPFaturamento.Text);
            var dateLimite = DateTime.Parse(textPDataLimite.Text);
            listaPesquisa = PesquisaFaturamento(faturaLimite, dateLimite);

            //atualiza o Grid
            gridCliente.DataSource = 0;
            gridCliente.DataSource = listaPesquisa;

        }
        
        //[SALVAR]: Add e salva os Clientes registrados nos campos
        void btnSalvar_Click(object sender, EventArgs e)
        {
            //cria uma variavel auxiliar boleana para o comboBox
            bool boxAtivo = true;
            // atribui o codigo do cliente ao indice do objetvo 
            // se o codigo passar do limite de 15 pode dar erro

            var indice = Convert.ToInt32(textCodigo.Text);

            if (CBoxAtivo.SelectedIndex == 0)
            {
                boxAtivo = true;
            }
            else
            {
                boxAtivo = false;
            }

            // cria novos objeto cliente e liga os atributos aos campos
            cliente[indice] = new Cliente();
            cliente[indice].Codigo = indice;
            cliente[indice].Documento = textDoc.Text;
            cliente[indice].Nome = textNome.Text;

            //converte as variaveis do tipo DateTime
            cliente[indice].Alteracao = DateTime.Parse(textDAlteracao.Text);
            cliente[indice].DataFundacao = DateTime.Parse(textDFundacao.Text);

            cliente[indice].Faturamento = decimal.Parse(textFaturamento.Text);
            cliente[indice].Ativo = boxAtivo;

            // registra novo cliente na lista
            listaClientes.Add(cliente[indice]);

        }

          
        //[ATUALIZAR]: mostra a lista "listaClientes" no grid
        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            gridCliente.DataSource = 0;
            gridCliente.DataSource = listaClientes;
        }


        //[RESETAR] :Esvazia a lista de Clientes e o grid
        //após essa operação é preciso add novos clientes
        private void btnReset_Click(object sender, EventArgs e)
        {
            //limpa lista
            listaClientes.Clear();

            //Limpa grid
            gridCliente.DataSource = 0;
        }


        private void btnOrdena_Click(object sender, EventArgs e)
        {
            //limpa o grid
            gridCliente.DataSource = 0;
            
            // chama a função de ordenar  com o parametro da lista de clientes e aplica o resultado no Grid
            gridCliente.DataSource = OrdenaFaturamento(listaClientes);

        }


        #region [Codigo para Popular Cliente]
        // Codigo feito para popular Cliente mais rapido para testes
        private void button3_Click(object sender, EventArgs e)
        {
            var indice = 1;
            do
            {
                cliente[indice] = new Cliente();
                cliente[indice].Codigo = indice;
                cliente[indice].Nome = "Evandro Fernandes";
               cliente[indice].Ativo = true;
                cliente[indice].Documento = "2222222";
                cliente[indice].Alteracao = DateTime.Parse("09/09/1993");
                cliente[indice].DataFundacao = DateTime.Parse("09/09/1993");
                cliente[indice].Faturamento = 999;
                //atualiza lista
                listaClientes.Add(cliente[indice]);

                indice++;
               
            } while (indice < 5);
            do
            {
                cliente[indice] = new Cliente();
                cliente[indice].Codigo = indice;
                cliente[indice].Nome = "Evandro Fernandes";
                cliente[indice].Ativo = true;
                cliente[indice].Documento = "2222222";
                cliente[indice].Alteracao = DateTime.Parse("01/09/2000");
                cliente[indice].DataFundacao = DateTime.Parse("09/09/2000");
                cliente[indice].Faturamento = 1100;
                //atualiza lista
                listaClientes.Add(cliente[indice]);

                indice++;

            } while (indice < 10);

            do
            {
                cliente[indice] = new Cliente();
                cliente[indice].Codigo = indice;
                cliente[indice].Nome = "Evandro Fernandes";
                cliente[indice].Ativo = true;
                cliente[indice].Documento = "2222222";
                cliente[indice].Alteracao = DateTime.Parse("09/10/1993");
                cliente[indice].DataFundacao = DateTime.Parse("09/09/1993");
                cliente[indice].Faturamento = 1009;
                //atualiza lista
                listaClientes.Add(cliente[indice]);

                indice++;

            } while (indice < cliente.Length);
        }
        #endregion

        #endregion

        
    }


}
