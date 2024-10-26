using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Core.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
    }
}
