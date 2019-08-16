using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Avance_3.DbConnector
{
    class SQLDbConnect
    {
        public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["RevivalConnection"].ConnectionString);
        public SqlCommand comando = new SqlCommand(ConfigurationManager.ConnectionStrings["RevivalConnection"].ConnectionString);
       

        public SQLDbConnect()
        {

            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["RevivalConnection"].ConnectionString;
            //comando.Connection = conexion;

        }

        /// <summary>
        /// Establece la conexción a la base de datos
        /// </summary>
        public void EstablecerConexion()
        {

            conexion.ConnectionString = ConfigurationManager.ConnectionStrings["RevivalConnection"].ConnectionString;
            conexion.Open();
        }

        /// <summary>
        /// Establece el query a ejecutar
        /// </summary>
        /// <param name="queryText"></param>
        public void SqlQuery(string queryText)
        {
            comando = new SqlCommand(queryText, conexion);
        }


        /// <summary>
        /// Ejecuta el query
        /// </summary>
        public void Execute()
        {
            EstablecerConexion();
            comando.ExecuteNonQuery();
        }

        /// <summary>
        /// Finaliza la conexción a la base de datos
        /// </summary>
        public void CloseConnection()
        {
            conexion.Close();
        }
    }
}
