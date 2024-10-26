using MultiScreen_Dotnet8.DataTransferObject.DTOs;
using MultiScreen_Dotnet8.DataTransferObject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.Core.Interfaces
{
    public interface IGradeService
    {
        public Task<ResponseVM> GetAllGrades();
    }
}
