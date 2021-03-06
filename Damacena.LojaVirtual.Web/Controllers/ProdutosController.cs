﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Damacena.LojaVirtual.Dominio.Repositorio;

namespace Damacena.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        public ActionResult ListarProdutos( int paginas = 1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((paginas - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);

            return View(produtos);
        }
    }
}