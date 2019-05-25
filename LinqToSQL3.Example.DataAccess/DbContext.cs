using Db.DataAccess.DataSet;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL3.Example.DataAccess
{
    public class DbContext : DbDataContext
    {
        public DbContext(string connection) :
            base(connection)
        {
        }

        public virtual void DeleteOnSubmit<TDbEntity>(IReadOnlyList<TDbEntity> dbEntities) where TDbEntity : DbEntityBase
        {
            this.GetTable<TDbEntity>().DeleteAllOnSubmit(dbEntities);
        }

        public virtual void InsertOnSubmit<TDbEntity>(IReadOnlyList<TDbEntity> dbEntities) where TDbEntity : DbEntityBase
        {
            this.GetTable<TDbEntity>().InsertAllOnSubmit(dbEntities);
        }

        public virtual void InsertOnSubmit<TDbEntity>(TDbEntity dbEntity) where TDbEntity : DbEntityBase
        {
            this.GetTable<TDbEntity>().InsertOnSubmit(dbEntity);
        }

        public virtual void DeleteOnSubmit<TDbEntity>(TDbEntity dbEntity) where TDbEntity : DbEntityBase
        {
            this.GetTable<TDbEntity>().DeleteOnSubmit(dbEntity);
        }
    }
}
