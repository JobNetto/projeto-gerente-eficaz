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
                var g = motorista.Telefone1.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ","");
                string sql = "";
                sql = $@"
            INSERT INTO [dbo].[Motorista]
           ([Nome]
           ,[Codigo]
           ,[Rua]
           ,[Bairro]
           ,[Numero]
           ,[Complemento]
           ,[Cidade]
           ,[Uf]
           ,[CEP]
           ,[Telefone1]
           ,[Telefone2]
           ,[RG]
           ,[CPF])
     VALUES
           ('{motorista.Nome}'
           ,'{motorista.Codigo}'
           ,'{motorista.Rua}'
           ,'{motorista.Bairro}'
           ,'{motorista.Numero}'
           ,'{motorista.Complemento}'
           ,'{motorista.Cidade}'
           ,'{motorista.Uf}'
           ,'{motorista.CEP.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
           ,'{motorista.Telefone1.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
           ,'{motorista.Telefone2.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
           ,'{motorista.RG.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
           ,'{motorista.CPF.Replace("(","").Replace(")","").Replace("-","").Replace("_", "").Replace(".","").Replace(" ", "")}')";
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

                string sql = "";
                sql = $@"UPDATE [dbo].[Motorista]
                       SET [Nome] = '{motorista.Nome}'
                          ,[Codigo] = '{motorista.Codigo}'
                          ,[Rua] = '{motorista.Rua}'
                          ,[Bairro] = '{motorista.Bairro}'
                          ,[Numero] ='{motorista.Numero}'
                          ,[Complemento] =  '{motorista.Complemento}'
                          ,[Cidade] = '{motorista.Cidade}'
                          ,[Uf] = '{motorista.Uf}'
                          ,[CEP] = '{motorista.CEP.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
                          ,[Telefone1] ='{motorista.Telefone1.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
                          ,[Telefone2] =  '{motorista.Telefone2.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
                          ,[RG] =  '{motorista.RG}'
                          ,[CPF] =   '{motorista.CPF.Replace("(", "").Replace(")", "").Replace("-", "").Replace("_", "").Replace(".", "").Replace(" ", "")}'
                     WHERE Id = {motorista.Id}";
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

        public override DataSet GetAll()
        {
            string sql = "SELECT * FROM MOTORISTA";
            //  sql += " Where NomeCliente like '" + Nome + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //public void IncluirCliente()
        //{
        //    cx.Conectar();
        //    string sql = "";
        //    sql = "Insert into Cliente (NomeCliente,AlturaCliente,PesoCliente,Sexo) values(";
        //    sql += "'" + Nome + "'," + Altura + "," + Peso + ",'" + Sexo + "')";
        //    SqlCommand cd = new SqlCommand();
        //    cd.Connection = cx.cn;
        //    cd.CommandText = sql;
        //    cd.ExecuteNonQuery();
        //    cx.Desconectar();
        //}

        //public void AlterarCliente()
        //{
        //    cx.Conectar();
        //    string sql = "";
        //    sql = "Update Cliente set NomeCliente = '" + Nome + "',AlturaCliente = '" + Altura.ToString().Replace(",", ".") + ",PesoCliente = " + Peso.ToString().Replace(",", ".") + ",Sexo = '" + Sexo + "'";
        //    sql += "Where idCliente = " + idCliente.ToString();
        //    SqlCommand cd = new SqlCommand();
        //    cd.Connection = cx.cn;
        //    cd.CommandText = sql;
        //    cd.ExecuteNonQuery();
        //    cx.Desconectar();
        //}

        //public void ExcluirCliente()
        //{
        //    cx.Conectar();
        //    string sql = "";
        //    sql = "Delete from Cliente Where idCliente = " + idCliente.ToString();
        //    SqlCommand cd = new SqlCommand();
        //    cd.Connection = cx.cn;
        //    cd.CommandText = sql;
        //    cd.ExecuteNonQuery();
        //    cx.Desconectar();
        //}

        //public DataSet ListarCliente()
        //{
        //    cx.Conectar();
        //    string sql = "";
        //    sql = "Select idCliente, NomeCliente from Cliente";
        //    sql += " Where NomeCliente like '" + Nome + "%'";
        //    SqlDataAdapter da = new SqlDataAdapter(sql, cx.cn);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    cx.Desconectar();
        //    return ds;
        //}

        //public void ConsultaCliente()
        //{
        //    cx.Conectar();
        //    string sql = "";
        //    sql = "Select * from Cliente Where idCliente = " + idCliente.ToString();
        //    SqlCommand cd = new SqlCommand();
        //    cd.Connection = cx.cn;
        //    cd.CommandText = sql;
        //    SqlDataReader dr = cd.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        Nome = dr["NomeCliente"].ToString();
        //        Altura = double.Parse(dr["AlturaCliente"].ToString());
        //        Peso = double.Parse(dr["PesoCliente"].ToString());
        //        Sexo = char.Parse(dr["Sexo"].ToString());
        //    }
        //}
    }
}
