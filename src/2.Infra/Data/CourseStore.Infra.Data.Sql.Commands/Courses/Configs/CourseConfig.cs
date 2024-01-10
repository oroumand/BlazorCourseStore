using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Teachers.Entities;
using CourseStore.Core.Resources;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.Infra.Data.Sql.Commands.Courses.Configs
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Id);
            builder.Property(c => c.BusinessId).IsRequired();
            builder.HasIndex(c => c.BusinessId).IsUnique();
            builder.ComplexProperty(c => c.Price, d => d.Property(n => n.Value).HasColumnName("Price"));
            builder.Property(c => c.Description).HasMaxLength(ProjectConsts.DESCRIPTION_MAX_LENGTH);
            builder.Property(c => c.ImageUrl).HasMaxLength(ProjectConsts.URI_MAX_LENGTH);
            builder.HasOne<Teacher>().WithMany().HasForeignKey("TeacherId");
        }
    }
}
