using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Model;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        #region Fields
        private readonly AppliactionDBContext _dbContext;

        #endregion
        #region Constructors
        public StudentRepository(AppliactionDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
        #region

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _dbContext.students.Include(x=>x.Department).ToListAsync();
        }
        #endregion
    }
}
