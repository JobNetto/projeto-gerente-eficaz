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

        public PCadastroMorista(ICadastroMotorista view)
        {
            _v = view;
            _v.Presenter = this;
        }
    }
}
