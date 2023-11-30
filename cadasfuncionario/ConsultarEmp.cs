using cadasfuncionario.Config;
using cadasfuncionario.Uteis;
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
    public partial class ConsultarEmp : Form
    {
        List<Empresa> e = new List<Empresa>();
        public ConsultarEmp()
        {
            InitializeComponent();
            Consultar();
        }
        public void Consultar()
        {
            try
            {
                var conexao = new Banco_Dados();
                var comando = conexao.Comando("SELECT * FROM Empresa");
                var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var empresa = new Empresa();
                    empresa.Id = DAOHelper.GetInt(leitor, "id_emp");
                    empresa.Cnpj = DAOHelper.GetString(leitor, "cnpj_emp");
                    empresa.RazaoSocial = DAOHelper.GetString(leitor, "razao_soc_emp");
                    empresa.Nomefantasia = DAOHelper.GetString(leitor, "nome_fan_emp");
                    empresa.SituacaoCadastral = DAOHelper.GetString(leitor, "situacao_cad_emp");
                    empresa.RegimeTributario = DAOHelper.GetString(leitor, "regime_tri_emp");
                    empresa.DataInicio = DAOHelper.GetDateTime(leitor, "data_ini_emp");
                    empresa.Telefone = DAOHelper.GetString(leitor, "telefone_emp");
                    empresa.CapitalSocial = DAOHelper.GetDouble(leitor, "capital_soc_emp");
                    empresa.EnderecoCompleto = DAOHelper.GetString(leitor, "endereco_com_emp");
                    empresa.Tipo = DAOHelper.GetString(leitor, "tipo_emp");
                    empresa.Porte = DAOHelper.GetString(leitor, "porte_emp");
                    empresa.NaturezaJuridica = DAOHelper.GetString(leitor, "natureza_jur_emp");
                    empresa.Nome_Proprietario = DAOHelper.GetString(leitor, "nome_pro_emp");
                    empresa.Cpf_Proprietario = DAOHelper.GetString(leitor, "cpf_pro_emp");
                    e.Add(empresa);
                }

                tabelaEmp.DataSource = e;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabelaEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
