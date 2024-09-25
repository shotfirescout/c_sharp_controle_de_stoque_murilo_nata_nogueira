using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace c_sharp_controle_de_stoque_murilo_nata_nogueira
{
    
    public partial class Form1 : Form
    {


        private DataTable produtos = new DataTable();
        private ProdutoDAO produtoDAO = new ProdutoDAO();
        private String tipo = "";
        private Produto produto = new Produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaTabela();
        }

        private void dataGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica se há pelo menos uma linha selecionada
                if (dataGridProdutos.SelectedRows.Count > 0)
                {
                    // Acessa a primeira linha selecionada (no caso de FullRowSelect)
                    DataGridViewRow selectedRow = dataGridProdutos.SelectedRows[0];

                    // Verifica se o valor não é nulo antes de preencher os TextBox
                    textBoxNome.Text = selectedRow.Cells["nome"].Value?.ToString();
                    textBoxId.Text = selectedRow.Cells["id"].Value?.ToString();
                    textBoxQuantidade.Text = selectedRow.Cells["quantidade"].Value?.ToString();
                    textBoxPreco.Text = Convert.ToDecimal(selectedRow.Cells["preco"].Value).ToString("F2"); // Formata o preço
                }
            } catch
            {

            }
        }

        //Efetua a ação de adicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(!verificaCamposAtribuicaoVazio())
                {
                    atribuirProduto();
                    produtoDAO.Inserir(produto);
                    carregaTabela();
                    esvaziarCampos();
                } else
                {
                    MessageBox.Show("Preencha os campos vazios para pdoer adicionar");
                }
                
            }
            catch (Exception ex) {
                MessageBox.Show($"ERRO ao adicionar: {ex.Message}");
            }
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            produtoDAO.Deletar(Convert.ToInt32(textBoxId.Text));
            carregaTabela();
            esvaziarCampos();
        }

        private void esvaziarCampos()
        {
            textBoxId.Text = string.Empty;
            textBoxPreco.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            textBoxQuantidade.Text = string.Empty;
        }

        //Todavez que uma CRUD ocorre é recarregado a tabela para exibir as novas informações 
        private void carregaTabela()
        {
            produtos = produtoDAO.carregarTabela();
            dataGridProdutos.DataSource = produtos;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!verificaCamposAtribuicaoVazio())
                {
                    atribuirProduto();

                    produtoDAO.Atualizar(produto);
                    carregaTabela();
                    esvaziarCampos();
                }
                else
                {
                    MessageBox.Show("Preencha os campos de atribuição para poder efetuar certa ação");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO ao atualizar: {ex.Message}");
            }
        }

        private void atribuirProduto()
        {
            
            produto.Codigo = Convert.ToInt32(textBoxId.Text);
            produto.Preco = Convert.ToDecimal(textBoxPreco.Text);
            produto.Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            produto.Nome = textBoxNome.Text;
            
        }

        private bool verificaCamposAtribuicaoVazio()
        {
            TextBox[] textBoxes = new TextBox[] { textBoxId, textBoxPreco, textBoxQuantidade};
            bool verificacao = false;
            foreach (TextBox textBox in textBoxes)
            {
                if(textBox.Text == String.Empty)
                {
                    verificacao = true;
                }
            }

            return verificacao;
        }

        private void verificaTipo()
        {
            if (radioNome.Checked)
            {
                tipo = "nome";
            }

            if (radioQuantidade.Checked)
            {
                tipo = "quantidade";
            }

            if (radioPreco.Checked)
            {
                tipo = "preco";
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String pesquisa = textBoxPesquisa.Text;
            
            verificaTipo();
            try
            {
                //Verifica se a pesquisa contem um ponto, enquanto o tipo é igual ao preco, ai manda uma excpetion
                if (pesquisa.Contains(".") && tipo.Equals("preco"))
                {
                    throw new Exception();
                }

                if (tipo.Equals("quantidade"))
                {
                    int quantidate = Convert.ToInt32(pesquisa);
                    pesquisa = quantidate.ToString();
                }

                if (tipo.Equals("preco"))
                {
                    decimal preco = Convert.ToDecimal(pesquisa);
                    pesquisa = preco.ToString("F2");
                }
                produtos = produtoDAO.Pesquisar(pesquisa, tipo);
                dataGridProdutos.DataSource = produtos;
            } catch (Exception ex)
            {
                MessageBox.Show("Formato inválido de pesquisa, certifique-se que esteja correto a pesquisa");
            }
            
            
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregaTabela();
        }
    }
    
}
