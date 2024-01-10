using CourseStore.Core.RequestResponse.Courses.Queries.GetPagedFilter;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.Contracts.Courses.Queries
{
    public interface ICourseQueryRepository : IQueryRepository
    {
        public Task<PagedData<CourseListQr>> ExecuteAsync(GetCoursePagedFilterQuery query);

    }
}
