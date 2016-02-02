using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace chk12345.DBFolder
{
    public class dbContext :DbContext
    {
        public DbSet<user> users { get; set; }
    }
}