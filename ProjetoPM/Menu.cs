using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Microsoft.Win32;
using Modelo;

namespace ProjetoPM
{
    public partial class Menu : Form
    {
        int codigo;
        conexao cnx = new conexao();
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); //dados da tabela
            dt = cnx.obterdados("select * from produto"); //seleciona a tabela produto e popula os dados.
            int registros;//ler a quantidade de dados
            int x = 0, y = 0;//define a posição da tela

            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel();//criando o painel de produto
                produto.Location = new Point(x, y);//defino o local

                //borda do produto
                produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Height = 250;
                produto.Width = 250;

                Label idproduto = new Label(); //uma nova label id_produto
                idproduto.Name = "idproduto"; //nome da label
                idproduto.Text = dt.Rows[registros][0].ToString();//mostra o registro

                //crio a area de foto
                PictureBox foto = new PictureBox();//crio a area de foto
                foto.Location = new Point(20, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][4].ToString());

                //area do preco
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][3].ToString();
                preco.Location = new Point(20, 85);

                //area da descricao
                Label descproduto = new Label();
                descproduto.Name = "descricao";
                descproduto.Text = dt.Rows[registros][2].ToString();
                descproduto.Location = new Point(20, 55);

                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idproduto);
                //painel criado da caixa de ferramenta
                //adiciono cada produto da consulta ao painel 
                flowLayoutPanel1.Controls.Add(produto);
                //somando 100 a y
                y += 100;
                x = 0;
            }
            }

        private void preçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login go_login = new Login();
            go_login.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
