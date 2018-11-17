using Gerenciamento.models;
using Gerenciamento.Repository;
using Gerenciamento.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.presenter
{
    public class PCadastroMorista
    {
        private readonly ICadastroMotorista _v;
        private readonly MotoristaRep _r;
        public PCadastroMorista(ICadastroMotorista view)
        {
            _v = view;
            _v.Presenter = this;
        }

        public void Gravar()
        {
            var motorista = new Motorista {
                Nome = _v.Nome,
                Codigo = _v.Codigo
            };

            _r.Inserir(motorista);
        }
    }
}
