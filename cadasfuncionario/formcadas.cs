using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cadasfuncionario.Config;
using Org.BouncyCastle.Crypto.Macs;

namespace cadasfuncionario
{
    public partial class formcadas : Form
    {
        public formcadas()
        {
            InitializeComponent();
        }
        private bool ExistemTextBoxsVazios()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox || control is DateTimePicker)
                {
                    var text = control.Text.Replace(",", "").Replace("-", "").Trim();

                    if (text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        void inserir(Funcionario funcionario)
        {
            try
            {
                 Banco_Dados conexao = new Banco_Dados();

                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (null, @nam, @date, @cpf, @rg, @fone, @gmail, @reco, @city, @est, @fun, @sal)");

                comando.Parameters.AddWithValue("null", funcionario.Id);
                comando.Parameters.AddWithValue("@nam", funcionario.Nome);
                comando.Parameters.AddWithValue("@date", funcionario.DataNascimento);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@fone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@gmail", funcionario.Email);
                comando.Parameters.AddWithValue("@reco", funcionario.Endereco);
                comando.Parameters.AddWithValue("@city", funcionario.Cidade);
                comando.Parameters.AddWithValue("@est", funcionario.Estado);
                comando.Parameters.AddWithValue("@fun", funcionario.Funcao);
                comando.Parameters.AddWithValue("@sal", funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Cadastramento do funcionário concluído!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, tente novamente" + ex);
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario fanc = new Funcionario();
            fanc.Nome = tx_nome.Text;
            fanc.Cpf = tx_cpf.Text;
            fanc.Rg = tx_rg.Text;               
            fanc.Telefone = tx_tel.Text;
            fanc.Endereco = tx_rua.Text;
            fanc.Cidade = tx_cidade.Text;
            fanc.Estado = cb_estado.Text;
            fanc.Salario = double.Parse(tx_salario.Text);
            fanc.Email = tx_gmail.Text;
            fanc.DataNascimento = Convert.ToDateTime(tx_date.Text);
            if (cb_funcao.Text == "Médico")
            {
                MessageBox.Show("Cadastro concluído!");
                MessageBox.Show("Seu salário é de R$ 15.000,00");
                Close();
            }
            if (cb_funcao.Text == "Policial")
            {
                MessageBox.Show("Cadastro concluído!");
                MessageBox.Show("Seu salário é de R$ 17.000,00");
                Close();

            }
            if (cb_funcao.Text == "Advogado")
            {
                MessageBox.Show("Cadastro concluído!");
                MessageBox.Show("Seu salário é de R$ 12.000,00");
                Close();

            }
            if (cb_funcao.Text == "Professor")
            {
                MessageBox.Show("Cadastro concluído!");
                MessageBox.Show("Seu salário é de R$ 10.000,00");
                Close();
            }

            if (Validar.CPF(tx_cpf.Text) == false)
            {
                MessageBox.Show("CPF inválido, tente novamente!");
                Close();
            }
            else if (Validar.Email(tx_gmail.Text) == false)
            {
                MessageBox.Show("Email inválido, tente novamente!");
            }
            else if(ExistemTextBoxsVazios() == true)
            {
                ExistemTextBoxsVazios();
            }
            else
            {
                inserir();
            }
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_email.Clear();
            tx_tel.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_data.Clear();
            tx_rua.Clear();
            tx_cidade.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_real_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_lucro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
