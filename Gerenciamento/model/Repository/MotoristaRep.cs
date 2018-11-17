using Gerenciamento.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.Repository
{
    public class MotoristaRep : Conexao
    {
        public MotoristaRep()
        {
            Conectar();
        }

        public override void Inserir(object objeto)
        {
            if (objeto is Motorista)
            {
                var motorista = objeto as Motorista;

                string sql = "";
                sql = $@"INSERT INTO [dbo].[Motorista]
           ([Nome]
           ,[Codigo]
           ,[Rua]
           ,[Bairro]
           ,[Numero]
           ,[Complemento]
           ,[Cidade]
           ,[UF]
           ,[CEP]
           ,[Telefone1]
           ,[Telefone2]
           ,[RG]
           ,[CPF])
     VALUES
           ('{motorista.Nome}',
            '{motorista.Codigo}',
            '{motorista.Rua}',
            '{motorista.Bairro}',
            '{motorista.Numero}',
            '{motorista.Complemento}',
            '{motorista.Cidade}',
             {motorista.Uf},
            '{motorista.CEP}',
            '{motorista.Telefone1}',
            '{motorista.Telefone2}',
            '{motorista.RG}',
            '{motorista.CPF}'
            )";
                SqlCommand cd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = sql
                };

                cd.ExecuteNonQuery();
            }
        }

        public override void Alterar(object objeto)
        {
            if (objeto is Motorista)
            {
                var motorista = objeto as Motorista;

            }
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataSet GetAll()
        {
            throw new NotImplementedException();
        }

      

    }
}
