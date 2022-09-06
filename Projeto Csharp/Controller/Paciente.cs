using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Csharp.Model
{
    internal class Paciente
    {
    ConexaoBD connection = new ConexaoBD();
    SqlCommand command = new SqlCommand();
    public string message="";


        private string _name = "";
        private string _birthday = "";
        private string _nature = "";
        private string _status = "";
        private string _height = "";
        private string _sex = "";
        private string _weight = "";
        private string _numBI = "";
        private string _lang = "";
        private string _email = "";
        private string _contact = "";
        private string _adress = "";
        private string _prof = "";
        private string _alergic = "";
        private string _workPlace = "";
        private string _donor = "";
        private string _bloodType = "";
        private string _chorincD = "";
        private string _emergencyNum = "";
        private string _restric = "";
        private string _vaccineted = "";
        private string _typeVaccine = "";

        public Paciente(string name, string birthday, string nature, string status, string height, 
            string sex, string weight, string numBI, string lang, string email, string contact, string adress, 
            string prof, string workPlace, string alergic, string donor, string bloodType, string chorincD, 
            string emergencyNum, string restric, string vaccineted, string typeVaccine)
        {
            Name = name;
            Birthday = birthday;
            Nature = nature;
            Status = status;
            Height = height;
            Sex = sex;
            Weight = weight;
            NumBI = numBI;
            Lang = lang;
            Email = email;
            Contact = contact;
            Adress = adress;
            Prof = prof;
            WorkPlace = workPlace;
            Alergic = alergic;
            Donor = donor;
            BloodType = bloodType;
            ChorincD = chorincD;
            EmergencyNum = emergencyNum;
            Restric = restric;
            Vaccineted = vaccineted;
            TypeVaccine = typeVaccine;


            command.CommandText = "INSERT INTO dbo.Paciente VALUES (@nome, @dataNasc, @naturalidade, @estadoCivil, @altura, @genero, @peso,  @BI, @lingua, " +
                "@email, @telefone, @endereco, @profissao, @localTrab, @alergias, @doador, @tipoSang, @doenca, @contatoEmerg, @restricoes, @vacinado, @tipoVacina);";

            //parametros
            command.Parameters.AddWithValue("@nome", name);
            command.Parameters.AddWithValue("@dataNasc", birthday);
            command.Parameters.AddWithValue("@naturalidade", nature);
            command.Parameters.AddWithValue("@estadoCivil", status);
            command.Parameters.AddWithValue("@altura", height);
            command.Parameters.AddWithValue("@genero", sex);
            command.Parameters.AddWithValue("@peso", weight);
            command.Parameters.AddWithValue("@BI", numBI);
            command.Parameters.AddWithValue("@lingua", lang);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@telefone", contact);
            command.Parameters.AddWithValue("@endereco", adress);
            command.Parameters.AddWithValue("@profissao", prof);
            command.Parameters.AddWithValue("@localTrab", workPlace);
            command.Parameters.AddWithValue("@alergias", alergic);
            command.Parameters.AddWithValue("@doador", donor);
            command.Parameters.AddWithValue("@tipoSang", bloodType);
            command.Parameters.AddWithValue("@doenca", chorincD);
            command.Parameters.AddWithValue("@contatoEmerg", emergencyNum);
            command.Parameters.AddWithValue("@restricoes", restric);
            command.Parameters.AddWithValue("@vacinado", vaccineted);
            command.Parameters.AddWithValue("@tipoVacina", typeVaccine);



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
            }
            catch (SqlException)
            {
                this.message = "Erro ao conectar com a base de dados";

            }


        }

        public string Name { get => _name; set => _name = value; }
        public string Birthday { get => _birthday; set => _birthday = value; }
        public string Nature { get => _nature; set => _nature = value; }
        public string Status { get => _status; set => _status = value; }
        public string Height { get => _height; set => _height = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public string Weight { get => _weight; set => _weight = value; }
        public string NumBI { get => _numBI; set => _numBI = value; }
        public string Lang { get => _lang; set => _lang = value; }
        public string Email { get => _email; set => _email = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Prof { get => _prof; set => _prof = value; }
        public string WorkPlace { get => _workPlace; set => _workPlace = value; }
        public string Alergic { get => _alergic; set => _alergic = value; }
        public string Donor { get => _donor; set => _donor = value; }
        public string BloodType { get => _bloodType; set => _bloodType = value; }
        public string ChorincD { get => _chorincD; set => _chorincD = value; }
        public string EmergencyNum { get => _emergencyNum; set => _emergencyNum = value; }
        public string Restric { get => _restric; set => _restric = value; }
        public string Vaccineted { get => _vaccineted; set => _vaccineted = value; }
        public string TypeVaccine { get => _typeVaccine; set => _typeVaccine = value; }
    }
}
