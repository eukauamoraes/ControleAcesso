using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso
{
    class RegistrodeEntrada
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime DataHora { get; set; }

        public string TipoOperacao { get; set; }
    }
}
