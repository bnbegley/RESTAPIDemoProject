using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTDemoProject_WebAPI_.Models {
    public class WebServiceDB : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

    public WebServiceDB(DbContextOptions options) : base(options) {}

    }
}
