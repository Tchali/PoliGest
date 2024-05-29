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
    public partial class formPrinc : Form
    {
        public formPrinc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new formApressao().ShowDialog();
            CarregarDados();
        }

        private void formPrinc_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            string query = @" SELECT 
                    DadosPessoais.id,
                    DadosPessoais.Nome AS 'nome',
                    DadosPessoais.NBi AS 'nr_bi',
                    DadosPessoais.Nascimento AS 'dt_nasc',
                        estado_civil.descricao AS 'estado_civil',
                            CASE
                                WHEN aprensao.id_pessoa IS NOT NULL THEN 'Aprensão'
                                WHEN Detencao.id_pessoa IS NOT NULL THEN 'Detenção'
                                WHEN multa.id_pessoal IS NOT NULL THEN 'Multa'
                            ELSE 'Sem Processo'
                        END AS processo
                FROM  DadosPessoais

            LEFT JOIN estado_civil ON DadosPessoais.id_estado_civil = estado_civil.id_estado
            LEFT JOIN Detencao ON DadosPessoais.id = Detencao.id_pessoa
            LEFT JOIN aprensao ON DadosPessoais.id = aprensao.id_pessoa
            LEFT JOIN multa ON multa.id = aprensao.id_pessoa
            WHERE aprensao.id_pessoa IS NOT NULL OR Detencao.id_pessoa IS NOT NULL;";

            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new formDesaparecido().ShowDialog();
            CarregarDados();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new formDetencao().ShowDialog();
            CarregarDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new formMulta().ShowDialog();
            CarregarDados();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}