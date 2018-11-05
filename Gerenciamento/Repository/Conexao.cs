using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento.Repository
{
    public abstract class Conexao
    {
        protected SqlConnection cn = new SqlConnection();
        protected void Conectar()
        {
            string s = "";
            s = "Server=DESKTOP-PQSDVH0\\SQLEXPRESS;Database=GERENTE_EFICAZ;UID=sa;PWD=123;";
            cn.ConnectionString = s;
            cn.Open();
        }

        protected void Desconectar()
        {
            cn.Close();
        }

        protected readonly Conexao connection;

        public abstract void Inserir(object objeto);

        public abstract void Alterar(object objeto);

        public abstract void Delete(int id);

        public abstract DataSet GetAll();
    }
}
