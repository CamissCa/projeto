using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{


    public class UsuarioController
    {

       conexao con = new conexao();

        public bool cadastrar(UsuarioModelo usuario)
        {
            bool resultado = false;
            string sql ="insert into Cadastrar(nome,gmail,senha,id_perfil)"+"values('"+usuario.nome+"','"+usuario.gmail+"','"+usuario.senha +"','"+usuario.id_perfil+"')";
            MySqlConnection sqlCon = con.getconexao();
            sqlCon.Open();
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)
            { //executar o seu sql
                resultado = true;
            }
            
            
                sqlCon.Close();//fecho a conexao
                return resultado;//retorno o valor
            
        }

        public DataTable ObterDados(string sql)
        {
            //crio uma nova tabela de dados
            DataTable dt = new DataTable();
            //conn é a conexão com o banco de dados
            MySqlConnection conn = con.getconexao();
            conn.Open();//Abre o Banco de Dados
                        //Preparo o comando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            //tipo de instrução de texto
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            //Irá montar as informações da consulta
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt);//Montar a tabela de dados
            conn.Close();//fecho a conexao
            return dt;//retorna as informações da tabela
        }
    }
    }

