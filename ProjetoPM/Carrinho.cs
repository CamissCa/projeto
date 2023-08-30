using Controller;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dt = cnx.obterdados("select * from carrinho inner join produto on produto.id_produto = carrinho.produto;"); //seleciona a tabela produto e popula os dados.
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
                idproduto.Text = dt.Rows[registros][2].ToString();//mostra o registro

                /* //crio a area de foto
                 PictureBox foto = new PictureBox();//crio a area de foto
                 foto.Location = new Point(20, 0);
                 foto.SizeMode = PictureBoxSizeMode.StretchImage;
                 foto.Name = "foto";
                 foto.Image = Image.FromFile(dt.Rows[registros][4].ToString());*/

                //area do preco
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][5].ToString();
                preco.Location = new Point(20, 85);
                CheckBox cb = new CheckBox();
                cb.Name = "ver_comp";
                //area da descricao
                Label descproduto = new Label();
                descproduto.Name = "descricao";
                descproduto.Text = dt.Rows[registros][4].ToString();
                descproduto.Location = new Point(20, 55);

                produto.Controls.Add(descproduto);
                produto.Controls.Add(preco);
                //produto.Controls.Add(foto);
                produto.Controls.Add(cb);
                produto.Controls.Add(idproduto);
                pcarrinho.Controls.Add(produto);
                y = 0;
                x += 100;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int infoC = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            MessageBox.Show("Produto: " + infoC.ToString());
           // idproduto.Name = "idproduto"; //nome da label
           // idproduto.Text = dt.Rows[registros][2].ToString();//mostra o registro

        }
    }
}
