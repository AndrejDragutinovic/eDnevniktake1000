using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace eDnevnik
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            String CS;
            CS = "Data Source = DESKTOP-D7QNBFQ\\SQLEXPRESS; Initial Catalog = ednevnik; Integrated Security = True";
            SqlConnection veza = new SqlConnection(CS);
            return (veza);
        }

    }
}
