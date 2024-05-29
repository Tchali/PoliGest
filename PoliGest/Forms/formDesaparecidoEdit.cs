using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliGest.Forms
{
    public partial class formDesaparecidoEdit : Form
    {
        public formDesaparecidoEdit()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_pessoal.Enabled = true;
            panel_geral.Enabled = true;
            bt_atualizar.Enabled = true;
            bt_editar.Enabled = false;
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            panel_pessoal.Enabled = false;
            panel_geral.Enabled = false;
            bt_atualizar.Enabled = false;
            bt_editar.Enabled = true;
        }
    }
}
