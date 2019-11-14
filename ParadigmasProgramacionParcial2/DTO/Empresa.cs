using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmasProgramacionParcial2.DTO
{
    public class Empresa
    {
        public Empresa(string nombre)
        {
            Nombre = nombre;
            Empleados = new List<Empleado>();

        }

        public Empresa(string nombre, List<Empleado> empleados)
        {
            Nombre = nombre;
            Empleados = empleados;
        }

        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }

        public float GetSueldoTotal()
        {
            float sueldoTotal = 0;

            foreach (var empleado in Empleados)
            {
                if (empleado is Vendedor)
                {
                    sueldoTotal += ((Vendedor)empleado).GetSueldo();
                }
                else
                {
                    sueldoTotal += ((Operario)empleado).GetSueldo();
                }
            }

            //Se limita a 2 decimales
            int sueldoEntero = (int)(sueldoTotal * 100);
            return (float)(sueldoEntero) / 100;
        }
    }
}
