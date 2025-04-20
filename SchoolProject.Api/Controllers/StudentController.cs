using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Base;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Model;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("/api[controller]")]
    [ApiController]
    public class StudentController : AppController
    {

        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudentList()
        {
            var response = await Mediator.Send(new GetAllStundentListQuery());
            return NewResult(response);
        }
        [HttpGet("/Student/{id}")]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            var response = await Mediator.Send(new GetStudentByIDQuery(id));
            return NewResult(response);
        }
        [HttpPost("/Student/AddStudent")]
        public async Task<IActionResult> Create([FromBody] AddStudentCommand student)
        {
            var response = await Mediator.Send(student);
            return NewResult(response);
        }
    }
}
