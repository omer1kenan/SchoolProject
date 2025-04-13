using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("/api[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
       private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetAllStudentList()
        {
            var response = await _mediator.Send(new GetAllStundentListQuery());
            return Ok(response);
        }
    }
}
