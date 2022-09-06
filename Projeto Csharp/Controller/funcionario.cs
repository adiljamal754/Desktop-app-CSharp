using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Csharp.Model
{
    internal class funcionario
    {
        private string _fullName;
        private string _email;
        private string _adress;
        private string _phone;
        private string _username;
        private string _birthday;
        private string _gener;
        private string _espec;
        private string _workLocatio;
        private string  _password;
        private string _nuit;
        private string _numBI;
        private string _status;

        ConexaoBD connection = new ConexaoBD();
        SqlCommand command = new SqlCommand();
        public string message;

        //construtor
        public funcionario(string fullName, string email, string adress, string phone, string username, 
            string birthday, string gener, string espec, string workLocatio, string password, string nuit, string numBI, string status)
        {
            _fullName = fullName;
            _email = email;
            _adress = adress;
            _phone = phone;
            _username = username;
            _birthday = birthday;
            _gener = gener;
            _espec = espec;
            _workLocatio = workLocatio;
            _password = password;
            _nuit = nuit;
            _numBI = numBI;
            _status = status;

            //comando sql
            command.CommandText = "INSERT INTO dbo.Funcionario VALUES (@nome, @email, @endereco, @telefone, @usuario, @dataNasc, @genero, @especial, @localTrab,dbo.ENCRIPTA_SENHA('@senha'), @nuit, @BI, @estadoCivil);";
            
            //parametros
            command.Parameters.AddWithValue("@nome", fullName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@endereco", adress);
            command.Parameters.AddWithValue("@telefone", phone);
            command.Parameters.AddWithValue("@usuario", username);
            command.Parameters.AddWithValue("@dataNasc", birthday);
            command.Parameters.AddWithValue("@genero", gener);
            command.Parameters.AddWithValue("@especial", espec);
            command.Parameters.AddWithValue("@localTrab", workLocatio);
            command.Parameters.AddWithValue("@senha", password);
            command.Parameters.AddWithValue("@nuit", nuit);
            command.Parameters.AddWithValue("@BI", numBI);
            command.Parameters.AddWithValue("@estadoCivil", status);


            //conectar a BD
            try
            {
                command.Connection = connection.connect();
                //  
                command.ExecuteNonQuery();
                //
                connection.disconnect();
                //
                this.message = "Usuário cadastrado com sucesso!!!";
            } catch (SqlException)
            {
                this.message = "Erro ao conectar com a base de dados";

            }

        }

        public string FullName { get => _fullName; set => _fullName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Username { get => _username; set => _username = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
        public string Gener { get => _gener; set => _gener = value; }
        public string Espec { get => _espec; set => _espec = value; }
        public string WorkLocatio { get => _workLocatio; set => _workLocatio = value; }
        public string Password { get => _password; set => _password = value; }
        public string Nuit { get => _nuit; set => _nuit = value; }
        public string NumBI { get => _numBI; set => _numBI = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
