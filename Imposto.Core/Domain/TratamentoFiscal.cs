using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain
{
    public class TratamentoFiscal
    {
        public int Id { get; set; }
        public string EstadoOrigem { get; set; }
        public string EstadoDestino { get; set; }
        public string Cfop { get; set; }
        public string TipoIcms { get; set; }
        public double AliquotaIcms { get; set; }
        public double AliquotaIpi { get; set; }
        public double ReducaoBaseIcms { get; set; }
        public bool Brinde { get; set; }
        public double Desconto { get; set; }
        public DateTime DataAlteracao { get; set; }       

    }
}
