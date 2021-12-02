using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Nome { get; set; }

        public int IdEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }

        public bool Ativo { get; set; }


    }
}
