using System;
using System.Data.Entity;

namespace SignalRWebApp.Models
{
    public class SignaRTestContext : DbContext
    {
        const String DefaultConnectionName = "SignaRTestConnection";

        #region "ctor"
        
        public SignaRTestContext() : this(DefaultConnectionName)
        {
        }
        
        public SignaRTestContext(String sqlConnectionName) : base(String.Format("Name={0}", sqlConnectionName))
        {
        }
        
        #endregion
        
        #region Collections Definitions

        public DbSet<Product> Products { get; set; }
        
        #endregion
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .ToTable("Parqueadero", "dbo")
                        .HasKey(t => t.ParqueaderoID);
        }
    }
}