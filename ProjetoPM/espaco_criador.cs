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
using Modelo;


namespace ProjetoPM
{
    public partial class espaco_criador : Form
    {
        //instancio o objeto produto
        ProdutoModelo pmodelo = new ProdutoModelo();
        ProdutoController pController = new ProdutoController();
        int codigoProduto;//identificar qual codigo
        conexao com = new conexao();//chama a classe conexão
        public espaco_criador()
        {
            InitializeComponent();
        }

        private void anunciar_Click(object sender, EventArgs e)
        {
            try //instanciar o objeto produto
            {
                pmodelo.nome_produto = TxtProduto.Text;
                pmodelo.descricao_prod = text_descricao.Text;
                pmodelo.preco_produto = Convert.ToDecimal(text_preco.Text);
                pmodelo.foto_produto = lblfoto.Text;
                if (pController.CadastrarProduto(pmodelo, 1) == true)
                    MessageBox.Show("Cadastro com sucesso");
                else
                    MessageBox.Show("Erro no cadastro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            this.Close();
            Login go_login = new Login();
            go_login.ShowDialog();
        }

       

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void espaco_criador_Load(object sender, EventArgs e)
        {

        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            try
            {
                //chamo a caixa de dialogo pra foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image File(*.jpg;*.png;*.gif)|*.jpg;*.png;*gif";
                if (foto.ShowDialog() == DialogResult.OK)
                {//mostra o nome da foto
                    lblfoto.Text = foto.FileName;
                    //caminho da imagem
                    Image arquivo = Image.FromFile(foto.FileName);
                    ptbfoto.Image = arquivo;//carrego a foto
                }
                else
                {
                    MessageBox.Show("Não escolheu a foto");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
         
        }

        private void lblfoto_Click(object sender, EventArgs e)
        {

        }

        private void ptbfoto_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Login go_Login = new Login();
            go_Login.ShowDialog();
            
        }

        private void text_preco_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
