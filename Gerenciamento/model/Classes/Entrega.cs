using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.model.Classes
{
    public class Entrega
    {
        public int Id { get; set; }
        public int IdCaminhao { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime? DataChegada { get; set; }
        public int KmFinal { get; set; }
        public string Observacao { get; set; }
    }
}
