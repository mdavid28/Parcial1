using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_compiladores
{
    class funciones:constructor
    {
        private string leer_cadena_caracteres(string _cadena, int _posicion)
        {
            string cadena = _cadena;
            int posicion = _posicion;

            byte[] valoresASCII = Encoding.ASCII.GetBytes(cadena);

            switch (valoresASCII[posicion])
            {
                case 32:
                    Columna++;
                    return "[espacio]:32";
                case 10:
                    Linea++;
                    Columna = 1;
                    return "[Salto de Linea]:10";
                case 13:
                    Columna++;
                    return "[Fin de Linea]:13";
                case 9:
                    Columna = Columna + 8;
                    return "[Tabulación]:9";
                default:
                    Columna++;
                    string caracter = "[Caracter]: " + Convert.ToChar(valoresASCII[posicion]).ToString();
                    return caracter;
            }
        }

        public string crear_cadena_por_operacion(string _cadena, string _operacion)
        {
            string cadena = _cadena;
            string operacion = _operacion;
            int longitdud_cadena = cadena.Length;
            string cadena_contenido = null;
            if(longitdud_cadena > 0)
            {
                for (int i = 0; i <= longitdud_cadena - 1; i++)
                {
                    switch (operacion)
                    {
                        case "mostrar_caracteres":
                            MessageBox.Show(leer_cadena_caracteres(cadena, i));
                            break;
                        case "flujo_caracteres":
                            cadena_contenido += leer_cadena_caracteres(cadena, i) + Environment.NewLine;
                            break;
                        case "lineas_columnas":
                            cadena_contenido += "[Linea]: " + Linea + "  █  [Columna]: " + Columna + "  █  " + leer_cadena_caracteres(cadena, i) + Environment.NewLine;
                            break;
                    }
                }
                Linea = 1;
                Columna = 1;
                return cadena_contenido;
            }
            else
            {
                MessageBox.Show("Input Vacio");
                return null;
            }
        }

        public string carga_lectura_archivo()
        {
            string ruta_archivo = "";
            string contenido_archivo = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccione un Archivo";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ruta_archivo = openFileDialog.FileName;
                        StreamReader leer_archivo = new StreamReader(ruta_archivo);
                        contenido_archivo = leer_archivo.ReadToEnd();
                    }
                    catch (Exception ex)
                    {
                        contenido_archivo = "Error al cargar el archivo: " + ex.Message;
                    }
                }
            }
            return contenido_archivo;
        }

    }
}
