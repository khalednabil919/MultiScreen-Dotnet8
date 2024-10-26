using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.DataTransferObject.Helpers;

namespace MultiScreen_Dotnet8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("GetAllTeacherByGradeId/{id}")]
        public async Task<IActionResult> GetAllTeacherByGradeId(int id)
        {
            var response = await _teacherService.getAllTeachers(id);
            return response.Error is null ? Ok(response) : BadRequest(response);
        }
    }
}
