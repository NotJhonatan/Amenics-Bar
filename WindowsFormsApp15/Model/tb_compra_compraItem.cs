using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Model
{
    public partial class tb_compra_item
    {
        public string nm_produto { get { return tb_produto.nm_produto; } }
        public DateTime dt_compra { get { return tb_compra.dt_compra; } }
        public decimal vl_valorTotal { get { return tb_compra.vl_valorTotal; } }
    }
}
