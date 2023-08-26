using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class constructor
    {
        private List<string> actualizar_datos = new List<string>();
        private int linea = 1;
        private int columna = 1;
        private List<string> tokens = new List<string>();

        //getter & setter
        public List<string> Tokens
        {
            get
            {
                return tokens;
            }
            set
            {
                this.tokens = value;
            }
        }
        public List<string> Actualizar_Datos
        {
            get
            {
                return actualizar_datos;
            }
            set
            {
                this.actualizar_datos = value;
            }
        }
        public int Linea
        {
            get
            {
                return this.linea;
            }
            set
            {
                this.linea = value;
            }
        }
        public int Columna
        {
            get
            {
                return this.columna;
            }
            set
            {
                this.columna = value;
            }
        }
    }
}
