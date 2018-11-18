using Gerenciamento.model.Classes;
using Gerenciamento.model.Repository;
using Gerenciamento.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.presenter
{
    public class PCadastroEntrega
    {
        private readonly views.ICadastroEntrega _v;
        private readonly EntregaRep _r;

        public PCadastroEntrega(ICadastroEntrega view)
        {
            _v = view;
            _v.Presenter = this;
            _r = new EntregaRep();
        }

        public void Salvar()
        {
            var entrega = new Entrega();

            entrega.IdCaminhao = _v.IdCaminhao;
            entrega.KmFinal = _v.KmFinal;
            entrega.Observacao = _v.Observacao;
            entrega.DataChegada = _v.DataChegada;
            entrega.DataSaida = _v.DataSaida;

            _r.Inserir(entrega);
        }

        public void Alterar(int id)
        {
            var entrega = new Entrega();

            entrega.Id = id;
            entrega.IdCaminhao = _v.IdCaminhao;
            entrega.KmFinal = _v.KmFinal;
            entrega.Observacao = _v.Observacao;
            entrega.DataChegada = _v.DataChegada;
            entrega.DataSaida = _v.DataSaida;

            _r.Alterar(entrega);
        }
    }
}
