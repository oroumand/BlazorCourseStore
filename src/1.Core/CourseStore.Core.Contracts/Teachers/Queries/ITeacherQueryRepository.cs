using CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Core.RequestResponse.Queries;

namespace CourseStore.Core.Contracts.Teachers.Commands
{
    public interface ITeacherQueryRepository : IQueryRepository
    {
        public Task<PagedData<TeacherListQr>> ExecuteAsync(GetTeacherPagedFilterQuery query);

    }
}
