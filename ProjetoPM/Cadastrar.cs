using Controller;
using Google.Protobuf.WellKnownTypes;
using Modelo;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoPM
{
    public partial class cadastrar : Form
    {


        public cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textgmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttoncad_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "cliente" || comboBox1.Text == "vendedor")
            {

                UsuarioModelo gravadado = new UsuarioModelo();
                gravadado.nome = textname.Text;
                gravadado.gmail = textgmail.Text;
                gravadado.senha = textsenha.Text;
                gravadado.id_perfil = comboBox1.Text;



                UsuarioController uscontrole = new UsuarioController();

                if (gravadado.nome != "" && gravadado.senha != "")
                {
                    if (uscontrole.cadastrar(gravadado) == true)
                    {
                        MessageBox.Show("Usuário" + textname.Text + "cadastrado com sucesso");

                        //para a próxima tela
                        this.Hide();
                        Login go_login = new Login();
                        go_login.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Campos estão vazios");
                    }
                }
                
            }else
                {
                    MessageBox.Show("escolha um usuário válido");
                }

        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login go_login = new Login();
            go_login.ShowDialog();
        }
    }

    }

    

