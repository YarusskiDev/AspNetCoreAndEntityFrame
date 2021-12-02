using CpmPedidosDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidosDomain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }

        public DateTime CriadoEm { get; set; }
        public TipoEnderecoEnum Tipo { get; set; }

        public string Logradouro { get; set; }

        public int Numero  { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public int IdCidade { get; set; }

        public virtual Cidade Cidade { get; set; }




    }
}
