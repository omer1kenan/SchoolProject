using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Model;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Service.Abstractrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implementaions
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _sudentRepository;

        public StudentService(IStudentRepository sudentRepository) {
            _sudentRepository = sudentRepository;
        }
        public async Task<List<Student>> GetAllStudentsListAsync()
        {
           return await _sudentRepository.GetAllStudentsAsync(); ;
        }


        public async Task<Student> GetStudentByIDAsync(int id)
        {
            var student =  _sudentRepository.GetTableNoTracking()
                .Include(x=>x.Department)
                .Where(x=>x.StudentID.Equals(id))
                .FirstOrDefault();
            return student;
        }
    }
}
