using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Models
{
    public class Survey
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? SurveyPreviewId { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public virtual SurveyPreview SurveyPreview { get; set; }

        public virtual ICollection<Languages> Languages { get; set; }
    }

    public class SurveyEntityConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(100)");

            //builder.HasOne(x => x.SurveyPreview)
            //   .WithOne(x => x.Survey)
            //   .HasForeignKey(nameof(SurveyPreview.SurveyId));

            builder.HasOne(s => s.SurveyPreview)
                .WithOne(sp => sp.Survey);
        }
    }
}