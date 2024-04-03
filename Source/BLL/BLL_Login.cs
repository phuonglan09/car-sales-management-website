using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Login
    {
        private ConnectDB connectDB;

        public BLL_Login()
        {
            connectDB = new ConnectDB();
        }

        public bool LoginSuccess( string tendn, string pass, string quyen)
        {
            DataTable dt = connectDB.getDataTable("Account");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ( dt.Rows[i][1].ToString().Trim().Equals(tendn)
                    && dt.Rows[i][2].ToString().Trim().Equals(pass)
                    && dt.Rows[i][3].ToString().Trim().Equals(quyen))
                {
                    connectDB.CloseConnection();
                    return true;
                }
            }
            connectDB.CloseConnection();
            return false;
        }
    }
}
