using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class FluxoDeCaixaBusiness
    {
        Database.FluxoDeCaixaDatabase db = new Database.FluxoDeCaixaDatabase();
        public List<vw_fluxocaixa> FluxoDeCaixa()
        {
            List<vw_fluxocaixa>  lista = db.FluxoDeCaixa();

            return lista;
        }
    }
}
