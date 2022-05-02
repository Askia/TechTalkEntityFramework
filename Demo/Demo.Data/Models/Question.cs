using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public virtual Survey Survey { get; set; }
    }

    public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Survey).WithMany(x => x.Questions);
        }
    }
}
