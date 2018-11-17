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
            s = "Server=DESKTOP-ON3EB4R;Database=PROJETO_GERENTE_EFICAZ;UID=job;PWD=1;";
            var e = @"Data Source=DESKTOP-ON3EB4R;Initial Catalog=PROJETO_GERENTE_EFICAZ; persist security info=True; Integrated Security=SSPI;";

            cn.ConnectionString = e;
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

        public abstract DataSet GetAll(object nome);
    }
}
