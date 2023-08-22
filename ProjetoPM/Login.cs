using Controller;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ProjetoPM
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void btn_entrar_Click(object sender, EventArgs e)
        {


            conexao con = new conexao(); //chamando a minha conexão.
            string logar = "SELECT * FROM cadastrar WHERE gmail=@gmail AND senha=@senha";
            MySqlConnection cnx = con.getconexao();
            MySqlCommand cmd = new MySqlCommand(logar, cnx);
            cnx.Open();

            //comparando os dados do banco e do visual
            cmd.Parameters.AddWithValue("@gmail", txt_email.Text);
            cmd.Parameters.AddWithValue("@senha", txt_senha.Text);

          
            MySqlDataReader registro = cmd.ExecuteReader(); //executa a consulta.
            UsuarioModelo us = new UsuarioModelo(); //chamo a classe usuario modelo

            if (registro.HasRows)
            {
                registro.Read();
                us.gmail = Convert.ToString(registro["gmail"]);
                us.senha = Convert.ToString(registro["senha"]);
                us.id_perfil = Convert.ToString(registro["id_perfil"]);

                if(us.id_perfil == "cliente")
                {
                    this.Hide();
                    Menu go_menu = new Menu();
                    go_menu.ShowDialog();
                }
                if (us.id_perfil == "vendedor")
                {
                    this.Hide();
                    espaco_criador go_criador = new espaco_criador();
                    go_criador.ShowDialog();
                }

               
                

            }

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
           cadastrar go_cadastrar = new cadastrar();
            go_cadastrar.ShowDialog();
        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }


        private void paracadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cadastrar go_cadastrar = new cadastrar();
            go_cadastrar.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
