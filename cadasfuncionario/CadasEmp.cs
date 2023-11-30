using cadasfuncionario.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace cadasfuncionario
{
    public partial class CadasEmp : Form
    {
        public CadasEmp()
        {
            InitializeComponent();
        }

        private void CadasEmp_Load(object sender, EventArgs e)
        {

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



        private void razao_social_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_capital_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tx_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa emp = new Empresa();
                emp.RazaoSocial = tx_razao.Text;
                emp.Nomefantasia = tx_nome_fan.Text;
                emp.SituacaoCadastral = tx_situacao.Text;
                emp.DataInicio = Convert.ToDateTime(tx_data.Text);
                emp.Telefone = tx_telefone.Text;
                emp.CapitalSocial = Convert.ToDouble(tx_capital.Text);
                emp.EnderecoCompleto = tx_endereco.Text;
                emp.NaturezaJuridica = tx_natureza.Text;
                emp.Nome_Proprietario = tx_nome_pro.Text;
                emp.Cpf_Proprietario = tx_cpf.Text;
                emp.Cnpj = tx_cnpj.Text;

                if (tx_matriz.Checked == true)
                {
                    emp.Tipo = tx_matriz.Text;
                }
                else
                {
                    emp.Tipo = tx_filial.Text;
                }

                if (tx_pequeno.Checked == true)
                {
                    emp.Porte = tx_pequeno.Text;
                }
                else if (tx_medio.Checked == true)
                {
                    emp.Porte = tx_medio.Text;
                }
                else if (tx_grande.Checked == true)
                {
                    emp.Porte = tx_grande.Text;
                }

                if (tx_simples.Checked == true)
                {
                    emp.RegimeTributario = tx_simples.Text;
                }
                else if (tx_lucro.Checked == true)
                {
                    emp.RegimeTributario = tx_lucro.Text;
                }
                else if (tx_real.Checked == true)
                {
                    emp.RegimeTributario = tx_real.Text;
                }
                else if (Cnpj.Validar(emp.Cnpj) == false)
                {
                    MessageBox.Show("CNPJ inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validar.CPF(emp.Cpf_Proprietario) == false)
                {
                    MessageBox.Show("CPF inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (emp.RazaoSocial == "" || emp.RazaoSocial == null || emp.Nomefantasia == "" || emp.Nomefantasia == null || emp.SituacaoCadastral == "" || emp.SituacaoCadastral == null || emp.Telefone == null || emp.Telefone == "" || emp.CapitalSocial == null || emp.EnderecoCompleto == null || emp.EnderecoCompleto == "" || emp.NaturezaJuridica == null || emp.NaturezaJuridica == "" || emp.Nome_Proprietario == null || emp.Nome_Proprietario == "")
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
                    inserir(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tx_lucro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tx_voltar_Click(object sender, EventArgs e)
        {

        }

        private void tx_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void tx_consulta_emp_Click(object sender, EventArgs e)
        {

        }
    }
}
