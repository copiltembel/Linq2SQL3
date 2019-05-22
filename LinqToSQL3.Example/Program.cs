using Db.DataAccess.DataSet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL3.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = GetConnectionString("connectionstrings.json");
            var dbContext = new DbDataContext(connectionString);
            //var testTable = dbContext.TestTable1s.ToList();
            var testTable2 = dbContext.TestTable2s.ToList();
            var orders = dbContext.Orders.ToList();
            var items = orders.SelectMany(o => o.Items).ToList();
            var users = dbContext.Persons.ToList();
        }

        static string GetConnectionString(string jsonFileName)
        {
            var connectionSettings = JsonConvert.DeserializeObject<ConnectionSettings>(File.ReadAllText(jsonFileName));
            var connectionStrings = connectionSettings.DbConnectionStrings.Db1;
            return connectionStrings;
        }
    }
}
