using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Serviços
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telemovel { get; set; }
        public int Nif { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        List<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();

        public Cliente()
        {
        }

        public Cliente(string nome, int telemovel, int nif, string email, List<Equipamento> equipamentos)
        {
            Nome = nome;
            Telemovel = telemovel;
            Nif = nif;
            Email = email;
            Equipamentos = equipamentos;
        }
    }
}
