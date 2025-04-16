using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Results
{
    public class GetSingelStudentResponse
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public string? DepartmentName { get; set; }
    }
}
