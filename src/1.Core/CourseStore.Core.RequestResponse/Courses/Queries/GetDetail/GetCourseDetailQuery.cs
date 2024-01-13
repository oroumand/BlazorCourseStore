using CourseStore.Core.RequestResponse.Courses.Queries.GetPagedFilter;
using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.RequestResponse.Courses.Queries.GetDetail
{
    public class GetCourseDetailQuery : IQuery<CourseListQr>
    {
        public int CourseId{ get; set; }

    }
}
