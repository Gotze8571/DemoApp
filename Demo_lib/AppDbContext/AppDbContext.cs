using DemoApp.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Data.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<FundTransaction_tbl> FundTransaction_tbls { get; set; }
        public DbSet<AccountInfo_tbl> AccountInfo_tbls { get; set; }
    }
}
