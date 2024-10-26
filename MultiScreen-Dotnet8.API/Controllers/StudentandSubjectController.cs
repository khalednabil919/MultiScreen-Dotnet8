using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.DataTransferObject.DTOs;

namespace MultiScreen_Dotnet8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentandSubjectController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentandSubjectController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("AddStudnetAndSubject")]
        public async Task<IActionResult> Add(AddStudentWithSubjectsRequestDTO reqeust)
        {
            var response = await _studentService.AddStudent(reqeust);
            return response.Error is null ? Ok(response) : BadRequest(response);
        }
    }
}
