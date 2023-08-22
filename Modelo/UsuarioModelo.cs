using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioModelo
    {
        
     

        //atributos Cadastro
        public string nome;
        public string gmail;
        public string senha;
        public string id_perfil;
        
        public UsuarioModelo()
    {
        //inicia os atributos nulo, sem valor
        nome = null;
        gmail = null;
        senha = null;   
        id_perfil = null;

    }
    }
}
