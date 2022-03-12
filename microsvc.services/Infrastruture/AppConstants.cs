using System;
using System.Collections.Generic;
using System.Text;

namespace microsvc.services.Infrastruture
{
    public static class AppConstants
    {
        public static string UserMigrationBasePath => "../microsvc.services/Migrations/userdb/sql/";
        public static string OrderMigrationBasePath => "../microsvc.services/Migrations/orderdb/sql/";
    }
}
