using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetAllStundentListQuery : IRequest<List<GetStudentListRespose>>
    {

    }
}
