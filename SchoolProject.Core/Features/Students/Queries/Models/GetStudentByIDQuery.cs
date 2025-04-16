﻿using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Results;


namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetStudentByIDQuery:IRequest<Response<GetSingelStudentResponse>>
    {
        public int Id {  get; set; }
        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }
    }
}
