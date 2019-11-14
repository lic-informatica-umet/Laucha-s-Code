using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParadigmasProgramacionParcial2.Enums;

namespace ParadigmasProgramacionParcial2.DTO
{
    public class Empleado : Persona
    {
        public Empleado(string legajo, string apellido, SexoEnum sexo, string dNI) : base(apellido, sexo, dNI)
        {
            Legajo = legajo;
        }

        public string Legajo { get; set; }

        public virtual float GetSueldo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.Apellido + " - $" + GetSueldo();
        }
    }
}
