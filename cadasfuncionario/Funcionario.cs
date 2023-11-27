using System;
public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string Cpf { get; set; }
    public string Rg { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Funcao { get; set; }
    public string Telefone { get; set; }
    public double Salario { get; set; }
    public string Email { get; set; }

    public Funcionario()
    {

    }

    public Funcionario(string name, DateTime? date, string cpf, string rg, string end, string city, string est, string func, double sal, string gmail, string fone)
    {
        name = this.Nome;
        date = this.DataNascimento;
        cpf = this.Cpf;
        rg = this.Rg;
        end = this.Endereco;
        city = this.Cidade;
        est = this.Estado;
        func = this.Funcao;
        sal = this.Salario;
        gmail = this.Email;
        fone = this.Telefone;
    }

}