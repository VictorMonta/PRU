using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMA_PRU
{
    class CImpuesto
    {
        public static double CalcularImpuesto(CEmpleado pEmpleado)
        {
            double cal = (pEmpleado.Sueldo * 0.35);
            return cal;
            
        }
        public static void PagarImpuesto(CEmpleado pEmpleado)
        {
            double imp = CalcularImpuesto(pEmpleado);
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, pEmpleado.Nombre);
        }
    }
}
