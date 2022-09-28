using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class palabras_reservadas
    {
        private string palabra_reservada;
        private int id_palabra_reservada;
        private string estado_registro;
        public int Id_Palabra_Reservada
        {
            get
            {
                return this.id_palabra_reservada;
            }
            set
            {
                this.id_palabra_reservada = value;
            }
        }
        public string Palabra_Reservada
        {
            get
            {
                return this.palabra_reservada;
            }
            set
            {
                this.palabra_reservada = value;
            }
        }
        public string Estado_Registro
        {
            get
            {
                return this.estado_registro;
            }
            set
            {
                this.estado_registro = value;
            }
        }
    }
}
