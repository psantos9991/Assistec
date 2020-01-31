using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Serviços
{
    class Utilizador
    {
        public int ID { get; set; }
        string UserControl { get; set; }
        string Nome { get; set; }
        string UtilizadorS { get; set; }
        string Palavrapasse { get; set; }
        string Tipoconta { get; set; }

        public Utilizador()
        {
        }

        public Utilizador(string userControl, string nome, string utilizadorS, string palavrapasse, string tipoconta)
        {
            UserControl = userControl;
            Nome = nome;
            UtilizadorS = utilizadorS;
            Palavrapasse = palavrapasse;
            Tipoconta = tipoconta;
        }
    }
}
