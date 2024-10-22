using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Brindis_LGLA
{
    internal class Nodo
    {
        public int Valor;
        public Nodo Sig;

        public Nodo(int valor)
        {
            Valor = valor;
            Sig = null;
        }
    }
}
