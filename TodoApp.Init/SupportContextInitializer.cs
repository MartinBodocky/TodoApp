﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Data;

namespace TodoApp.Init
{
    internal class SupportContextInitializer : DropCreateDatabaseAlways<SupportContext>
    {
        public SupportContextInitializer() { }

        #region Members

        protected override void Seed(SupportContext context)
        {
            // Generate the schema based on the entities
            base.Seed(context);

            //SeedMembership();

            // Set up the caches
            SetupMenuCache();

            // Insert all of the static data
            InsertStaticData(context);
        }



        private static void SetupSomeTestData(SupportContext context)
        {

            context.SaveChanges();
        }

        private static void SetupMenuCache()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["EntityContext"].ConnectionString;
            //SqlCacheDependencyAdmin.EnableNotifications(connectionString);

            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[Platform]");

            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[Venue]");
            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[VenueHour]");
            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[VenueOffline]");

            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[DeviceSettingValue]");
            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[SupportedPlatform]");
            //SqlCacheDependencyAdmin.EnableTableForNotifications(connectionString, "[dbo].[SystemConfiguration]");
        }

        // TODO : Check this is right on install
        private static void SeedMembership()
        {
        }


        public static void InsertStaticData(SupportContext context)
        {


            context.SaveChanges();
        }
        #endregion
    }
}
