using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class VendaProduto
    {
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }
        public int Quantidade { get; set; }
    }
}
