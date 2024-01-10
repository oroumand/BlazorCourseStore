using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Utilities;

namespace SSO.Management.Core.ApplicationService.Users.Queries.GetPagedFilter;

public sealed class GetTeacherPagedFilterHandler : QueryHandler<GetTeacherPagedFilterQuery, PagedData<TeacherListQr>>
{
    private readonly ITeacherQueryRepository _repository;
    public GetTeacherPagedFilterHandler(ZaminServices zaminServices, ITeacherQueryRepository repository) : base(zaminServices)
    {
        _repository = repository;
    }

    public override async Task<QueryResult<PagedData<TeacherListQr>>> Handle(GetTeacherPagedFilterQuery query)
    {
        var data = await _repository.ExecuteAsync(query);

        return await ResultAsync(data);
    }
}