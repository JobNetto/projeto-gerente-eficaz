using Gerenciamento.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gerenciamento.model.Repository
{
    public class CaminhaoRep: Conexao
    {
        public CaminhaoRep()
        {
            Conectar();
        }

        public override void Alterar(object objeto)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataSet GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Inserir(object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
