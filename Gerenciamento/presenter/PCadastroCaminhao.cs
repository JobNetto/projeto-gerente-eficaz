using Gerenciamento.model.Repository;
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
    public class PCadastroCaminhao
    {
        private readonly ICadastroCaminhao _v;
        private readonly CaminhaoRep _r;

        public PCadastroCaminhao(ICadastroCaminhao view)
        {
            _v = view;
            _v.Presenter = this;
            _r = new CaminhaoRep();
        }

        public void Gravar()
        {
            var caminhao = new Caminhao
            {
                Marca = _v.Marca,                            //public string Marca { get; set; }
                Placa = _v.Placa,                            //public string Placa { get; set; }
                Codigo = _v.Codigo,                          //public string Codigo { get; set; }
                Modelo = _v.Modelo,                            //public string Modelo { get; set; }
                AnoFabricacao = _v.AnoFabricacao,                            //public DateTime AnoFabricacao { get; set; }
                AnoModelo = _v.AnoModelo,                        //public DateTime AnoModelo { get; set; }
                Chassi = _v.Chassi,                       //public string Chassi { get; set; }
                CodRenavam = _v.CodRenavam,                         //public string CodRenavam { get; set; }
                Cor = _v.Cor,                          //public string Cor { get; set; }
                Capacidade = _v.Capacidade,      //public decimal Capacidade { get; set; }
                KmRodado = _v.Km                         //public int KmRodado { get; set; }
            };
            _r.Inserir(caminhao);
        }

        public void Salvar(int id)
        {
            if (id == 0) return;

            var caminhao = new Caminhao
            {
                Id = id,                           //    public int Id { get; set; }
                Marca = _v.Marca,                            //public string Marca { get; set; }
                Placa = _v.Placa,                            //public string Placa { get; set; }
                Codigo = _v.Codigo,                          //public string Codigo { get; set; }
                Modelo = _v.Modelo,                            //public string Modelo { get; set; }
                AnoFabricacao = _v.AnoFabricacao,                            //public DateTime AnoFabricacao { get; set; }
                AnoModelo = _v.AnoModelo,                        //public DateTime AnoModelo { get; set; }
                Chassi = _v.Chassi,                       //public string Chassi { get; set; }
                CodRenavam = _v.CodRenavam,                         //public string CodRenavam { get; set; }
                Cor = _v.Cor,                          //public string Cor { get; set; }
                Capacidade = _v.Capacidade,      //public decimal Capacidade { get; set; }
                KmRodado = _v.Km                         //public int KmRodado { get; set; }
            };

            _r.Alterar(caminhao);
            MessageBox.Show("Dados foram salvos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
