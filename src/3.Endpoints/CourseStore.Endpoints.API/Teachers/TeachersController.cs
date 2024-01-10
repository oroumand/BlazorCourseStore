using CourseStore.Core.RequestResponse.Teachers.Command.CreateTeachers;
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


    #endregion

    #region Queries

    

    #endregion
}