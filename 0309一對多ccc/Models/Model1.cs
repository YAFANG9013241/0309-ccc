using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _0309一對多ccc.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Cus> Cus { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}