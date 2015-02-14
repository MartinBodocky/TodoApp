using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data;

namespace TodoApp.Init
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This console application will update or reinstall your databases, you won't be able revert this operation");
                Console.WriteLine("Do you like upgrade your database for latest version. y / n ?");

                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.KeyChar.Equals('y'))
                {
                    // update migration

                    Console.WriteLine("Entity database migrate initializer starting..");
                    var migrationEntityContext = new MigrateDatabaseToLatestVersion<EntityContext, TodoApp.Data.EntityMigrations.Configuration>();
                    Database.SetInitializer(migrationEntityContext);
                    migrationEntityContext.InitializeDatabase(new EntityContext());

                    Console.WriteLine("Support database migrate initializer starting..");
                    var migrationSupportContext = new MigrateDatabaseToLatestVersion<SupportContext, TodoApp.Data.SupportMigrations.Configuration>();
                    Database.SetInitializer(migrationSupportContext);
                    migrationSupportContext.InitializeDatabase(new SupportContext());
                }
                else
                {
                    // re-create db
                    Console.WriteLine("Entity database initializer starting..");
                    var dbInitializer = new EntityContextInitializer();
                    Database.SetInitializer(dbInitializer);
                    dbInitializer.InitializeDatabase(new EntityContext());

                    Console.WriteLine("Support database initializer starting..");
                    var dbSupportInitializer = new SupportContextInitializer();
                    Database.SetInitializer(dbSupportInitializer);
                    dbSupportInitializer.InitializeDatabase(new SupportContext());
                }

                Console.WriteLine();
                Console.WriteLine("Initializer finished.. Click any key to exit.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
