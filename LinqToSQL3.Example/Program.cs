using Db.DataAccess.DataSet;
using LinqToSQL3.Example.DataAccess;
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
            var dbContext = new DbContext(connectionString);
            InsertSomeEntities(dbContext);
            //TestLoadMany(dbContext);

            ////var testTable = dbContext.TestTable1s.ToList();
            //var testTable2 = dbContext.TestTable2s.ToList();
            //var orders = dbContext.Orders.ToList();
            //var items = orders.SelectMany(o => o.Items).ToList();
            //var users = dbContext.Persons.ToList();
        }

        private static void TestLoadMany(DbContext dbContext)
        {
            var testTable1s = dbContext.TestTable1s.ToList();
        }

        static string GetConnectionString(string jsonFileName)
        {
            var connectionSettings = JsonConvert.DeserializeObject<ConnectionSettings>(File.ReadAllText(jsonFileName));
            var connectionStrings = connectionSettings.DbConnectionStrings.Db1;
            return connectionStrings;
        }

        static void InsertSomeEntities(DbContext dbContext)
        {
            for (int i = 0; i < 1000; i++)
            {
                var table1s = new TestTable1();
                table1s.Dummy = "Testin";
                table1s.Dummy2 = i;
                dbContext.InsertOnSubmit(table1s);
            }
            dbContext.SubmitChanges();
        }
    }
}
