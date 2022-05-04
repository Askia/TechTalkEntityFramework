using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Models
{
    public class SurveyPreview
    {
        public int Id { get; set; }

        public string HtmlContent { get; set; }

        public int SurveyId { get; set; }

        public virtual Survey Survey { get; set; }
    }

    public class SurveyPreviewEntityConfiguration : IEntityTypeConfiguration<SurveyPreview>
    {
        public void Configure(EntityTypeBuilder<SurveyPreview> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Survey)
                .WithOne(x => x.SurveyPreview)
                .HasForeignKey(nameof(SurveyPreview.SurveyId));
        }
    }
}
