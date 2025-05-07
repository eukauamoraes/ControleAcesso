using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            string strConn = @"server=localhost;database=ControleAcesso;user=root;password=";
            MySqlConnection cn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return cmd;
        }
    }
}


// testando







