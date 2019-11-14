using ParadigmasProgramacionParcial2.DTO;
using ParadigmasProgramacionParcial2.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParadigmasProgramacionParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Empresa empresa = new Empresa("Horacio Records");

        private void BtnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            LstEmpleados.Items.Clear();
            foreach (var empleado in empresa.Empleados)
            {
                LstEmpleados.Items.Add(empleado.ToString());
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (AreEmptyFields())
            {
                MessageBox.Show("Aún hay campos vacios");
            }
            else
            {
                try
                {
                    string legajo = TxtLegajo.Text;
                    string apellido = TxtApellido.Text;
                    SexoEnum sexo = (SexoEnum)CboSexo.SelectedIndex;
                    string dni = TxtDni.Text;

                    if (RadOperario.Checked)
                    {
                        float cantidadHoras = float.Parse(TxtCantHoras.Text);
                        float valorHora = float.Parse(TxtValorHora.Text);

                        Operario operario = new Operario(cantidadHoras, valorHora, legajo, apellido, sexo, dni);
                        TxtSueldoLiquidar.Text = "$" + operario.GetSueldo();

                        empresa.Empleados.Add(operario);
                    }

                    else if (RadVendedor.Checked)
                    {
                        float sueldoBase = float.Parse(TxtSueldoBasico.Text);
                        float montoVenta = float.Parse(TxtMontoVendido.Text);
                        float comisionVenta = float.Parse(TxtPorcentaje.Text);

                        Vendedor vendedor = new Vendedor(sueldoBase, montoVenta, comisionVenta, legajo, apellido, sexo, dni);
                        TxtSueldoLiquidar.Text = "$" + vendedor.GetSueldo();

                        empresa.Empleados.Add(vendedor);
                    }

                    TxtSueldoLiquidarTotal.Text = "$" + empresa.GetSueldoTotal();
                    MessageBox.Show("El empleado ha sido agregado exitosamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                CleanFields();
            }


        }

        private bool AreEmptyFields()
        {
            if (RadOperario.Checked)
            {
                return (
                    string.IsNullOrWhiteSpace(TxtLegajo.Text) || string.IsNullOrWhiteSpace(TxtApellido.Text) || string.IsNullOrWhiteSpace(TxtDni.Text) ||
                    string.IsNullOrWhiteSpace(TxtCantHoras.Text) || string.IsNullOrWhiteSpace(TxtValorHora.Text)
                    );
            }
            else if (RadVendedor.Checked)
            {

                return (
                    string.IsNullOrWhiteSpace(TxtLegajo.Text) || string.IsNullOrWhiteSpace(TxtApellido.Text) || string.IsNullOrWhiteSpace(TxtDni.Text) ||
                    string.IsNullOrWhiteSpace(TxtMontoVendido.Text) || string.IsNullOrWhiteSpace(TxtSueldoBasico.Text) || string.IsNullOrWhiteSpace(TxtPorcentaje.Text)
                    );
            }
            else
            {
                return true;
            }
        }

        public void CleanFields()
        {
            TxtLegajo.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            TxtDni.Text = string.Empty;

            RadOperario.Checked = false;
            RadVendedor.Checked = false;

            TxtCantHoras.Text = string.Empty;
            TxtValorHora.Text = string.Empty;

            TxtSueldoBasico.Text = string.Empty;
            TxtMontoVendido.Text = string.Empty;
            TxtPorcentaje.Text = string.Empty;
        }



        private void RadOperario_CheckedChanged(object sender, EventArgs e)
        {
            TxtCantHoras.Enabled = RadOperario.Checked;
            TxtValorHora.Enabled = RadOperario.Checked;
        }

        private void RadVendedor_CheckedChanged(object sender, EventArgs e)
        {
            TxtSueldoBasico.Enabled = RadVendedor.Checked;
            TxtMontoVendido.Enabled = RadVendedor.Checked;
            TxtPorcentaje.Enabled = RadVendedor.Checked;
        }
    }
}
