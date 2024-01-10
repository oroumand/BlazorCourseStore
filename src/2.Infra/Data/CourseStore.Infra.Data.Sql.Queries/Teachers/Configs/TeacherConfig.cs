using CourseStore.Infra.Data.Sql.Queries.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CourseStore.Infra.Data.Sql.Queries.Teachers.Configs;

public class TeacherConfig : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {

    }
}