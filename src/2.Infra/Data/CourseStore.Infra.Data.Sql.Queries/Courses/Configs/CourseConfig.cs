using CourseStore.Infra.Data.Sql.Queries.Courses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CourseStore.Infra.Data.Sql.Queries.Courses.Configs;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {

    }
}