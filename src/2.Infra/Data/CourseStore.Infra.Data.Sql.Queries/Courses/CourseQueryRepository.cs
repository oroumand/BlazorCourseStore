using CourseStore.Core.Contracts.Courses.Queries;
using CourseStore.Core.Contracts.Teachers.Queries;
using CourseStore.Core.RequestResponse.Courses.Queries.GetPagedFilter;
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
    public class CourseQueryRepository(CourseStoreQueryDbContext dbContext) : BaseQueryRepository<CourseStoreQueryDbContext>(dbContext), ICourseQueryRepository
    {
        public async Task<PagedData<CourseListQr>> ExecuteAsync(GetCoursePagedFilterQuery query)
        {
            var filter = _dbContext.Courses.AsQueryable();

            if (!string.IsNullOrEmpty(query.Title))
                filter = filter.Where(teacherFilter => teacherFilter.Title.Contains(query.Title));

            if (query.PriceFrom.HasValue)
                filter = filter.Where(userFilter => userFilter.Price >= query.PriceFrom.Value);
            if (query.PriceTo.HasValue)
                filter = filter.Where(userFilter => userFilter.Price <= query.PriceTo.Value);

            return await filter.ToPagedData(query, c => new CourseListQr
            {
                Id = c.Id,
                Title = c.Title,
                Image = c.ImageUrl,
                Price = c.Price
            });
        }


    }
}
