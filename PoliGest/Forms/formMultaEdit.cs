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
    public partial class formMultaEdit : Form
    {
        public formMultaEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formDesaparecidoEdit().ShowDialog();
        }
    }
}
