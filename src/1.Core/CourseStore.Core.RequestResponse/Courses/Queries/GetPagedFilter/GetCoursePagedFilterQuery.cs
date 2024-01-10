using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter
{
    public class GetCoursePagedFilterQuery : PageQuery<PagedData<TeacherListQr>>
    {
        public string Title { get; set; }
        public long? PriceFrom { get; set; }
        public long? PriceTo { get; set; }
    }
}
