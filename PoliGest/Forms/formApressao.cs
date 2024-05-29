using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PoliGest.Forms
{
    public partial class formApressao : Form
    {
        public formApressao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aux = RegistarDadosPessoais();
            RegistarDadosGerais(aux);
        }

        private void RegistarDadosGerais(int aux)
        {
            SqlParameter[] parameters =
             {
                  new SqlParameter("id_pessoa", aux)
                , new SqlParameter("data", dt_dataAprensao.Value.ToString("yyy-MM-dd"))
                , new SqlParameter("descricacao", tx_descricaoAprensao.Text)
                , new SqlParameter("estado", "1")
            };

            try
            {
                DatabaseHelper.Insert("aprensao", parameters);
                MessageBox.Show("Registro inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no registro \n " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int RegistarDadosPessoais()
        {
            int result = -1; 

            SqlParameter[] parameters =
             {
                  new SqlParameter("Nome", tx_nome.Text)
                , new SqlParameter("Pai", tx_pai.Text)
                , new SqlParameter("Mae", tx_mae.Text)
                , new SqlParameter("Nascimento", dt_nascimento.Value.ToString("yyy-MM-dd"))
                , new SqlParameter("NBi", tx_numBi.Text)
                , new SqlParameter("estadoCivil", cb_estadoCivil.SelectedValue)
            };

            try
            {
                result = DatabaseHelper.Insert("DadosPessoais", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no registro \n " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void formApressao_Load(object sender, EventArgs e)
        {
            carregarEstdoCivil();
        }

        private void carregarEstdoCivil()
        {
            try
            {
                string query = "SELECT id_estado ,descricao FROM estado_civil";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);

                DataRow newRow = dt.NewRow();
                newRow["id_estado"] = -1; 
                newRow["descricao"] = "--- Selecione ---";
                dt.Rows.InsertAt(newRow, 0);

                cb_estadoCivil.DisplayMember = "descricao";
                cb_estadoCivil.ValueMember = "id_estado";
                cb_estadoCivil.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estado civil: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
