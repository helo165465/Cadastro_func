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
using cadasfuncionario.Uteis;

namespace cadasfuncionario
{
    public partial class Consultar_Funcionario : Form
    {
        private List<Funcionario> listcon = new List<Funcionario>();
        public Consultar_Funcionario()
        {
            InitializeComponent();
            Consultar();
        }
        private void Consultar()
        {
            try
            {
                var conexao = new Banco_Dados();
                var comando = conexao.Comando("SELECT * FROM Funcionario");
                var leitor = comando.ExecuteReader();

                while(leitor.Read())
                {
                    var funcionario = new Funcionario();
                    funcionario.Id = DAOHelper.GetInt(leitor, "id_fun");
                    funcionario.Nome = DAOHelper.GetString(leitor, "nome_fun");
                    funcionario.DataNascimento = DAOHelper.GetDateTime(leitor, "data_nas_fun");
                    funcionario.Cpf = DAOHelper.GetString(leitor, "cpf_fun");
                    funcionario.Rg = DAOHelper.GetString(leitor, "rg_fun");
                    funcionario.Telefone = DAOHelper.GetString(leitor, "telefone_fun");
                    funcionario.Email = DAOHelper.GetString(leitor, "email_fun");
                    funcionario.Cidade = DAOHelper.GetString(leitor, "cidade_fun");
                    funcionario.Estado = DAOHelper.GetString(leitor, "estado_fun");
                    funcionario.Funcao = DAOHelper.GetString(leitor, "funcao_fun");
                    funcionario.Salario = DAOHelper.GetDouble(leitor, "salario_fun");
                    funcionario.Rua = DAOHelper.GetString(leitor, "rua_fun");
                    listcon.Add(funcionario);
                }
                con.DataSource = listcon;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
