using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zentrix.ViewModel
{
    public class ViewIndicadorPerspectiva
    {
        public int IDIndicador { get; set; }
        public string nombre { get; set; }
        public string objetivoEstrategico { get; set; }
        public Nullable<decimal> target { get; set; }
        public Nullable<decimal> rojo { get; set; }
        public Nullable<decimal> amarillo { get; set; }
        public Nullable<decimal> verde { get; set; }
        public string fecha { get; set; }
        public string fechaFin { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin2 { get; set; }
    }
}