using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter;
using CourseStore.Infra.Data.Sql.Queries.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.RequestResponse.Queries;
using Zamin.Infra.Data.Sql.Queries;

namespace CourseStore.Infra.Data.Sql.Queries.Teachers
{
    public class TeacherQueryRepository : BaseQueryRepository<CourseStoreQueryDbContext>, ITeacherQueryRepository
    {
        public TeacherQueryRepository(CourseStoreQueryDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedData<TeacherListQr>> ExecuteAsync(GetTeacherPagedFilterQuery query)
        {
            var filter = _dbContext.Teachers.AsQueryable();

            if (!string.IsNullOrEmpty(query.FirstName))
                filter = filter.Where(teacherFilter => teacherFilter.FirstName.Contains(query.FirstName));

            if (!string.IsNullOrEmpty(query.LastName))
                filter = filter.Where(userFilter => userFilter.LastName.Contains(query.LastName));


            return await filter.ToPagedData(query, c => new TeacherListQr
            {
                Id = c.Id,
                FullName = $"{c.FirstName} {c.LastName}",
                Image = c.ImageUrl
            });
        }
    }
}
