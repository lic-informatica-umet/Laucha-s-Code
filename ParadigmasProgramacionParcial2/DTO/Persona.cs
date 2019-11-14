using ParadigmasProgramacionParcial2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadigmasProgramacionParcial2.DTO
{
    public class Persona
    {
        public Persona(string apellido, SexoEnum sexo, string dni)
        {
            Apellido = apellido;
            Sexo = sexo;
            DNI = dni;
        }

        public string Apellido { get; set; }
        public SexoEnum Sexo { get; set; }
        public string DNI { get; set; }

        public override string ToString()
        {
            return Apellido;
        }
    }
}
