using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Contract
{
    public interface IBook
    {
        List<Book> GrazinaVisuKnyguSarasa();
       void GrazintiPagalId(int id);
        void PridetiNaujaKnyga();
        void AtnaujantiKnyga();
        void IstrintiKnygaPagalID();


    }
}
