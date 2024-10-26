using AutoMapper;
using MultiScreen_Dotnet8.Core.Interfaces;
using MultiScreen_Dotnet8.DataTransferObject.DTOs;
using MultiScreen_Dotnet8.DataTransferObject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.BussinessLogic.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitofWork;
        public TeacherService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitofWork = unitOfWork;
        }
        public async Task<ResponseVM> getAllTeachers(int id)
        {
            var response = _unitofWork.teacher.Query().Where(x=>x.GradeId ==id).ToList();
            return new ResponseVM { Data = _mapper.Map<List<TeacherResponseDTO>>(response),StatusCode = System.Net.HttpStatusCode.OK };
        }
    }
}
