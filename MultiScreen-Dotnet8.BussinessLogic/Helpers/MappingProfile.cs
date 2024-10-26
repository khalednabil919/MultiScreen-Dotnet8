using AutoMapper;
using Microsoft.AspNetCore.Hosting.Server;
using MultiScreen_Dotnet8.Core.Entities;
using MultiScreen_Dotnet8.DataTransferObject.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.BussinessLogic.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentRequestDTO, Student>();
            CreateMap<SubjectRequestDTO, Subject>();
            CreateMap<Grade, GradeResponseDTO>();   
            CreateMap<Teacher, TeacherResponseDTO>();
        }

    }
}
