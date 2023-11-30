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
                    Empresa emp = new Empresa();
                    emp.RazaoSocial = razao_social.Text;
                    emp.Nomefantasia = nome_fantasia.Text;
                    emp.SituacaoCadastral = situacao_cadastral.Text;
                    emp.DataInicio = Convert.ToDateTime(data.Text);
                    emp.Telefone = telefone.Text;
                    emp.CapitalSocial = Convert.ToDouble(capital_social.Text);
                    emp.EnderecoCompleto = endereco_completo.Text;
                    emp.NaturezaJuridica = natureza_juridica.Text;
                    emp.Nome_Proprietario = nome_proprietario.Text;
                    emp.Cpf_Proprietario = cpf_proprietario.Text;
                    emp.Cnpj = cnpj.Text;


                    if (Cnpj.Validar(emp.Cnpj) == false)
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
                    else if (filial.Checked == false && matriz.Checked == false)
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (pequeno.Checked == false && medio.Checked == false && grande.Checked == false)
                    {
                        MessageBox.Show("Todos os campos são obrigatórios. Por favor preencher os campos corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else if (simples.Checked == false && lucro.Checked == false && real.Checked == false)
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

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultarEmp ep = new ConsultarEmp();
            this.Visible = false;
            ep.ShowDialog();
            this.Visible = true;
        }
    }
}
