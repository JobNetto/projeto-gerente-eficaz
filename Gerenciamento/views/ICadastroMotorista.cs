using Gerenciamento.models;
using Gerenciamento.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.views
{
    public interface ICadastroMotorista
    {
        PCadastroMorista Presenter { get; set; }
        string Nome { get; set; }
        string Codigo { get; set; }
        string Rua { get; set; }
        string Bairro { get; set; }
        string Numero { get; set; }
        string RG { get; set; }
        string CPF { get; set; }

        string Complemento { get; set; }
        string Cidade { get; set; }
        string Uf { get; set; }
        string CEP { get; set; }
        string Telefone1 { get; set; }
        string Telefone2 { get; set; }
        CategoriaHabilitacao Categoria { get; set; }
    }
}
