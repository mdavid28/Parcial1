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
    public partial class frm_tokens : Form
    {
        public frm_tokens()
        {
            InitializeComponent();
            cargar_datos();
        }

        public void cargar_datos()
        {
            mantenimiento _mantenimiento = new mantenimiento();
            dataGridView_tokens.DataSource = _mantenimiento.consultar_tokens();
            dataGridView_tokens_error.DataSource = _mantenimiento.consultar_tokens_error();
            dataGridView_tokens_validado.DataSource = _mantenimiento.consultar_tokens_validos();
        }
    }
}
