﻿using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.StudentMapping
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListRespose>().ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
