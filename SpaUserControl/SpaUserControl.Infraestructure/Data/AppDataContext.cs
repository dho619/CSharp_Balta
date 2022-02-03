using MySql.Data.EntityFramework;
using SpaUserControl.Domain.Models;
using SpaUserControl.Infraestructure.Data.Map;
using System.Data.Entity;

namespace SpaUserControl.Infraestructure.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppDataContext : DbContext
    {
        //public AppDataContext() : base("Server=localhost;Database=spauser;Uid=root;Pwd=061127;")
        public AppDataContext() : base("name=AppConnectionString")

        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}