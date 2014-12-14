using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web;
using Damacena.LojaVirtual.Web.Models;
using Damacena.LojaVirtual.Web.HtmlHelpers;


namespace Damacena.LojaVirtual.UnitTest
{
   
    [TestClass]
    public class UnitTestDamacena
    {

        #region Teste Take
        [TestMethod]
        public void Take()
        {
            //O operador Take é usado para selecionar os primeiros n objetos de uma coleção.
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var resultado = from num in numeros.Take(5) select num;

                int [] teste = {1,2,3,5,6};

                CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }
    #endregion
        
        #region Skip
        [TestMethod]

        public void Skip()
        {
            //O operador Skip ignora o(s) primeiro(s) n objetos de uma coleção.

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

                int[] teste = { 3, 4, 5 };
                CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
        #endregion

        #region TestePaginação

        [TestMethod]
        public void TestePaginacaoSeGeraCorretamente()
        {
            //Arrange - Montando a estrutura
            HtmlHelper htmlHelper = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                TotaldeItens = 28,
                ItensPorPagina = 8
            };
   
            Func<int, string> paginaUrl = i => "Pagina" + i;
         

            // Act = Ação dos objetos criados no Arrange
            MvcHtmlString resultado = htmlHelper.PageLinks(paginacao, paginaUrl);

        
            //Assert = Testando
               
            Assert.AreEqual(
         
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
            );
        
        }
        #endregion
    }
}
