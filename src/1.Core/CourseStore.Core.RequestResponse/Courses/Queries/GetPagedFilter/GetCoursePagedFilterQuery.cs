using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.RequestResponse.Courses.Queries.GetPagedFilter
{
    public class GetCoursePagedFilterQuery : PageQuery<PagedData<CourseListQr>>
    {
        public string Title { get; set; }
        public long? PriceFrom { get; set; }
        public long? PriceTo { get; set; }
    }
}
