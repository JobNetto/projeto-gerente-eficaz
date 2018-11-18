using Gerenciamento.model.Classes;
using Gerenciamento.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.model.Repository
{
    public class EntregaRep:Conexao
    {
        public EntregaRep()
        {
            Conectar();
        }

        public override void Alterar(object objeto)
        {
            if (objeto is Entrega)
            {
                var Entrega = objeto as Entrega;

                var sql = $@"UPDATE [dbo].[Entregas]
                           SET[IdCaminhao] = {Entrega.Id}
                              ,[DataSaida] = '{Entrega.DataSaida.ToString("yyyy-MM-dd")}'
                              ,[DataChegada] = '{Entrega.DataChegada.Value.ToString("yyyy-MM-dd")}'
                              ,[KmFinal] = {Entrega.KmFinal}
                              ,[Observacao] = '{Entrega.Observacao}'
                         WHERE Id= {Entrega.Id}";

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
            string sql = "SELECT * FROM Entregas";
            //sql += " WHERE placa LIKE '" + objeto.ToString().Replace("-", "").Replace(" ", "") + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public override void Inserir(object objeto)
        {
            if (objeto is Entrega)
            {
                var Entrega = objeto as Entrega;

                string sql = "";
                sql = $@"	INSERT INTO [dbo].[Entregas]
			   ([IdCaminhao]
			   ,[DataSaida]
			   ,[DataChegada]
			   ,[KmFinal]
			   ,[Observacao])
		 VALUES
			   ({Entrega.IdCaminhao}
			   ,'{Entrega.DataSaida.ToString("yyyy-MM-dd")}'
			   ,'{Entrega.DataChegada.Value.ToString("yyyy-MM-dd")}'
			   ,{Entrega.KmFinal}
			   ,'{Entrega.Observacao}')";

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

