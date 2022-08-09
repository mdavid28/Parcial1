using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_compiladores
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        funciones funciones = new funciones();

        private void limpiar_input_Click(object sender, EventArgs e)
        {
            txt_input.Clear();
        }

        private void btn_limpiar_output_Click(object sender, EventArgs e)
        {
            txt_output.Clear();
        }

        private void btn_seleccionar_archivo_Click(object sender, EventArgs e)
        {
            txt_input.Text += funciones.carga_lectura_archivo();
        }

        private void btn_flujo_caracteres_Click(object sender, EventArgs e)
        {
            txt_output.Text += funciones.crear_cadena_por_operacion(txt_input.Text, "flujo_caracteres");
        }

        private void btn_mostrar_caracteres_Click(object sender, EventArgs e)
        {
            funciones.crear_cadena_por_operacion(txt_input.Text, "mostrar_caracteres");
        }

        private void btn_lineas_columnas_Click(object sender, EventArgs e)
        {
            txt_output.Text += funciones.crear_cadena_por_operacion(txt_input.Text, "lineas_columnas");
        }
    }
}
