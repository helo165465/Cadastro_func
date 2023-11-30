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

                var comando = conexao.Comando("INSERT INTO Funcionario VALUES (null, @nam, @date, @cpf, @rg, @fone, @gmail, @city, @est, @fun, @sal, @rua)");

                comando.Parameters.AddWithValue("null", funcionario.Id);
                comando.Parameters.AddWithValue("@nam", funcionario.Nome);
                comando.Parameters.AddWithValue("@date", funcionario.DataNascimento);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@fone", funcionario.Telefone);
                comando.Parameters.AddWithValue("@gmail", funcionario.Email);
                comando.Parameters.AddWithValue("@city", funcionario.Cidade);
                comando.Parameters.AddWithValue("@est", funcionario.Estado);
                comando.Parameters.AddWithValue("@fun", funcionario.Funcao);
                comando.Parameters.AddWithValue("@sal", funcionario.Salario);
                comando.Parameters.AddWithValue("@rua", funcionario.Rua);

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
                try
                {
                Funcionario fanc = new Funcionario();
                fanc.Nome = tx_nome.Text;
                fanc.Cpf = tx_cpf.Text;
                fanc.Rg = tx_rg.Text;
                fanc.Telefone = tx_tel.Text;
                fanc.Rua = tx_rua.Text;
                fanc.Cidade = tx_cidade.Text;
                fanc.Estado = cb_estado.Text;
                fanc.Salario = double.Parse(tx_salario.Text);
                fanc.Email = tx_email.Text;
                fanc.DataNascimento = Convert.ToDateTime(tx_data.Text);
                fanc.Funcao = cb_funcao.Text;
                if (ExistemTextBoxsVazios() == true)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else if (Validar.CPF(fanc.Cpf) == false)
                {
                    MessageBox.Show("CPF inválido, tente novamente!");
                 
                }
                else if (Validar.Email(fanc.Email) == false)
                {
                    MessageBox.Show("Email inválido, tente novamente!");
                }
                else
                {
                    inserir(fanc);
                }

                if (cb_funcao.Text == "Médico")
                {
                    MessageBox.Show("Seu salário é de R$ 15.000,00");
                }
                if (cb_funcao.Text == "Policial")
                {
                    MessageBox.Show("Seu salário é de R$ 17.000,00");
                }
                if (cb_funcao.Text == "Advogado")
                {
                    MessageBox.Show("Seu salário é de R$ 12.000,00");

                }
                if (cb_funcao.Text == "Professor")
                {
                    MessageBox.Show("Seu salário é de R$ 10.000,00");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button4_Click(object sender, EventArgs e)
        {
            Consultar_Funcionario con = new Consultar_Funcionario();
            this.Visible = false;
            con.ShowDialog();
            this.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

