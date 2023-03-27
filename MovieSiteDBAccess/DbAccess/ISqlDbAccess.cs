using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.DbAccess
{
    public interface ISqlDbAccess
    {
        Task<IEnumerable<T>> GetDataFromSql<T, TU>(string storedProcedure, TU parameter,
            string connectionId = "Default");

        Task SendDataToSql<T>(string storedProcedure, T parameter, string connectionId = "Default");
    }
}
