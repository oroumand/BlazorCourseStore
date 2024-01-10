using CourseStore.Core.RequestResponse.Teachers.Command.CreateTeachers;
using CourseStore.Core.RequestResponse.Teachers.Command.RenameTeachers;
using CourseStore.Core.RequestResponse.Teachers.Command.UpdateDescription;
using CourseStore.Core.RequestResponse.Teachers.Command.UpdateImageUrl;
using Microsoft.AspNetCore.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace SSO.Management.Endpoints.API.Applications;

[Route("api/[controller]")]
public class TeachersController : BaseController
{
    #region Commands

    [HttpPost("[action]")]
    public async Task<IActionResult> Create([FromBody] CreateTeacherCommand command)
        => await Create<CreateTeacherCommand,int>(command);

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



    #endregion
}