using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class token
    {
        private int id_token;
        private string lexema;
        private string tipo_lexema;

        public int Id_Token
        {
            get
            {
                return this.id_token;
            }
            set
            {
                this.id_token = value;
            }
        }
        public string Lexema
        {
            get
            {
                return this.lexema;
            }
            set
            {
                this.lexema = value;
            }
        }
        public string Tipo_Lexema
        {
            get
            {
                return this.tipo_lexema;
            }
            set
            {
                this.tipo_lexema = value;
            }
        }
    }
}
