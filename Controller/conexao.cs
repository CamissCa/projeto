using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controller
{
    public class conexao
    {
        //atributos de conexão
        static private string servidor = "localhost";
        static private string bd = "avastore";
        static private string usuario = "root";
        static private string senhabd = "";
        public MySqlConnection conn = null;//minha conexao

        static private string caminho_cnx = "server= " + servidor + ";database= " + bd + ";user id =" + usuario + ";password= " + senhabd;

        public MySqlConnection getconexao()
        {
            //atribui conexão a uma nova conexão mysql com o caminho acima
            MySqlConnection conexao = new MySqlConnection(caminho_cnx);
            return conexao; //retorna o valor da conexão
        }
        public int cadastrar(int codigo, string[] campos, object[] valores, string sql)
        {
            int registro = 0;
            try//testa o cadastro
            {
                conn = getconexao();//chamo o metodo obter conexao
                conn.Open();//abro o banco direto
                //preparo o comando sql passando o SQL e a conexao
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //monto meu parametros do sql
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue("@id", codigo);
                }
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }//se houver erro
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();
            MySqlConnection sqlCon = getconexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            sqlCon.Close();
            return dt;

        }

    }
}
