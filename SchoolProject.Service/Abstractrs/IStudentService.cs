﻿using SchoolProject.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Abstractrs
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudentsListAsync();
        public Task<Student> GetStudentByIDAsync(int id);
        public Task<string> AddStudentAsync(Student student);
    }
}
