using CourseStore.Core.Domain.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.Infra.Data.Sql.Commands.Teachers.Configs
{
    internal class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(c => c.Id);
            builder.Property(c => c.BusinessId).IsRequired();
            builder.HasIndex(c => c.BusinessId).IsUnique();
            builder.Property(c => c.FirstName).HasMaxLength(250);
            builder.Property(c => c.LastName).HasMaxLength(250);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.ImageUrl).HasMaxLength(1000);

        }
    }
}
