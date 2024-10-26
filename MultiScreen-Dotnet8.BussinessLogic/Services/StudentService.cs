using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using MultiScreen_Dotnet8.Core.Entities;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.Core.Interfaces.Repository;
using MultiScreen_Dotnet8.DataTransferObject.DTOs;
using MultiScreen_Dotnet8.DataTransferObject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.BussinessLogic.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ResponseVM> AddStudent(AddStudentWithSubjectsRequestDTO requestDTO)
        {
            try
            {
                var student = _mapper.Map<Student>(requestDTO.studentRequestDTO);

                var subjects = _mapper.Map<List<Subject>>(requestDTO.subjectRequestsDTO);
                student.Subjects = subjects;

                _unitOfWork.student.Add(student); 
                _unitOfWork.Complete();

                return new ResponseVM { StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch (Exception ex)
            {
                return new ResponseVM { Error = ex.InnerException.Message, StatusCode = System.Net.HttpStatusCode.ExpectationFailed };
            }

        }
    }
}
