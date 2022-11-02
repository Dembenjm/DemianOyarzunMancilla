using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DemianOyarzunMancilla
{
    public class Atencion
    {
        private string tipoatencion;
        private string fecha;
        private string hora;
        private Cliente clienteatencion;

        public string TipoAtencion
        {
            get { return tipoatencion; }
            set { tipoatencion = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Cliente ClienteAtencion
        {
            get { return clienteatencion; }
            set { clienteatencion = value; }
        }
    }
}
