using Microsoft.EntityFrameworkCore;
using SchoolProject;
using SchoolProject.Data.Model;

namespace SchoolProject.Infrastructure.Data
{
    public class AppliactionDBContext:DbContext
    {
        public AppliactionDBContext() { }
        public AppliactionDBContext(DbContextOptions<AppliactionDBContext> options) : base(options) { }
        public DbSet<Department> departmets { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<DepartmentSubject> departmentSubjects { get; set; }
        public DbSet<StudentSubject> studentSubjects { get; set; }
    }
}
