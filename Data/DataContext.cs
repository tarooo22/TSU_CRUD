using System.Collections.Generic;
using TSU_CRUD.Models.CustomerModel;
using TSU_CRUD.Models.EmployeeModel;
using TSU_CRUD.Models.ProductModel;
using Microsoft.EntityFrameworkCore;

namespace TSU_CRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
