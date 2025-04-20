using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Model;
using SchoolProject.Data.Model;
using SchoolProject.Service.Abstractrs;

namespace SchoolProject.Core.Features.Students.Commands.Handler
{
    public class StudentCommandHadler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentCommandHadler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var studentMap = _mapper.Map<Student>(request);
            var result = await _studentService.AddStudentAsync(studentMap);
            if (result == "Exist") return UnprocessableEntity<string>("Name is exist");
            else if (result == "Success") return Created("Student added successfully");
            else return BadRequest<string>();
        }
    }
}