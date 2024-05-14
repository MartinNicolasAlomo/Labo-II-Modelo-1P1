using System.Text;

namespace Logica
{

    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMB;


        public Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMB = tamanioMB;
        }


        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }

        public abstract int Tamanio
        {
            get;
        }


        public virtual string ObtenerInformacionApp()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Nombre: {nombre}")
                .AppendLine($"Sistema operativo: {sistemaOperativo.ToString()}")
                .AppendLine($"Tamaño: {Tamanio.ToString()}")
                ;
            return text.ToString();
        }

        public override string ToString()
        {
            return nombre;
        }

        public static bool operator ==(List<Aplicacion> listaApps, Aplicacion app)
        {
            if (listaApps.Count > 0 && app is not null)
            {
                foreach (Aplicacion appExistente in listaApps)
                {
                    if (app.nombre.Equals(appExistente.nombre, StringComparison.Ordinal))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(List<Aplicacion> listaApps, Aplicacion app)
        {
            return !(listaApps == app);
        }

        public static bool operator +(List<Aplicacion> listaApps, Aplicacion app)
        {
            if (listaApps != app)
            {
                listaApps.Add(app);
                return true;
            }
            return false;
        }

        public static implicit operator Aplicacion?(List<Aplicacion> listaApps)
        {
            Aplicacion? aplicacionMayorMB = null;
            bool flagPrimerIngreso = true;
            if (listaApps.Count > 0)
            {
                foreach (Aplicacion aplicacionExistente in listaApps)
                {
                    if (flagPrimerIngreso)
                    {
                        aplicacionMayorMB = aplicacionExistente;
                        flagPrimerIngreso = false;
                    }
                    else
                    {
                        if (aplicacionExistente.tamanioMB > aplicacionMayorMB?.tamanioMB)
                        {
                            aplicacionMayorMB = aplicacionExistente;
                        }
                    }
                }
            }
            return aplicacionMayorMB;
        }



    }
}
