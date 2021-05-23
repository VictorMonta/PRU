using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMA_PRU
{
    class CEmpleado
    {
        private int codigo;
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }     
       
        public double Sueldo { get => sueldo; set => sueldo = value; }


        public CEmpleado(int pCodigo, string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            this.codigo = pCodigo;
            this.nombre = pNombre;
            this.puesto = pPuesto;
            this.edad = pEdad;
            this.sueldo = pSueldo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}",codigo, nombre, puesto, edad, sueldo);

        }       

    }
}
