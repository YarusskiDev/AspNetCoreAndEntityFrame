using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }
        public string Nome { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int IdCategoria { get; set; }

        public virtual CategoriaProduto Categoria { get; set; }

        public virtual List<Imagem> Imagens { get; set; }

        public bool Ativo { get; set; }


    }
}
