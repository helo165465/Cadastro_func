using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadasfuncionario.Config
{
    class Banco_Dados
    {
        private string _servidor = "localhost";
        private string _porta = "3306";
        private string _ususario = "root";
        private string _senha = "Anjo 123";
        private string _bancoDadosNome = "Empresa_X2A_bd";
        private MySqlConnection connection;
        private MySqlCommand command;

        public Banco_Dados()
        {
            try
            {
                connection = new MySqlConnection($"server={_servidor};database={_bancoDadosNome};port={_porta};user={_ususario};password={_senha}");
                connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public MySqlCommand Comando(string comando)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                return command;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}