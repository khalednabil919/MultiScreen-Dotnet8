using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiScreen_Dotnet8.Core.Entities;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.DataTransferObject.DTOs;
using MultiScreen_Dotnet8.Infrastructure.DBContexts;
using MultiScreen_Dotnet8.Infrastructure.Specification;
using MultiScreen_Dotnet8.Infrastructure.Specification.SpecificationsClasses;

namespace MultiScreen_Dotnet8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentandSubjectController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly MultiScreenDBContext _multiScreenDBContext;
        public StudentandSubjectController(IStudentService studentService, MultiScreenDBContext multiScreenDBContext)
        {
            _studentService = studentService;
            _multiScreenDBContext = multiScreenDBContext;
        }

        [HttpPost("AddStudnetAndSubject")]
        public async Task<IActionResult> Add(AddStudentWithSubjectsRequestDTO reqeust)
        {
            var response = await _studentService.AddStudent(reqeust);
            return response.Error is null ? Ok(response) : BadRequest(response);
        }

        [HttpGet("GetStudentById/{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var result = SpecificationEvaluator<Student>.
                getQuery<Student>(_multiScreenDBContext.Students, new GetStudentByIdSpecification(x => x.Id == id))
                                    .FirstOrDefault();
            return Ok(result);
        }

    }
}
