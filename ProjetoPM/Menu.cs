using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Microsoft.Win32;
using Modelo;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

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
                produto.Width = 566;

                //area do id
                Label idproduto = new Label();
                idproduto.Text = dt.Rows[registros][0].ToString();
                idproduto.Location = new Point(20, 55);

                //area do nome
                Label nomeP = new Label();
                nomeP.Name = "nome";
                nomeP.Text = dt.Rows[registros][1].ToString();
                nomeP.Location = new Point(393, 5);

                //area da descricao
                Label descproduto = new Label();
                descproduto.Name = "descricao";
                descproduto.Text = dt.Rows[registros][2].ToString();
                descproduto.Location = new Point(393, 40);

                //area do preco
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][3].ToString();
                preco.Location = new Point(393, 220);
                CheckBox cb = new CheckBox();
                cb.Name = "ver_comp";
                
                //crio a area de foto
                 PictureBox foto = new PictureBox();//crio a area de foto
                 foto.Location = new Point(20, 0);
                 foto.SizeMode = PictureBoxSizeMode.StretchImage;
                 foto.Name = "foto";
                foto.Size = new Size(230, 230);
                 foto.Image = Image.FromFile(dt.Rows[registros][4].ToString());


                //craindo e modificando botão
                Button registrar = new Button();
                registrar.Name = "Selecionar";


                // Image.FromFile("C:\\Users\\aluno\\Downloads\\pare.png");
                registrar.Click += new EventHandler((sender1, e1) => SelecionarClick(sender1, e1, idproduto.Text));
                registrar.Location = new Point(20, 150);

                produto.Controls.Add(nomeP);
                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(cb);
                produto.Controls.Add(idproduto);
                produto.Controls.Add(registrar);

                //painel criado da caixa de ferramenta
                //adiciono cada produto da consulta ao painel
                flowLayoutPanel1.Controls.Add(produto);
                //somando 100 a y
                y += 100;
                x = 0;
            }
        }

        private void SelecionarClick(object sender, EventArgs e, string Id)
        {
            var result = MessageBox.Show("Adicionar produto ao carrinho?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string sql = "insert into carrinho(produto)" + "values(" + Convert.ToInt32(Id) + ")";
                MySqlConnection sqlCon = cnx.getconexao();
                sqlCon.Open();
                MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
                cmd.ExecuteNonQuery();
                sqlCon.Close();

                MessageBox.Show("foi?");

                Carrinho go_carrinho = new Carrinho();
                go_carrinho.ShowDialog();
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

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrinho go_carrinho = new Carrinho();
            go_carrinho.ShowDialog();
        }
    }
}