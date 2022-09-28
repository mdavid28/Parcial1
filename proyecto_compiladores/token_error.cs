using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_compiladores
{
    class token_error
    {
        private int id_token_error;
        private string lexema;
        private string error;
        private int id_token;

        public int Id_Token_Error
        {
            get
            {
                return this.id_token_error;
            }
            set
            {
                this.id_token_error = value;
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
        public string Error
        {
            get
            {
                return this.error;
            }
            set
            {
                this.error = value;
            }
        }
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
    }
}
