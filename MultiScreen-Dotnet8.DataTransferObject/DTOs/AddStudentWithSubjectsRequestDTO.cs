using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.DataTransferObject.DTOs
{
    public class AddStudentWithSubjectsRequestDTO
    {
        public StudentRequestDTO studentRequestDTO { get; set; }
        public List<SubjectRequestDTO> subjectRequestsDTO { get; set; }
    }
}
