using Microsoft.EntityFrameworkCore;

namespace blazorwebapp.Data
{

    
    public class Portweb : DbContext
    {

        
        
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;database=portweb;uid=root;password=clever");
        }*/

        public Portweb(DbContextOptions<Portweb> options) : base(options)
        { }
            public DbSet<AcercaDeModel> AcercaDeModel { get; set; }
            public DbSet<ExperienciaLaboralModel> ExperienciaLaboralModel { get; set; }

        /*
        public class YourDbContextFactory : IDesignTimeDbContextFactory<Portweb>
        {
            public Portweb CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<Portweb>();
                optionsBuilder.UseMySQL("defaultConn");

                return new Portweb(optionsBuilder.Options);
            }*/
          
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<AcercaDeModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre);
                entity.Property(e => e.Apellido);
                entity.Property(e => e.Descripcion);       
            });  
            modelBuilder.Entity<ExperienciaLaboralModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Empresa);
                entity.Property(e => e.Descripcion);
                entity.Property(e => e.Ubicacion);
            });          
        }*/



    }
}

