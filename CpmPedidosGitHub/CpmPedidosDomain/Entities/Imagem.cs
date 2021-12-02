using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Imagem
    {

        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public string Nome { get; set; }

        public string NomeDoArquivo { get; set; }

        public bool Principal { get; set; }
    }
}
