using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class AppJuegos : Aplicacion
    {
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB) 
             : base(nombre, sistemaOperativo, tamanioMB)
        {
        }

        public override int Tamanio
        {
            get { return tamanioMB; }
        }



    }
}
