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
                              ,[DataSaida] = '{Entrega.DataSaida.ToString("dd-MM-yyyy")}'
                              ,[DataChegada] = '{Entrega.DataChegada.Value.ToString("dd-MM-yyyy")}'
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
            string[] data = objeto.ToString().Split('.');
            string sql = "SELECT * FROM Entregas";
            //sql += " WHERE DataSaida BETWEEN '" + data[0] + "' and '" + data[1] + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //public override DataSet GetAll(DateTime Inicial, DateTime Final)
        //{
        //    string sql = "SELECT * FROM Entregas";
        //    sql += " WHERE DataSaida BETWEEN " + @Inicial +" and "+ @Final;
        //    SqlDataAdapter da = new SqlDataAdapter(sql, cn);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

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
			   ,'{Entrega.DataSaida.ToString("dd-MM-yyyy")}'
			   ,'{Entrega.DataChegada.Value.ToString("dd-MM-yyyy")}'
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

