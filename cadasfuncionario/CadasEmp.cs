using cadasfuncionario.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadasfuncionario
{
    public partial class CadasEmp : Form
    {
        public CadasEmp()
        {
            InitializeComponent();
        }
        void inserir(Empresa empresa)
        {
            try
            {
                Banco_Dados conexao = new Banco_Dados();

                var comando = conexao.Comando("INSERT INTO Empresa VALUES (null, @cnpj, @razao_social, @nome_fantasia, @situacao_cadastral, @regime_tributario, @data_inicial, @telefone, @capital_social, @endereco_completo, @tipo, @porte, @natureza_juridica, @nome_proprietario, @cpf_proprietario)");

                comando.Parameters.AddWithValue("null", empresa.Id);
                comando.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                comando.Parameters.AddWithValue("@razao_social", empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@nome_fantasia", empresa.Nomefantasia);
                comando.Parameters.AddWithValue("@situacao_cadastral", empresa.SituacaoCadastral);
                comando.Parameters.AddWithValue("@regime_tributario", empresa.RegimeTributario);
                comando.Parameters.AddWithValue("@data_inicial", empresa.DataInicio);
                comando.Parameters.AddWithValue("@telefone", empresa.Telefone);
                comando.Parameters.AddWithValue("@capital_social", empresa.CapitalSocial);
                comando.Parameters.AddWithValue("@endereco_completo", empresa.EnderecoCompleto);
                comando.Parameters.AddWithValue("@tipo", empresa.Tipo);
                comando.Parameters.AddWithValue("@porte", empresa.Porte);
                comando.Parameters.AddWithValue("@natureza_juridica", empresa.NaturezaJuridica);
                comando.Parameters.AddWithValue("@nome_proprietario", empresa.Nome_Proprietario);
                comando.Parameters.AddWithValue("@cpf_proprietario", empresa.Cpf_Proprietario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro encontrado" + ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

                try
                {
                    Empresa empre = new Empresa();
                    empre.RazaoSocial = tx_razao.Text;
                    empre.Nomefantasia = tx_nome_fan.Text;
                    empre.SituacaoCadastral = tx_situacao.Text;
                    empre.DataInicio = Convert.ToDateTime(tx_data.Text);
                    empre.Telefone = tx_telkefone.Text;
                    empre.CapitalSocial = Convert.ToDouble(tx_capital.Text);
                    empre.EnderecoCompleto = tx_endereco.Text;
                    empre.NaturezaJuridica = tx_natureza.Text;
                    empre.Nome_Proprietario = tx_nome.Text;
                    empre.Cpf_Proprietario = tx_cpf.Text;
                    empre.Cnpj = tx_cnpj.Text;


                    if (Cnpj.Validar(empre.Cnpj) == false)
                    {
                        MessageBox.Show("CNPJ inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Validar.CPF(empre.Cpf_Proprietario) == false)
                    {
                        MessageBox.Show("CPF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (empre.RazaoSocial == "" || empre.RazaoSocial == null || empre.Nomefantasia == "" || empre.Nomefantasia == null || empre.SituacaoCadastral == "" || empre.SituacaoCadastral == null || empre.Telefone == null || empre.Telefone == "" || empre.CapitalSocial == null || empre.EnderecoCompleto == null || empre.EnderecoCompleto == "" || empre.NaturezaJuridica == null || empre.NaturezaJuridica == "" || empre.Nome_Proprietario == null || empre.Nome_Proprietario == "")
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (tx_filial.Checked == false && tx_matriz.Checked == false)
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (tx_pequeno.Checked == false && tx_medio.Checked == false && tx_grande.Checked == false)
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (tx_simples.Checked == false && tx_lucro.Checked == false && tx_real.Checked == false)
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        inserir(empre);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultarEmp ep = new ConsultarEmp();
            this.Visible = false;
            ep.ShowDialog();
            this.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
