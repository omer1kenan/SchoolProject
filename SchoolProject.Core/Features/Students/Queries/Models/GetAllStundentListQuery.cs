using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Bases;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetAllStundentListQuery : IRequest<Response<List<GetStudentListRespose>>>
    {

    }
}
