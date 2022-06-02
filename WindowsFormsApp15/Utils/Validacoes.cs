using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Utils
{
    class Validacoes
    {
        public static bool ValidarCPF(string cpf)
        {
            Regex regex = new Regex("^$");

            if (regex.IsMatch(cpf) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
