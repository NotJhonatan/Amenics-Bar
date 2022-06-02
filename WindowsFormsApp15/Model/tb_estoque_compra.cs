using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Model
{
    public partial class tb_estoque
    {
        public string nm_produto { get { return tb_produto.nm_produto; } }
        public string nm_categoria { get { return tb_produto.ds_categoria; } }
        public decimal vl_valor { get { return tb_produto.vl_valor; } }
    }
}
