using Imposto.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public int Serie { get; set; }
        public string NomeCliente { get; set; }

        public string EstadoDestino { get; set; }
        public string EstadoOrigem { get; set; }

        public List<NotaFiscalItem> ItensDaNotaFiscal { get; set; }

        public NotaFiscal()
        {
            ItensDaNotaFiscal = new List<NotaFiscalItem>();
        }

        public string EmitirNotaFiscal(Pedido pedido)
        {
            // nº de NF será obtida através de um objeto SEQUENCE na procedure P_NOTA_FISCAL
            this.Serie = new Random().Next(Int32.MaxValue);
            this.NomeCliente = pedido.NomeCliente;

            this.EstadoDestino = pedido.EstadoDestino;
            this.EstadoOrigem = pedido.EstadoOrigem;

            foreach (PedidoItem itemPedido in pedido.ItensDoPedido)
            {
                NotaFiscalItem notaFiscalItem = new NotaFiscalItem();
                
                var tratFiscal = Repository.ObterTratamentoFiscal(this.EstadoOrigem, this.EstadoDestino, itemPedido.Brinde);

                if (tratFiscal.Id == 0)
                    return "Não foi encontrado nenhum Tratamento Fiscal para os Estados selecionados.";

                notaFiscalItem.Cfop = tratFiscal.Cfop;
                notaFiscalItem.TipoIcms = tratFiscal.TipoIcms;
                notaFiscalItem.AliquotaIcms = tratFiscal.AliquotaIcms;
                notaFiscalItem.AliquotaIpi = tratFiscal.AliquotaIpi;
                notaFiscalItem.ValorItemPedido = itemPedido.ValorItemPedido;
                notaFiscalItem.Brinde = itemPedido.Brinde;

                // Aplica desconto, caso haja
                if (tratFiscal.Desconto > 0)
                {
                    itemPedido.ValorItemPedido -= (itemPedido.ValorItemPedido * tratFiscal.Desconto) / 100;
                    notaFiscalItem.Desconto = tratFiscal.Desconto;
                }

                // Calcula ICMS / redução de base
                if (tratFiscal.ReducaoBaseIcms > 0)                
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido * tratFiscal.ReducaoBaseIcms;                 
                else                
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido;

                if (notaFiscalItem.AliquotaIcms > 0)
                    notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;      

                // Calcula IPI
                notaFiscalItem.BaseIpi = itemPedido.ValorItemPedido;

                if (notaFiscalItem.AliquotaIpi > 0)
                    notaFiscalItem.ValorIpi = notaFiscalItem.BaseIpi * notaFiscalItem.AliquotaIpi;
                
                notaFiscalItem.NomeProduto = itemPedido.NomeProduto;
                notaFiscalItem.CodigoProduto = itemPedido.CodigoProduto;

                ItensDaNotaFiscal.Add(notaFiscalItem);
                
            }
            return "";
        }
    }
}
