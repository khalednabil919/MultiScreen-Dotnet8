using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiScreen_Dotnet8.Core.Interfaces;

namespace MultiScreen_Dotnet8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;
        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }
        [HttpGet("GetAllGrades")]
        public async Task<IActionResult> GetAllGrades()
        {
            var response = await _gradeService.GetAllGrades();
            return response.Error is null ? Ok(response) : BadRequest(response);
        }
    }
}
