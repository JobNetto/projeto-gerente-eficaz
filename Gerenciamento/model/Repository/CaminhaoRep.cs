using Gerenciamento.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gerenciamento.models;
using System.Data.SqlClient;

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
            if (objeto is Caminhao)
            {
                var caminhao = objeto as Caminhao;

                var sql = $@"UPDATE [dbo].[Caminhao]
                       SET [Marca] = '{caminhao.Marca}'
                          ,[Placa] = '{caminhao.Placa}'
                          ,[Codigo] = '{caminhao.Codigo}'
                          ,[Modelo] = '{caminhao.Modelo}'
                          ,[AnoFabricacao] = '{caminhao.AnoFabricacao.ToString("yyyy-MM-dd")}'
                          ,[AnoModelo] = '{caminhao.AnoModelo.ToString("yyyy-MM-dd")}'
                          ,[Chassi] = '{caminhao.Chassi}'
                          ,[CodRenavam] = '{caminhao.CodRenavam}'
                          ,[Cor] = '{caminhao.Cor}'
                          ,[Capacidade] = CONVERT(DECIMAL(16,2),{caminhao.Capacidade})
                          ,[KmRodado] = {caminhao.KmRodado}
                     WHERE Id= {caminhao.Id}
                    ";

                SqlCommand cd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = sql
                };

                cd.ExecuteNonQuery();
            }

           
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataSet GetAll(object objeto)
        {
            string sql = "SELECT * FROM caminhao";
            sql += " WHERE placa LIKE '" + objeto.ToString().Replace("-","").Replace(" ","") + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public override void Inserir(object objeto)
        {
            if (objeto is Caminhao)
            {
                var caminhao = objeto as Caminhao;

                string sql = "";
                sql = $@"INSERT INTO [dbo].[Caminhao]
           ([Marca]
           ,[Placa]
           ,[Codigo]
           ,[Modelo]
           ,[AnoFabricacao]
           ,[AnoModelo]
           ,[Chassi]
           ,[CodRenavam]
           ,[Cor]
           ,[Capacidade]
           ,[KmRodado])
     VALUES
           ('{caminhao.Marca}'
           ,'{caminhao.Placa}'
           ,'{caminhao.Codigo}'
           ,'{caminhao.Modelo}'
           ,'{caminhao.AnoFabricacao.ToString("yyyy-MM-dd")}'
           ,'{caminhao.AnoModelo.ToString("yyyy-MM-dd")}'
           ,'{caminhao.Chassi}'
           ,'{caminhao.CodRenavam}'
           ,'{caminhao.Cor}'
           ,{caminhao.Capacidade}
           ,CONVERT(DECIMAL(16,2),{caminhao.KmRodado})
)";

                SqlCommand cd = new SqlCommand
                {
                    Connection = cn,
                    CommandText = sql
                };

                cd.ExecuteNonQuery();
            }
        }
    }
}
