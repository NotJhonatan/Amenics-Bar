using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Model
{
    public partial class tb_venda_item
    {
        public string nm_usuario { get { return tb_venda.tb_usuario.nm_usuario; } }
        public string nm_produto{ get { return tb_estoque.nm_produto; } }
        public DateTime dt_saida { get { return tb_venda.dt_saida; } }
        public decimal vl_valorTotal { get { return tb_venda.vl_valorTotal; } }
    }
}
