using CourseStore.Core.RequestResponse.Teachers.Commands.CreateTeachers;
using CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateDescription;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage;
using CourseStore.Core.RequestResponse.Teachers.Queries.GetPagedFilter;
using Microsoft.AspNetCore.Mvc;
using Zamin.Core.RequestResponse.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace CourseStore.Endpoints.API.Teachers;

[Route("api/[controller]")]
public class TeachersController : BaseController
{
    #region Commands

    [HttpPost("[action]")]
    public async Task<IActionResult> Create([FromBody] CreateTeacherCommand command)
        => await Create<CreateTeacherCommand, int>(command);

    [HttpPut("[action]")]
    public async Task<IActionResult> Rename([FromBody] RenameTeacherCommand command)
        => await Edit(command);

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateDescription([FromBody] UpdateDescriptionCommand command)
        => await Edit(command);


    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateImage([FromBody] UpdateImageCommand command)
        => await Edit(command);
    #endregion

    #region Queries


    [HttpGet("[action]")]
    public async Task<IActionResult> GetPagedFilter([FromQuery] GetTeacherPagedFilterQuery query) =>
        await Query<GetTeacherPagedFilterQuery, PagedData<TeacherListQr>>(query);

    #endregion
}