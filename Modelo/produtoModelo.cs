using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoModelo
    {
        //atributos produtos
        private int id_produto;
        private string nome_prod;
        private string descricao;
        private decimal preco;
        private string foto;

        public ProdutoModelo()
        {
            //inicializando os valores default
            this.id_produto = 0;
            this.nome_prod = "";
            this.descricao = "";
            this.preco = 0;
            this.foto = "";

        }
        public int codigo
        {
            //obter dados da variavel
            get { return id_produto; }
            //alterar dados da variavel
            set { id_produto = value; }
        }
        public string nome_produto
        {
            //obter dados da variavel
            get { return nome_prod; }
            //alterar dados da variavel
            set { nome_prod = value; }
        }

        public string descricao_prod
        {
            //obter dados da variavel
            get { return descricao; }
            //alterar dados da variavel
            set { descricao = value; }
        }

        public decimal preco_produto
        {
            //obter dados da variavel
            get { return preco; }
            //alterar dados da variavel
            set { preco = value; }
        }

        public string foto_produto
        {
            //obter dados da variavel
            get { return foto; }
            //alterar dados da variavel
            set { foto = value; }
        }
    }
}