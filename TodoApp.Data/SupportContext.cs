using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.DataContracts.Entities;

namespace TodoApp.Data
{
    public class SupportContext : DbContext, ISupportContext
    {
        public SupportContext()
            : base("TodoAppSupportContext")
        {
            Database.SetInitializer<SupportContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<CommunicationLog> CommunicationLog { get; set; }
        public virtual IDbSet<ExceptionLog> ExceptionLog { get; set; }


        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

    }
}
