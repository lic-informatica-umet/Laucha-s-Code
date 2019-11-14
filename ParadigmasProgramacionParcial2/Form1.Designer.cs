namespace ParadigmasProgramacionParcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnMostrarEmpleados = new System.Windows.Forms.Button();
            this.LstEmpleados = new System.Windows.Forms.ListBox();
            this.TxtLegajo = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.RadOperario = new System.Windows.Forms.RadioButton();
            this.RadVendedor = new System.Windows.Forms.RadioButton();
            this.TxtCantHoras = new System.Windows.Forms.TextBox();
            this.TxtMontoVendido = new System.Windows.Forms.TextBox();
            this.TxtSueldoBasico = new System.Windows.Forms.TextBox();
            this.TxtSueldoLiquidar = new System.Windows.Forms.TextBox();
            this.TxtValorHora = new System.Windows.Forms.TextBox();
            this.TxtPorcentaje = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSueldoLiquidarTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEGAJO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEXO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO DE EMPLEADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CANTIDAD DE HORAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MONTO VENDIDO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SUELDO BASICO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "SUELDO NETO A LIQUIDAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "VALOR HORA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "PORCENTAJE";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(34, 374);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(139, 23);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "Registrar Empleado";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnMostrarEmpleados
            // 
            this.BtnMostrarEmpleados.Location = new System.Drawing.Point(34, 440);
            this.BtnMostrarEmpleados.Name = "BtnMostrarEmpleados";
            this.BtnMostrarEmpleados.Size = new System.Drawing.Size(193, 23);
            this.BtnMostrarEmpleados.TabIndex = 11;
            this.BtnMostrarEmpleados.Text = "Mostrar Empleados Registrados";
            this.BtnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.BtnMostrarEmpleados.Click += new System.EventHandler(this.BtnMostrarEmpleados_Click);
            // 
            // LstEmpleados
            // 
            this.LstEmpleados.FormattingEnabled = true;
            this.LstEmpleados.Location = new System.Drawing.Point(255, 345);
            this.LstEmpleados.Name = "LstEmpleados";
            this.LstEmpleados.Size = new System.Drawing.Size(120, 173);
            this.LstEmpleados.TabIndex = 12;
            // 
            // TxtLegajo
            // 
            this.TxtLegajo.Location = new System.Drawing.Point(121, 22);
            this.TxtLegajo.Name = "TxtLegajo";
            this.TxtLegajo.Size = new System.Drawing.Size(100, 20);
            this.TxtLegajo.TabIndex = 13;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(121, 61);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 20);
            this.TxtApellido.TabIndex = 14;
            // 
            // CboSexo
            // 
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CboSexo.Location = new System.Drawing.Point(121, 96);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(121, 21);
            this.CboSexo.TabIndex = 15;
            // 
            // RadOperario
            // 
            this.RadOperario.AutoSize = true;
            this.RadOperario.Location = new System.Drawing.Point(51, 232);
            this.RadOperario.Name = "RadOperario";
            this.RadOperario.Size = new System.Drawing.Size(65, 17);
            this.RadOperario.TabIndex = 16;
            this.RadOperario.TabStop = true;
            this.RadOperario.Text = "Operario";
            this.RadOperario.UseVisualStyleBackColor = true;
            this.RadOperario.CheckedChanged += new System.EventHandler(this.RadOperario_CheckedChanged);
            // 
            // RadVendedor
            // 
            this.RadVendedor.AutoSize = true;
            this.RadVendedor.Location = new System.Drawing.Point(51, 272);
            this.RadVendedor.Name = "RadVendedor";
            this.RadVendedor.Size = new System.Drawing.Size(71, 17);
            this.RadVendedor.TabIndex = 17;
            this.RadVendedor.TabStop = true;
            this.RadVendedor.Text = "Vendedor";
            this.RadVendedor.UseVisualStyleBackColor = true;
            this.RadVendedor.CheckedChanged += new System.EventHandler(this.RadVendedor_CheckedChanged);
            // 
            // TxtCantHoras
            // 
            this.TxtCantHoras.Enabled = false;
            this.TxtCantHoras.Location = new System.Drawing.Point(663, 241);
            this.TxtCantHoras.Name = "TxtCantHoras";
            this.TxtCantHoras.Size = new System.Drawing.Size(100, 20);
            this.TxtCantHoras.TabIndex = 18;
            // 
            // TxtMontoVendido
            // 
            this.TxtMontoVendido.Enabled = false;
            this.TxtMontoVendido.Location = new System.Drawing.Point(322, 237);
            this.TxtMontoVendido.Name = "TxtMontoVendido";
            this.TxtMontoVendido.Size = new System.Drawing.Size(100, 20);
            this.TxtMontoVendido.TabIndex = 19;
            // 
            // TxtSueldoBasico
            // 
            this.TxtSueldoBasico.Enabled = false;
            this.TxtSueldoBasico.Location = new System.Drawing.Point(322, 269);
            this.TxtSueldoBasico.Name = "TxtSueldoBasico";
            this.TxtSueldoBasico.Size = new System.Drawing.Size(100, 20);
            this.TxtSueldoBasico.TabIndex = 20;
            // 
            // TxtSueldoLiquidar
            // 
            this.TxtSueldoLiquidar.Enabled = false;
            this.TxtSueldoLiquidar.Location = new System.Drawing.Point(352, 305);
            this.TxtSueldoLiquidar.Name = "TxtSueldoLiquidar";
            this.TxtSueldoLiquidar.Size = new System.Drawing.Size(100, 20);
            this.TxtSueldoLiquidar.TabIndex = 21;
            // 
            // TxtValorHora
            // 
            this.TxtValorHora.Enabled = false;
            this.TxtValorHora.Location = new System.Drawing.Point(663, 198);
            this.TxtValorHora.Name = "TxtValorHora";
            this.TxtValorHora.Size = new System.Drawing.Size(100, 20);
            this.TxtValorHora.TabIndex = 22;
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.Enabled = false;
            this.TxtPorcentaje.Location = new System.Drawing.Point(322, 198);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.TxtPorcentaje.TabIndex = 23;
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(121, 134);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(100, 20);
            this.TxtDni.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "DNI";
            // 
            // TxtSueldoLiquidarTotal
            // 
            this.TxtSueldoLiquidarTotal.Enabled = false;
            this.TxtSueldoLiquidarTotal.Location = new System.Drawing.Point(663, 303);
            this.TxtSueldoLiquidarTotal.Name = "TxtSueldoLiquidarTotal";
            this.TxtSueldoLiquidarTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtSueldoLiquidarTotal.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "SUELDO NETO A LIQUIDAR TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.TxtSueldoLiquidarTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtPorcentaje);
            this.Controls.Add(this.TxtValorHora);
            this.Controls.Add(this.TxtSueldoLiquidar);
            this.Controls.Add(this.TxtSueldoBasico);
            this.Controls.Add(this.TxtMontoVendido);
            this.Controls.Add(this.TxtCantHoras);
            this.Controls.Add(this.RadVendedor);
            this.Controls.Add(this.RadOperario);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtLegajo);
            this.Controls.Add(this.LstEmpleados);
            this.Controls.Add(this.BtnMostrarEmpleados);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Liquidación de Sueldos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnMostrarEmpleados;
        private System.Windows.Forms.ListBox LstEmpleados;
        private System.Windows.Forms.TextBox TxtLegajo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.ComboBox CboSexo;
        private System.Windows.Forms.RadioButton RadOperario;
        private System.Windows.Forms.RadioButton RadVendedor;
        private System.Windows.Forms.TextBox TxtCantHoras;
        private System.Windows.Forms.TextBox TxtMontoVendido;
        private System.Windows.Forms.TextBox TxtSueldoBasico;
        private System.Windows.Forms.TextBox TxtSueldoLiquidar;
        private System.Windows.Forms.TextBox TxtValorHora;
        private System.Windows.Forms.TextBox TxtPorcentaje;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSueldoLiquidarTotal;
        private System.Windows.Forms.Label label13;
    }
}

