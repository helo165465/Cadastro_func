using System;
public class Empresa
{
    public int Id { get; set; }
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string Nomefantasia { get; set; }
    public string SituacaoCadastral { get; set; }
    public string RegimeTributario { get; set; }
    public DateTime? DataInicio { get; set; }
    public string Telefone { get; set; }
    public double CapitalSocial { get; set; }
    public string EnderecoCompleto { get; set; }
    public string Tipo { get; set; }
    public string Porte { get; set; }
    public string NaturezaJuridica { get; set; }
    public string Nome_Proprietario { get; set; }
    public string Cpf_Proprietario { get; set; }

    public Empresa(int id, string cnpj, string razao_Social, string nome_fantasia, string situacao_Cadastral, string regime_Tributario, DateTime? data_Inicio, string telefone, double capital_Social, string endereco_Completo, string tipo, string porte, string natureza_Juridica, string nome_Proprietario, string cpf_Proprietario)
    {
        Id = id;
        Cnpj = cnpj;
        RazaoSocial = razao_Social;
        Nomefantasia = nome_fantasia;
        SituacaoCadastral = situacao_Cadastral;
        RegimeTributario = regime_Tributario;
        DataInicio = data_Inicio;
        Telefone = telefone;
        CapitalSocial = capital_Social;
        EnderecoCompleto = endereco_Completo;
        Tipo = tipo;
        Porte = porte;
        NaturezaJuridica = natureza_Juridica;
        Nome_Proprietario = nome_Proprietario;
        Cpf_Proprietario = cpf_Proprietario;
    }

    public Empresa()
    {

    }
}