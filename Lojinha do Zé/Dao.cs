using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lojinha_do_Zé
{
    public class Campos
    {
        public int id;
        public string nome;
        public string desc;
        public decimal precoUni;
        public int contEstoque;
    }

    public class Dao
    {
        public Dao()
        {
        }

        public bool testeConsulta;

        public Campos campos = new Campos();

        public MySqlConnection minhaConexao;

        public string usuarioBD = "root";
        public string senhaBd = "ninjah12";
        public string servidor = "localhost";
        string bancoDados;
        string tabela;

        public void conecte(string BancoDados, string Tabela)
        {
            bancoDados = BancoDados;
            tabela = Tabela;
            minhaConexao = new MySqlConnection("server=" + servidor + "; database=" + bancoDados +
                                                "; uid=" + usuarioBD + "; password=" + senhaBd);
        }

        void Abrir()
        {
            minhaConexao.Open();
        }
        void Fechar()
        {
            minhaConexao.Close();
        }

        public void PreencherTabela(System.Windows.Forms.DataGridView dgv)
        {
            Abrir();

            MySqlDataAdapter meuAdapter = new MySqlDataAdapter("Select * From " + tabela, minhaConexao);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.Clear();
            meuAdapter.Fill(dataSet, tabela);
            dgv.DataSource = dataSet;
            dgv.DataMember = tabela;

            Fechar();
        }

        public void Consulta(string campoNome)
        {
            testeConsulta = false;
            // Sobrecarga do método de consulta para permitir consulta por id tambem
            Abrir();

            MySqlCommand comando = new MySqlCommand("select * from " + tabela + " where Nome = '" + campoNome + "'", minhaConexao);
            MySqlDataReader dtReader = comando.ExecuteReader();

            if (dtReader.Read())
            {
                campos.id = int.Parse(dtReader["CodigoProd"].ToString());
                campos.nome = dtReader["Nome"].ToString();
                campos.desc = dtReader["Descrição"].ToString();
                campos.precoUni = decimal.Parse(dtReader["Preço_un"].ToString());
                campos.contEstoque = int.Parse(dtReader["Quantidade_Estoque"].ToString());
                testeConsulta = true;
            }
            else
            {
                MessageBox.Show("Item não Encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Fechar();
        }

        public int NumRegistro()
        {
            Abrir();

            //Max retorna o num do ultimo valor do id
            MySqlCommand comando = new MySqlCommand("Select max(CodigoProd) from " + tabela, minhaConexao);

            //ExecuteScalar retorna um dado do tipo object, é preciso converter para string
            string n = comando.ExecuteScalar().ToString();

            //Agora convertemos o dado para int e somamos um para obter o numero do proximo registro
            int num = int.Parse(n) + 1;

            Fechar();

            return num;
        }

        public void Inserir(string campoNome, string campoDesc, decimal campoPreco, int campoQuantEstoque)
        {
            Abrir();

            MySqlCommand comando = new MySqlCommand("INSERT INTO " + tabela + "(Nome, Descrição, Preço_un, Quantidade_Estoque) " +
                "VALUES (@nome, @descricao, @preco, @quantidade)", minhaConexao);

            comando.Parameters.AddWithValue("@nome", campoNome);
            comando.Parameters.AddWithValue("@descricao", campoDesc);
            comando.Parameters.AddWithValue("@preco", campoPreco);
            comando.Parameters.AddWithValue("@quantidade", campoQuantEstoque);

            comando.ExecuteNonQuery();

            Fechar();
        }
    }
}
