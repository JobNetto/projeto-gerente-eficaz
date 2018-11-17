using Gerenciamento.models;
using Gerenciamento.Repository;
using Gerenciamento.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _r = new MotoristaRep();
        }

        public void Gravar()
        {
            var motorista = new Motorista {
                Nome = _v.Nome,
                Codigo = _v.Codigo,
                Rua = _v.Rua,
                Bairro = _v.Bairro,
                Numero = _v.Numero,
                Complemento = _v.Complemento,
                Cidade = _v.Cidade,
                Uf = _v.Uf,
                CEP = _v.CEP,
                Telefone1 = _v.Telefone1,
                Telefone2 = _v.Telefone2,
                RG  = _v.RG,
                CPF = _v.CPF
            };

            _r.Inserir(motorista);
        }

        public void Salvar(int id)
        {
            if (id == 0) return;

            var motorista = new Motorista
            {
                Id = id,
                Nome = _v.Nome,
                Codigo = _v.Codigo,
                Rua = _v.Rua,
                Bairro = _v.Bairro,
                Numero = _v.Numero,
                Complemento = _v.Complemento,
                Cidade = _v.Cidade,
                Uf = _v.Uf,
                CEP = _v.CEP,
                Telefone1 = _v.Telefone1,
                Telefone2 = _v.Telefone2,
                RG = _v.RG,
                CPF = _v.CPF
            };

            _r.Alterar(motorista);
            MessageBox.Show("Dados foram salvos com sucesso!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


    }
}
