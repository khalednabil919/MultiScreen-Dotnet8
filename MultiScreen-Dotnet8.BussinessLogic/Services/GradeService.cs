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
    public class GradeService : IGradeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GradeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ResponseVM> GetAllGrades()
        {
            try
            {
                var response = _unitOfWork.grade.Query().ToList();
                return new ResponseVM { Data = _mapper.Map<List<GradeResponseDTO>>(response) , StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch(Exception ex)
            {
                return new ResponseVM { Error = ex.Message, StatusCode = System.Net.HttpStatusCode.BadRequest };
            }
        }
    }
}
