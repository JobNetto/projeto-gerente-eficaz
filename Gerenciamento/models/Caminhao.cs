using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.models
{
    public class Caminhao
    {
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Codigo { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; } 
        public DateTime AnoModelo { get; set; }
        public string Chassi { get; set; }
        public string CodRenavam { get; set; }
        public string Cor { get; set; }
        public string Capacidade { get; set; }
        public string KmInicial { get; set; }


    }
}
