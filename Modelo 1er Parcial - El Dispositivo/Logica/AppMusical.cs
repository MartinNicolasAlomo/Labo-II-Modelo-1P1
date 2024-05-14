using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;


        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
             : this(nombre, sistemaOperativo, tamanioMB, new List<string>())
        {
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB, List<string> listaCanciones)
             : base(nombre, sistemaOperativo, tamanioMB)
        {
            if (listaCanciones is not null)
            {
                this.listaCanciones = listaCanciones;
            }
            else
            {
                this.listaCanciones = new List<string>();
            }
        }


        public override int Tamanio
        {
            get { return tamanioMB + (listaCanciones.Count * 2); }
        }


        public override string ObtenerInformacionApp()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"{base.ObtenerInformacionApp()}").AppendLine()
                .AppendLine("Lista de canciones:")
                ;
            foreach (string cancion in listaCanciones)
            {
                text.AppendLine($"{cancion}")
                ;
            }
            return text.ToString();
        }



    }
}
