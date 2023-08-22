using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProdutoController
    {
        bool resultado = false; //crio um método booliano
        conexao cnx = new conexao();

        public bool CadastrarProduto(ProdutoModelo prod, int operacao)
        {
            bool resultado = false;
            string sql = sql = "insert into produto(id_produto,nome_prod,descricao,preco,foto)" + 
            "values('" + prod.codigo+ "','" + prod.nome_produto + "','" + prod.descricao_prod + "','" + prod.preco_produto + "','" + prod.foto_produto + "')";

            MySqlConnection sqlCon = cnx.getconexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)
            { //executar o seu sql
                resultado = true;
            }


            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }
    }
}

