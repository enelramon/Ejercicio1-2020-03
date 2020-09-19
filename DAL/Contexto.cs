
using Ejercicio1_2020_03.Models;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio1_2020_03.DAL{
    public class Contexto : DbContext
    { 
        public DbSet<Estudiantes> Estudiantes { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\TeacherControl.db");
        }
    }
}