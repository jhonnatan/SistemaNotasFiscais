using Imposto.Core.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteImposto.Testes
{
    [TestClass]
    public class UtilTeste
    {
        // método_condicao_resultadoEsperado
        [TestMethod]
        public void ValidaCliente_ClienteValido_RetornoTrue()
        {
            // Arrange            
            bool resultadoEsperado = true;

            // Act
            bool resultadoAtual = Util.ValidaCliente("Joao da Silva");

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }

        [TestMethod]
        public void ValidaCliente_ClienteInvalido_RetornoFalse()
        {
            // Arrange            
            bool resultadoEsperado = false;

            // Act
            bool resultadoAtual = Util.ValidaCliente("");

            // Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
