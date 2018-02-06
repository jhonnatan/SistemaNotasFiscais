using Imposto.Core.Domain;
using Imposto.Core.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Imposto.Core.Service
{
    public class NotaFiscalService
    {
        public string GerarNotaFiscal(Domain.Pedido pedido)
        {            
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.EmitirNotaFiscal(pedido);
            if (!GerarXML(notaFiscal))
                return "ATENÇÃO! Ocorreu um erro ao gerar o arquivo XML. A Nota fiscal não foi salva.";
            notaFiscal.Id = Repository.GravarNotaFiscal(notaFiscal);
            notaFiscal.ItensDaNotaFiscal.ForEach(i => i.IdNotaFiscal = notaFiscal.Id);
            notaFiscal.ItensDaNotaFiscal.ForEach(i => Repository.GravarNotaFiscalItem(i));
            return "";
        }

        public bool GerarXML(Domain.NotaFiscal notaFiscal)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Domain.NotaFiscal));
                StreamWriter stream = new StreamWriter($"C:/ArquivosXML/NFe{notaFiscal.NumeroNotaFiscal}_{notaFiscal.NomeCliente}");
                serializador.Serialize(stream, notaFiscal);
                return true;
            }
            catch
            {
                return false;
            }
        }        
        
    }
}
