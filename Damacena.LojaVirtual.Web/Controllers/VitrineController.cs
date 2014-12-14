using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.UI.WebControls;
using Damacena.LojaVirtual.Dominio.Repositorio;
using Damacena.LojaVirtual.Web.Models;

namespace Damacena.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
            
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 8;

        
        public ActionResult ListarProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            //Pegando as informações da Model ProdutosViewModel
            ProdutosViewModel model = new ProdutosViewModel
            {
                Produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                // Acessando o banco para montar a paginação
                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    TotaldeItens = _repositorio.Produtos.Count()
                }

            };

            return View(model);
        }
    }
}