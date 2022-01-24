using System.Collections.Generic;
using Manager.Domain.Entities;
using Manager.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Manager.Infra.Context {
    public class ManagerContext : DbContext{
        public ManagerContext()
        {
        
        }

        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options)
        {

        }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=USERMANAGERAPI;User Id=postgres;Password=Rsf049110;");
        }

        public virtual DbSet<User> Users  {get; set;}


        protected override void OnModelCreating(ModelBuilder builder){
            builder.ApplyConfiguration(new UserMap());
        }

        

      
    }

    
}