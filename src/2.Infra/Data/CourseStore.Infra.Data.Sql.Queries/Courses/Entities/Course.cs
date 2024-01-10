using CourseStore.Infra.Data.Sql.Queries.Common.Entities;
using CourseStore.Infra.Data.Sql.Queries.Teachers.Entities;
using System.Reflection.Metadata.Ecma335;

namespace CourseStore.Infra.Data.Sql.Queries.Courses.Entities;
public class Course : QueryObject<int>
{
    #region Properties
    public string Title { get; set; }
    public long Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public Teacher Teacher { get; set; }
    public int TeacherId { get; set; }
    #endregion


}

