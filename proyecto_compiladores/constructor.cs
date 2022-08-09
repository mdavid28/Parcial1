using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class constructor
    {
        private int linea = 1;
        private int columna = 1;

        //getter & setter
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
