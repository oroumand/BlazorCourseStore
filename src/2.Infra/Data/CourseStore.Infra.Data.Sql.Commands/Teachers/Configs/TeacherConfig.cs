using CourseStore.Core.Domain.Teachers.Entities;
using CourseStore.Core.Resources;
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
            builder.Property(c => c.FirstName).HasMaxLength(ProjectConsts.NAME_MAX_LENGTH);
            builder.Property(c => c.LastName).HasMaxLength(ProjectConsts.NAME_MAX_LENGTH);
            builder.Property(c => c.Description).HasMaxLength(ProjectConsts.DESCRIPTION_MAX_LENGTH);
            builder.Property(c => c.ImageUrl).HasMaxLength(ProjectConsts.URI_MAX_LENGTH);

        }
    }
}
