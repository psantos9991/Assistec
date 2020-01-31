using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Serviços
{
    class Equipamento
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Aparelho { get; set; }
        public string EstadoAparelho { get; set; }
        public string Acessorios { get; set; }
        public string TipoAparelho { get; set; }
        public string AvariaTecnica { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();

    }
}
