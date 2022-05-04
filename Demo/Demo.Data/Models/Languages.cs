using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Demo.Data.Models
{
    public class Languages
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Survey> Surveys { get; set; }
    }

    public class LanguagesEntityConfiguration : IEntityTypeConfiguration<Languages>
    {
        public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Surveys).WithMany(x => x.Languages);
        }
    }
}
