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

             try
            {
                dataGridView1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("chora");
            }
            

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

                //area do nome
                Label nomeP = new Label();
                nomeP.Name = "descricao";
                nomeP.Text = dt.Rows[registros][1].ToString();
                nomeP.Location = new Point(20, 55);

                //crio a area de foto
                DataGridViewImageColumn col = new DataGridViewImageColumn();
                col.Name = "Imagem do Produto";
                dataGridView1.Columns["Imagem do Produto"].HeaderText = "col";
                dataGridView1.Columns["Imagem do Produto"].Width = 64;
                col.Image = Image.FromFile(dt.Rows[registros][4].ToString());
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridView1.Columns.Add(col);
                

                //area do preco
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][3].ToString();
                preco.Location = new Point(20, 85);
                CheckBox cb = new CheckBox();
                cb.Name = "ver_comp";

                //area da descricao
                Label descproduto = new Label();
                descproduto.Name = "descricao";
                descproduto.Text = dt.Rows[registros][2].ToString();
                descproduto.Location = new Point(20, 55);

                produto.Controls.Add(nomeP);
                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                produto.Controls.Add(cb);
                produto.Controls.Add(idproduto);
                y = 0;
                x += 100;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
