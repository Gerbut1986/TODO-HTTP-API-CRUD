namespace HTTP_TODO_API.Models
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskList> CustomLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().Property(u => u.Priority).HasDefaultValue(Priority.Medium);
            modelBuilder.Entity<Task>().Property(u => u.Status).HasDefaultValue(Status.Active);
            modelBuilder.Entity<Task>().Property(u => u.Created).HasDefaultValue(System.DateTime.Now);
            modelBuilder.Entity<Task>().HasOne(l => l.CustomList).WithMany(t => t.Tasks).OnDelete(DeleteBehavior.SetNull);
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
