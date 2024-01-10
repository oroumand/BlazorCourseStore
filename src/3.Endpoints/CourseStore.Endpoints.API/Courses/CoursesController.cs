using CourseStore.Core.RequestResponse.Courses.Commands.CreateCourses;
using CourseStore.Core.RequestResponse.Courses.Commands.RenameCourses;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseDescription;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseImage;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCoursePrice;
using CourseStore.Core.RequestResponse.Courses.Queries.GetPagedFilter;
using Microsoft.AspNetCore.Mvc;
using Zamin.Core.RequestResponse.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace CourseStore.Endpoints.API.Courses;

[Route("api/[controller]")]
public class CoursesController : BaseController
{
    #region Commands

    [HttpPost("[action]")]
    public async Task<IActionResult> Create([FromBody] CreateCourseCommand command)
        => await Create<CreateCourseCommand, int>(command);

    [HttpPut("[action]")]
    public async Task<IActionResult> Rename([FromBody] RenameCourseCommand command)
        => await Edit(command);

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateDescription([FromBody] UpdateCourseDescriptionCommand command)
        => await Edit(command);


    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateImage([FromBody] UpdateCourseImageCommand command)
        => await Edit(command);

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdatePrice([FromBody] UpdateCoursePriceCommand command)
        => await Edit(command);
    #endregion

    #region Queries


    [HttpGet("[action]")]
    public async Task<IActionResult> GetPagedFilter([FromQuery] GetCoursePagedFilterQuery query) =>
        await Query<GetCoursePagedFilterQuery, PagedData<CourseListQr>>(query);

    #endregion
}