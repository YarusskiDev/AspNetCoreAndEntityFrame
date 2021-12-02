using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public string Numero { get; set; }

        public decimal ValorTotal { get; set; }

        public TimeSpan Entrega { get; set; }

        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual List<ProdutoPedido> Produtos { get; set; }

    }
}
