﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Allie.Models
{
    public class UserContext : DbContext
    {
    
        public UserContext() : base("name=UserContext")
        {

        }

        public System.Data.Entity.DbSet<AllieEntity.User> Users { get; set; }

    }
}
