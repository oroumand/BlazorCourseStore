using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter
{
    public class GetTeacherPagedFilterQuery:PageQuery<PagedData<TeacherListQr>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
