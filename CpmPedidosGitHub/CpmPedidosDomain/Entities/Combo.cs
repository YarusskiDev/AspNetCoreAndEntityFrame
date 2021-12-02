using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Combo
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int IdImagem { get; set; }

        public virtual Imagem Imagem { get; set; }

        public List<Produto> Produtos { get; set; }

        public bool Ativo { get; set; }

    }
}
