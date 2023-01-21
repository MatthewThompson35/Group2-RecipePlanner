﻿using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipePlannerDesktopApplication.Connections
{
    /// <summary>
    ///     The database connection information.
    /// </summary>
    public static class Connection
    {
        public static readonly string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=RecipePlanner;Trusted_Connection=True;";
    }
}
