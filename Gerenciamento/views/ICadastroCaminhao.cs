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
    }
}
