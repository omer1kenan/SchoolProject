using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Model
{
    public class DepartmentSubject
    {
        [Key]
        public int DeptSubID {  get; set; }
        public int DID { get; set; }
        public int SubjectID { get; set; }
        [ForeignKey("DID")]
        public virtual Department Department { get; set; }
        [ForeignKey("SubjectID")]
        public  virtual Subjects Subjects { get; set; }

    }
}
