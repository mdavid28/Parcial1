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
    public partial class frm_mantenimiento : Form
    {
        public frm_mantenimiento()
        {
            InitializeComponent();
            cargar_datos();
        }

        private void cargar_datos()
        {
            List<palabras_reservadas> lista = new List<palabras_reservadas>();
            mantenimiento _mantenimiento = new mantenimiento();
            dataGridViewPalabrasReservadas.DataSource = _mantenimiento.consultar_datos();
        }

        private void limpiar_campos(string _operacion)
        {
            if(_operacion == "actualizar")
            {
                txt_id_palabra_reservada_actualizar.Clear();
                txt_palabra_reservada_actualizar.Clear();
                cbx_estado_actualizar.SelectedIndex = -1;
            }
            else if(_operacion == "eliminar")
            {
                txt_id_palabra_reservada_eliminar.Clear();
                txt_palabra_reservada_eliminar.Clear();
                cbx_estado_eliminar.SelectedIndex = -1;
            }
        }

        private void btn_ingresar_mantenimiento_Click(object sender, EventArgs e)
        {
            mantenimiento _mantenimiento = new mantenimiento();
            if(txt_ingresar_mantenimiento.Text != "")
            {
                bool estado_ingreso = _mantenimiento.insertar(txt_ingresar_mantenimiento.Text);
                cargar_datos();
                if (estado_ingreso == true)
                {
                    MessageBox.Show("Palabra reservada: " + txt_ingresar_mantenimiento.Text + " ,ingresada con éxito");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Campo Obligatorio Vacio");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_palabra_reservada_actualizar_TextChanged(object sender, EventArgs e)
        {
            if(txt_id_palabra_reservada_actualizar.Text != "" && int.TryParse(txt_id_palabra_reservada_actualizar.Text, out int n)==true)
            {
                constructor _constructor = new constructor();
                _constructor.Actualizar_Datos.Clear();
                mantenimiento _mantenimiento = new mantenimiento();
                List<string> datos = new List<string>();
                datos = _mantenimiento.rellenar_campos(int.Parse(txt_id_palabra_reservada_actualizar.Text));
                if(datos.Count != 0)
                {
                    txt_palabra_reservada_actualizar.Text = datos[1];
                    if (datos[2] == "A")
                    {
                        cbx_estado_actualizar.SelectedIndex = 0;
                    }
                    else if (datos[2] == "B")
                    {
                        cbx_estado_actualizar.SelectedIndex = 1;
                    }
                }
                else
                {
                    txt_palabra_reservada_actualizar.Text = "";
                    cbx_estado_actualizar.SelectedIndex = -1;
                }
            }
            else
            {
                txt_palabra_reservada_actualizar.Text = "";
                cbx_estado_actualizar.SelectedIndex = -1;
            }
        }

        private void btn_actualizar_palabra_reservada_Click(object sender, EventArgs e)
        {
            mantenimiento _mantenimiento = new mantenimiento();
            if (txt_palabra_reservada_actualizar.Text != "" && cbx_estado_actualizar.SelectedIndex >= 0)
            {
                string estado_registro = "";
                if(cbx_estado_actualizar.SelectedIndex == 0)
                {
                    estado_registro = "A";
                }
                else if(cbx_estado_actualizar.SelectedIndex == 1)
                {
                    estado_registro = "B";
                }
                bool estado_query = _mantenimiento.actualizar_datos(int.Parse(txt_id_palabra_reservada_actualizar.Text), txt_palabra_reservada_actualizar.Text, estado_registro);
                cargar_datos();
                if (estado_query == true)
                {
                    MessageBox.Show("Registro Actualizado con exito");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Campo Obligatorio Vacio");
            }
        }

        private void txt_id_palabra_reservada_eliminar_TextChanged(object sender, EventArgs e)
        {
            if (txt_id_palabra_reservada_eliminar.Text != "" && int.TryParse(txt_id_palabra_reservada_eliminar.Text,out int n)==true)
            {
                constructor _constructor = new constructor();
                _constructor.Actualizar_Datos.Clear();
                mantenimiento _mantenimiento = new mantenimiento();
                List<string> datos = new List<string>();
                datos = _mantenimiento.rellenar_campos(int.Parse(txt_id_palabra_reservada_eliminar.Text));
                if (datos.Count != 0)
                {
                    txt_palabra_reservada_eliminar.Text = datos[1];
                    if (datos[2] == "A")
                    {
                        cbx_estado_eliminar.SelectedIndex = 0;
                    }
                    else if (datos[2] == "B")
                    {
                        cbx_estado_eliminar.SelectedIndex = 1;
                    }
                }
                else
                {
                    txt_palabra_reservada_eliminar.Text = "";
                    cbx_estado_eliminar.SelectedIndex = -1;
                }
            }
            else
            {
                txt_palabra_reservada_eliminar.Text = "";
                cbx_estado_eliminar.SelectedIndex = -1;
            }
        }

        private void btn_baja_eliminar_Click(object sender, EventArgs e)
        {
            if(txt_id_palabra_reservada_eliminar.Text != "")
            {
                mantenimiento _mantenimiento = new mantenimiento();
                if (cbx_estado_eliminar.SelectedIndex == 1)
                {
                    MessageBox.Show("La palabra reservada ya ha sido dado de baja");
                }
                else
                {
                    bool estado_query = _mantenimiento.dar_baja(int.Parse(txt_id_palabra_reservada_eliminar.Text));
                    if (estado_query == true)
                    {
                        MessageBox.Show("Palabra reservada dada de baja con exito");
                        cargar_datos();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void btn_eliminar_registro_Click(object sender, EventArgs e)
        {
            if(txt_id_palabra_reservada_eliminar.Text != "")
            {
                mantenimiento _mantenimiento = new mantenimiento();
                bool estado_query = _mantenimiento.eliminar_registro(int.Parse(txt_id_palabra_reservada_eliminar.Text));
                if (estado_query == true)
                {
                    MessageBox.Show("Registro eliminado con exito");
                    cargar_datos();
                    limpiar_campos("eliminar");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
