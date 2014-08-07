using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.dbs
{
    public class mycontext:DbContext
    {
        DbSet<Student> Students { get; set; }
    }
}