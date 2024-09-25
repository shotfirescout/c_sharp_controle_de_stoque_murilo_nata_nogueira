using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace c_sharp_controle_de_stoque_murilo_nata_nogueira
{
    internal class ProdutoDAO
    {
        private static string connectionString;


        //Esse carrega o json
        public ProdutoDAO()
        {
            carregarJson();
        }

        private void carregarJson()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "jsonconfig.json");
            var json = File.ReadAllText(filePath);
            var config = JsonConvert.DeserializeObject<DatabaseConfiguration>(json);

            connectionString = $"server = {config.Server}; database = {config.Database}; uid = {config.Uid}; password = {config.Password}";

        }

        //Adiciona um novo produto

        public void Inserir(Produto produto)
        {
            //Conecta no banco de dados que está listado dentro do Json
            using (MySqlConnection connectionDatabase = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO produtos (id, nome, quantidade, preco) values (@id,@nome, @quantidade, @preco)"; //A query para poder adicionar no banco de dados

                //Um commando de sql onde pega o Connection
                MySqlCommand commandoAdicionar = new MySqlCommand(query, connectionDatabase);

                //Os @ são parametros que substitui a necessidade de colocar + Parámetro 
                commandoAdicionar.Parameters.AddWithValue("@id", produto.Codigo);
                commandoAdicionar.Parameters.AddWithValue("@nome", produto.Nome);
                commandoAdicionar.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                commandoAdicionar.Parameters.AddWithValue("@preco", produto.Preco);

                //Verifica se a query deu certo
                try
                {
                    connectionDatabase.Open(); //Abre o banco de dados
                    commandoAdicionar.ExecuteNonQuery(); //Executa o commando
                    MessageBox.Show("Produto adicionado com sucesso!");
                    carregarTabela();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao adicionar produto: {ex.Message}");
                }
            }
        }

         public DataTable Pesquisar(String pesquisa, String tipo)
          {
            DataTable pesquisaProdutos = new DataTable();
            string query = "";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
             {
                try
                {
                    connection.Open();

                    switch (tipo)
                    {
                        case "preco":
                            query = "SELECT * FROM produtos WHERE preco = @pesquisa";
                            break;
                        case "nome":
                            query = "SELECT * FROM produtos WHERE nome LIKE @pesquisa";
                            break;
                        case "quantidade":
                            query = "SELECT * FROM produtos WHERE quantidade = @pesquisa";
                            break;
                    }

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if(tipo == "nome")
                    {
                        cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                    } else if (tipo == "preco")
                    {
                        cmd.Parameters.AddWithValue("@pesquisa", Convert.ToDecimal(pesquisa));
                    } else
                    {
                        cmd.Parameters.AddWithValue("@pesquisa", pesquisa);
                    }
                    

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    

                    adapter.Fill(pesquisaProdutos);
                }

                catch (Exception ex)
                {
                    throw new Exception("Erro ao listar produtos: " + ex.Message);
                }
            }

            return pesquisaProdutos;
          }
          

        public void Atualizar(Produto produto)
        {
            using (MySqlConnection connectionDatabase = new MySqlConnection(connectionString))
            {
                string query = "UPDATE produtos SET nome = @nome, quantidade = @quantidade, preco = @preco WHERE id = @id";

                //Um commando de sql onde pega o Connection
                MySqlCommand commandoAtualizar = new MySqlCommand(query, connectionDatabase);

                //Os @ são parametros que substitui a necessidade de colocar + Parámetro 
                commandoAtualizar.Parameters.AddWithValue("@nome", produto.Nome);
                commandoAtualizar.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                commandoAtualizar.Parameters.AddWithValue("@preco", produto.Preco);
                commandoAtualizar.Parameters.AddWithValue("@id", produto.Codigo);

                //Verifica se a query deu certo
                try
                {
                    connectionDatabase.Open(); //Abre o banco de dados
                    commandoAtualizar.ExecuteNonQuery(); //Executa o commando
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao atualizar produto: {ex.Message}");
                }
            }
        }

        //Deleta um produto
        public void Deletar(int id)
        {
            using (MySqlConnection connectionDatabase = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM produtos WHERE id = @id";

                MySqlCommand commandoRemover = new MySqlCommand(query, connectionDatabase);

                commandoRemover.Parameters.AddWithValue("@id", id);

                try
                {
                    connectionDatabase.Open();
                    commandoRemover.ExecuteNonQuery();
                    MessageBox.Show("Produto removido com sucesso!");
                    carregarTabela();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao deletar produto{ex.Message}");
                }

            }

        }

       public DataTable carregarTabela()
        {
            DataTable dataTabela = new DataTable();
            using (MySqlConnection connectionDatabase = new MySqlConnection(connectionString))
            {
                try
                {
                    connectionDatabase.Open();
                    string query = "SELECT * FROM produtos";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionDatabase);

                    adapter.Fill(dataTabela);
                }

                catch (Exception ex)
                {
                    throw new Exception("Erro ao listar produtos: " + ex.Message);
                }


            }

            return dataTabela;
        }
       
    }

}
