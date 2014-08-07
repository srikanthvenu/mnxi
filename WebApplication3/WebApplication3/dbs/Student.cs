using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.dbs
{
    public class Student
    {

        public virtual int id { get; set; }
        public virtual string Name { get; set; }
        public virtual int grade { get; set; }

    }
}