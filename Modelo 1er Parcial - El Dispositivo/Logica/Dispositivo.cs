using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appsInstaladas;
        private static SistemaOperativo sistemaOperativo;


        static Dispositivo()
        {
            appsInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }


        public static bool InstalarApp(Aplicacion app)
        {
            //if (app is not null && app.SistemaOperativo == sistemaOperativo && appsInstaladas+app)
            //{
            //    return true;
            //}
            return app is not null && app.SistemaOperativo == sistemaOperativo && appsInstaladas + app;
        }

        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Sistema Operativo: {sistemaOperativo}")
                ;
            foreach (Aplicacion aplicacion in appsInstaladas)
            {
                if (aplicacion is not null)
                {
                    text.AppendLine(aplicacion.ObtenerInformacionApp())
                        ;
                }
            }
            return text.ToString();
        }



    }
}
