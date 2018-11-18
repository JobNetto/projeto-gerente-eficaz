using Gerenciamento.models;
using Gerenciamento.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.views
{
    public interface ICadastroCaminhao
    {
        PCadastroCaminhao Presenter { get; set; }
        string Marca { get; set; }
        string Placa { get; set; }
        string Codigo { get; set; }
        string Modelo { get; set; }
        DateTime AnoFabricacao { get; set; }
        DateTime AnoModelo { get; set; }
        string Chassi { get; set; }
        string CodRenavam { get; set; }
        CategoriaHabilitacao Categoria { get; set; }
        TipoCombustivel Combustivel { get; set; }
        string Cor { get; set; }
        decimal Capacidade { get; set; }
        int Km { get; set; }
     }
}
