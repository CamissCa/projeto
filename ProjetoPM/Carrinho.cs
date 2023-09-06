using Controller;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPM
{
    public partial class Carrinho : Form
    {
        conexao cnx = new conexao();
        public Carrinho()
        {
            InitializeComponent();
        }


        private void Carrinho_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); //dados da tabela
            dt = cnx.obterdados("select p.id_produto, p.nome_prod, p.descricao, p.preco, p.foto from produto as p " +
                "left outer join carrinho as c on c.produto = p.id_produto;"); //seleciona a tabela produto e popula os dados.
            
            int registros;//ler a quantidade de dados
            int x = 0, y = 0;//define a posição da tela
            for (registros = 0; registros < dt.Rows.Count; registros++)
            {
                Panel produto = new Panel();//criando o painel de produto
                produto.Location = new Point(x, y);//defino o local

                //borda do produto
                produto.BorderStyle = BorderStyle.FixedSingle;
                produto.Height = 250;
                produto.Width = 400;

                //area do id
                Label idproduto = new Label(); //uma nova label id_produto
                idproduto.Name = "idproduto"; //nome da label
                idproduto.Text = dt.Rows[registros][0].ToString();//mostra o registro
                idproduto.Location = new Point(0, 1);
                produto.Controls.Add(idproduto);

                //area do nome
                Label nomeP = new Label();
                nomeP.Name = "descricao";
                nomeP.Text = dt.Rows[registros][1].ToString();
                nomeP.Location = new Point(293, 5);
                produto.Controls.Add(nomeP);

                //area da descricao
                Label descproduto = new Label();
                descproduto.Name = "descricao";
                descproduto.Text = dt.Rows[registros][2].ToString();
                descproduto.Location = new Point(293, 40);
                produto.Controls.Add(descproduto);

                //area do preco
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][3].ToString();
                preco.Location = new Point(293, 40);
                produto.Controls.Add(preco);

                //crio a area de foto
                 PictureBox foto = new PictureBox();//crio a area de foto
                 foto.Location = new Point(20, 0);
                 foto.SizeMode = PictureBoxSizeMode.StretchImage;
                 foto.Name = "foto";
                 foto.Size = new Size(230, 230);
                 foto.Image = Image.FromFile(dt.Rows[registros][4].ToString());
                 produto.Controls.Add(foto);

                flowLayoutPanel1.Controls.Add(produto);
                y = 0;
                x += 100;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

    }
}
