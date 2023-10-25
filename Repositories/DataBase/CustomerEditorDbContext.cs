using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DataBase
{
    public class CustomerEditorDbContext : DbContext
    {
        public DbSet<Models.Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=mssql13.unoeuro.com;Database=shocknet_dk_db_test;" +
                "User Id=shocknet_dk;Password=FkEHxcB432DAbamzp5tw;TrustServerCertificate=True");
        }
    }
}
