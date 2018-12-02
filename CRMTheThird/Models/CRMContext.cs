using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRMTheThird.Models
{
    public class CRMContext:DbContext
    {
        public System.Data.Entity.DbSet<CRMTheThird.Models.User> Users { get; set; }
    }
}