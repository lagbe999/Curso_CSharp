using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_51_Interfaces
{
    class AvisosTrafico: IAvisos
    {
    
        public AvisosTrafico()
        {
            remitente = "SOAT";

            mensaje = "Infracción Cometida. Pague antes de 15 días y Obtendrá Descuento del 50%";

            fecha = "";

        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;

            this.mensaje = mensaje;

            this.fecha = fecha;

        }


        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} Ha sido enviado Por {1}, el día {2} ", mensaje, remitente, fecha);
        }

        private string remitente ;

        private string mensaje;

        private string fecha;



    }

}
