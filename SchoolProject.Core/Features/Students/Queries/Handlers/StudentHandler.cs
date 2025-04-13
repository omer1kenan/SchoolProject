using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Model;
using SchoolProject.Service.Abstractrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler:IRequestHandler<GetAllStundentListQuery,List<GetStudentListRespose>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentHandler(IStudentService studentService,IMapper mapper) 
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        public async Task<List<GetStudentListRespose>> Handle(GetAllStundentListQuery request, CancellationToken cancellationToken)
        {
            var StudentList= await _studentService.GetAllStudentsListAsync();
            var StudentListMap = _mapper.Map<List<GetStudentListRespose>>(StudentList);
            return StudentListMap;
        }
    }
}
