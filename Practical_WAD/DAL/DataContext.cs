namespace Practical_WAD.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Practical_WAD.Models;
   

    public partial class DataContext : DbContext
    {
        public DataContext(): base("name=DataContext")
        {
           
        }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Practical_WAD.Models.Employee> Employees { get; set; }

        //DbSet<Employee> Employees { get; set; }
    }
}
