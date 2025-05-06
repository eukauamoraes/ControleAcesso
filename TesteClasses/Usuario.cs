using ControleAcesso.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    public class Usuario
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Cpf { get; set; }

        public string? TipoUsuario { get; set; }

        public string? Senha { get; set; }
        public bool Ativo { get; set; }


        //Contrutores
        public Usuario() { }
        
        public Usuario(int id,string nome, string cpf, string tipousuario,string senha, bool ativo)
            
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipousuario;
            Senha = senha;
            Ativo = ativo;

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
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM usuarios WHERE id = {id}";

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    usuario = new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetBoolean(5)
                    );
                }
            }

            return usuario;
        }

        public static List<Usuario> ObterLista()
        {
            List<Usuario> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetBoolean(5)
                    )
                );
            }
            return lista;

        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert usuarios (nome , cpf, tipo_usuario, senha, ativo) " +
             $"values ('{Nome}','{Cpf}','{TipoUsuario}',md5('{Senha}'), )";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static void Arquivar(int id)
        {
            var usuario = ObterPorId(id);
            if (usuario.Ativo)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update usuarios set ativo = 0 where id =  {id}";
                cmd.ExecuteNonQuery();
            }

        }
        public static void Restaurar(int id)
        {

            var usuario = ObterPorId(id);
            if (!usuario.Ativo)
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update usuarios set ativo = 1 where id =  {id}";
                cmd.ExecuteNonQuery();
            }

        }
        public void Alterar() // Altera só o nome
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set nome = '{Nome}' where id = {Id}";
            cmd.ExecuteNonQuery();
        }
        public static Usuario EfetuarLogin(string nome, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM usuarios WHERE nome = @nome AND senha = MD5(@senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);

            using (var dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    usuario.Id = dr.GetInt32(0);
                    usuario.Nome = dr.GetString(1);
                    usuario.Cpf = dr.GetString(2);
                    usuario.TipoUsuario = dr.GetString(4);
                    usuario.Ativo = dr.GetBoolean(5);
                }
            }

            return usuario;
        }

        
        public void ValidarLogin()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert usuarios (nome, email, senha, ativo) " +
                $"values ('{Nome}','{Cpf}',md5('{TipoUsuario}'), default)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            //ncessario para validar Login
        }

    }
}
           
