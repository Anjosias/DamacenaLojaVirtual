using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;


namespace Damacena.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestDamacena
    {
        [TestMethod]
        public void Take()
        {
            // O operador Take é usado para selecionar os primeiros N de uma coleção
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var resultado = from num in numeros.Take(5) select num;

                int [] teste = {1,2,3,5,6};

                CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }

        [TestMethod]

        public void Skip()
        {
            // O operador Skip ignora os primeiros objetos de uma coleção

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

                int[] teste = { 3, 4, 5 };
                CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
