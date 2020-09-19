 public class Contexto : DbContext
    { 
        public DbSet<Estudiantes> Estudiantes { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\TeacherControl.db");
        }
    }