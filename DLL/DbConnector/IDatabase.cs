using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avance_3.DbConnector
{
    public interface IDatabase
    {

        void EstablecerConexion();
        void SqlQuery(string query);
        void Execute();
        void CloseConnection();

    }
}
