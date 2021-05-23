using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMA_PRU
{
    class Program
    {
        static void Main(string[] args)            
        {
            CEmpleado empleado = new CEmpleado(1,"Victor", "Diseño", 24, 1800);
            Console.WriteLine(empleado);    
            
            Console.WriteLine(CImpuesto.CalcularImpuesto(empleado));
            
            CImpuesto.PagarImpuesto(empleado);
            Console.ReadLine();
        }
        
    }
}
