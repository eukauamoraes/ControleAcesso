using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso
{
    class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string TipoUsuario { get; set; }

        public string Senha { get; set; }


        //Contrutores
        public Usuario() { }
        
        public Usuario(int id,string nome, string cpf, string tipousuario,string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipousuario;
            Senha = senha;

        }
        public Usuario(string nome, string cpf, string tipousuario, string senha)
        {

            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipousuario;
            Senha = senha;
        }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public Usuario(string nome)
        {
            Nome = nome;
        }
        //metodos da classe
        public static Usuario OberterPorId(int id)
        {
            Usuario  usuario = new();
            var cmd = Banco.Abrir ();
            cmd.commandType = CommandType.Text;


        }
    }
}
