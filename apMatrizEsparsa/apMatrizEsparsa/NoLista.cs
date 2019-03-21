using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizEsparsa
{
    class NoLista<Dado> 
    {
        Dado info;
        NoLista<Dado> prox;

        public Dado Info { get => info; set => info = value;  }
        internal NoLista<Dado> Prox { get => prox; set => prox = value; }

        public NoLista(Dado info, NoLista<Dado> prox, NoLista<Dado> ant)
        {
            Info = info;
            Prox = prox;
        }
    }
}
