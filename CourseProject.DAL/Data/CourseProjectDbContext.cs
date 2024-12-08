using CourseProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.DAL.Data
{
    public class CourseProjectDbContext : DbContext
    {
        public CourseProjectDbContext(DbContextOptions<CourseProjectDbContext> options) : base(options)
        {
        }

        public DbSet<Boiler> Boilers { get; set; }
        public DbSet<TemperatureSensor> TemperatureSensors { get; set; }
        public DbSet<SensorReading> SensorReadings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Boiler>().HasKey(b => b.Id);
            modelBuilder.Entity<TemperatureSensor>().HasKey(ts => ts.Id);
            modelBuilder.Entity<SensorReading>().HasKey(sr => sr.Id);
        }
    }
}