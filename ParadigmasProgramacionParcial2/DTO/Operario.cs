using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParadigmasProgramacionParcial2.Enums;

namespace ParadigmasProgramacionParcial2.DTO
{
    public class Operario : Empleado
    {
        public Operario(float horasMensuales, float valorHora, string legajo, string apellido, SexoEnum sexo, string dni) : base(legajo, apellido, sexo, dni)
        {
            HorasMensuales = horasMensuales;
            ValorHora = valorHora;
        }

        public float HorasMensuales { get; set; }
        public float ValorHora { get; set; }

        public override float GetSueldo()
        {
            return HorasMensuales * ValorHora;
        }
    }
}
