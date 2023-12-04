create database  Empresa_Helo_bd;
use Empresa_Helo_bd;

create table Funcionario(
id_fun int primary key auto_increment,
nome_fun varchar (240),
data_nas_fun date,
cpf_fun varchar (180),
rg_fun varchar (150),
telefone_fun varchar (250),
email_fun varchar (400),
cidade_fun varchar (100),
estado_fun varchar (300),
funcao_fun varchar (400),
salario_fun double,
rua_fun varchar(400)	
);	
select * from funcionario;	

create table Empresa(
id_emp int primary key auto_increment,
cnpj_emp varchar (300),
razao_soc_emp varchar (300),
nome_fan_emp varchar (100),
situacao_cad_emp varchar (300),
regime_tri_emp varchar (300),
data_ini_emp date,
telefone_emp varchar (300),
capital_soc_emp double,
endereco_com_emp varchar (300),
tipo_emp varchar (300),
porte_emp varchar (300),
natureza_jur_emp varchar (300),
nome_pro_emp varchar (300),
cpf_pro_emp varchar (300)
);