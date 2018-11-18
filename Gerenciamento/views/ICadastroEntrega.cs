using Gerenciamento.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.views
{
    public interface ICadastroEntrega
    {
        PCadastroEntrega Presenter { get; set; }
        int IdCaminhao { get; set; }
        DateTime DataSaida { get; set; }
        DateTime? DataChegada { get; set; }
        int KmFinal { get; set; }
        string Observacao { get; set; }
    }
}
