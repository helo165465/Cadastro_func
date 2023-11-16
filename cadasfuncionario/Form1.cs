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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string email = tx_email.Text;
            string telefone = tx_tel.Text;
            string estcivil = cb_civil.Text;
            string cpf = tx_cpf.Text;
            string rg = tx_rg.Text;
            string datanasc = tx_datanasc.Text;
            string funcao = Convert.ToString(cb_funcao.Text);
            string rua = tx_rua.Text;
            string estado = tx_estado.Text;
            string cidade = tx_cidade.Text;

            if (ValidarCPF.ValidaCPF(tx_cpf.Text) == false)
            {
                MessageBox.Show("CPF inválido, tente novamente!");
                Close();
            }
            else
            {
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
            tx_datanasc.Clear();
            tx_rua.Clear();
            tx_estado.Clear();
            tx_cidade.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
