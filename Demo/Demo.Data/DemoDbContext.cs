using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options)
        { }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Languages> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SurveyEntityConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SurveyPreviewEntityConfiguration());
            modelBuilder.ApplyConfiguration(new LanguagesEntityConfiguration());
        }
    }
}
