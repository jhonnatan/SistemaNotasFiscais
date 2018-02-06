using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Imposto.Core.Domain;

namespace TesteImposto.Testes
{
    [TestClass]
    public class NotaFiscalTeste
    {
        public Pedido CriarPedido(string cliente, string ufOrigem, string ufDestino)
        {
            // Cria um Pedido básico para simular nos testes
            Pedido pedido = new Pedido();
            pedido.EstadoOrigem = ufOrigem;
            pedido.EstadoDestino = ufDestino;
            pedido.NomeCliente = cliente;

            var boolValue = false;
            pedido.ItensDoPedido.Add(
                new PedidoItem()
                {
                    Brinde = boolValue,
                    CodigoProduto = "1111.1111",
                    NomeProduto = "Produto1",
                    ValorItemPedido = 50.99
                });
            return pedido;
        }

        // método_condicao_resultadoEsperado
        [TestMethod]
        public void EmitirNota_QuandoPassarUFsIguais_NaodeveExistirMsgDeRetorno()
        {
            // Arrange
            NotaFiscal notaFiscal = new NotaFiscal();
            Pedido pedido = CriarPedido("Maria", "MG", "MG");
            string resultadoEsperado = "";

            // Act
            string resultadoAtual = notaFiscal.EmitirNotaFiscal(pedido);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void EmitirNota_QuandoPassarUFsDiferentes_NaodeveExistirMsgDeRetorno()
        {
            // Arrange
            NotaFiscal notaFiscal = new NotaFiscal();
            Pedido pedido = CriarPedido("Maria", "SP", "RJ");
            string resultadoEsperado = "";

            // Act
            string resultadoAtual = notaFiscal.EmitirNotaFiscal(pedido);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }        
}
