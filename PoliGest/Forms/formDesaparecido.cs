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

namespace PoliGest.Forms
{
    public partial class formDesaparecido : Form
    {
        public formDesaparecido()
        {
            InitializeComponent();
        }

        private void RegistarDadosGerais(int aux)
        {
            SqlParameter[] parameters =
             {
                  new SqlParameter("id_pessoa", aux)
                , new SqlParameter("foto", tx_end_foto.Text)
                , new SqlParameter("Data", dt_data.Value.ToString("yyy-MM-dd"))
                , new SqlParameter("descricacao", tx_description.Text)
                , new SqlParameter("estado", "1")
            };

            try
            {
                DatabaseHelper.Insert("Perdido_Achado", parameters);
                MessageBox.Show("Registro inserido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no registro \n " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (salvarImgem())
            {
                int aux = RegistarDadosPessoais();
                RegistarDadosGerais(aux);
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
        private bool salvarImgem()
        {
            if (pic_imgem.Image != null)
            {
                try
                {
                    string dir = "fotos";
                    string end_img = dir + "/" + DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss-fff").Replace("-", "");
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);

                    tx_end_foto.Text = end_img;
                    pic_imgem.Image.Save(end_img, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dificuldade em importar a imagem!\n {ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Insira uma imagem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void formDesaparecido_Load(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione uma imagem",
                Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tx_end_foto.Text = openFileDialog.FileName;
                    Image image = Image.FromFile(openFileDialog.FileName);
                    pic_imgem.Image = image;
                    pic_imgem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
