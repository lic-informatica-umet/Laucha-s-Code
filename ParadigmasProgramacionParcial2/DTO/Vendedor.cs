using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParadigmasProgramacionParcial2.Enums;

namespace ParadigmasProgramacionParcial2.DTO
{
    public class Vendedor : Empleado
    {
        public Vendedor(float sueldoBase, float montoVenta, float comisionVenta, string legajo, string apellido, SexoEnum sexo, string dni): base(legajo, apellido, sexo, dni)
        {
            SueldoBase = sueldoBase;
            MontoVenta = montoVenta;
            ComisionVenta = comisionVenta;
        }

        public float SueldoBase { get; set; }
        public float MontoVenta { get; set; }
        public float ComisionVenta { get; set; }

        public override float GetSueldo()
        {
            float sueldoNeto = SueldoBase + (MontoVenta * (ComisionVenta / 100));
            int sueldoEntero = (int)(sueldoNeto * 100);
            return (float)(sueldoEntero) / 100;
        }
    }
}
