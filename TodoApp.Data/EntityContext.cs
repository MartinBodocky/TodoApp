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
    public class EntityContext : DbContext
    {
        public EntityContext() : base("TodoAppContext")
        {
            Database.SetInitializer<EntityContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<Device> Devices { get; set; }
        public virtual IDbSet<Platform> Platforms { get; set; }
        public virtual IDbSet<Customer> Customers { get; set; }
        public virtual IDbSet<Todo> Todos { get; set; }
        public virtual IDbSet<Comment> Comments { get; set; }
    }
}
