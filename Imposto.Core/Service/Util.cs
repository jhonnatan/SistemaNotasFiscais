using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Service
{
    public class Util
    {
        public static bool ValidaCliente(string cliente)
        {
            return !string.IsNullOrEmpty(cliente);                                
        }

        public static bool ValidaUF(string uf)
        {
            if (string.IsNullOrEmpty(uf))
                return false;

            return new string[]
            {
                "AC", "AL", "AP", "AM", "BA",
                "CE", "DF", "ES", "GO", "MA",
                "MT", "MS", "MG", "PA", "PB",
                "PR", "PE", "PI", "RJ", "RN",
                "RS", "RO", "RR", "SC", "SP",
                "SE", "TO"
            }.Contains(uf.ToUpper());
        }
    }
}
