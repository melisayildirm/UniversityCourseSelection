
namespace UniversityCourseSelection.Data
{
    using Microsoft.EntityFrameworkCore;
    using UniversityCourseSelection.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Advisors> Advisors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<StudentCourseSelections> StudentCourseSelections { get; set; }
        public DbSet<Transcripts> Transcripts { get; set; }
        public DbSet<Users> Users { get; set; }
    }

}
