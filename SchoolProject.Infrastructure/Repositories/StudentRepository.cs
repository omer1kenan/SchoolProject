using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Model;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.InfrastructureBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Repositories
{
    public class StudentRepository : GenericRepositoryAsync<Student>,IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _students;

        #endregion
        #region Constructors
        public StudentRepository(AppliactionDBContext dbContext):base(dbContext)
        {
            _students = dbContext.Set<Student>();
        }
        #endregion
        #region

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _students.Include(x=>x.Department).ToListAsync();
        }
        #endregion
    }
}
