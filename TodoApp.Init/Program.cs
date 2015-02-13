using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data;
using TodoApp.Data.Migrations;

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
                    Console.WriteLine("Database migrate initializer starting..");
                    var migrationEntityContext = new MigrateDatabaseToLatestVersion<EntityContext, Configuration>();
                    Database.SetInitializer(migrationEntityContext);
                    migrationEntityContext.InitializeDatabase(new EntityContext());
                }
                else
                {
                    // re-create db
                    Console.WriteLine("Database initializer starting..");
                    var dbInitializer = new EntityContextInitializer();
                    Database.SetInitializer(dbInitializer);
                    dbInitializer.InitializeDatabase(new EntityContext());

                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
