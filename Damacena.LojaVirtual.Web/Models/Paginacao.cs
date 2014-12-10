using System;

namespace Damacena.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public int TotaldeItens { get; set; }

        public int ItensPorPagina { get; set; }

        public int PaginaAtual { get; set; }

        public int TotaldePagina 
        {
            get { return (int) Math.Ceiling((decimal) TotaldeItens/ItensPorPagina);}

        }
    }
}