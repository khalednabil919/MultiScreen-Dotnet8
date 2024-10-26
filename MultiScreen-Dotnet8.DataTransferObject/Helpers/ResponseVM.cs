using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiScreen_Dotnet8.DataTransferObject.Helpers
{
    public class ResponseVM
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public object Data { get; set; }
        public object Error { get; set; }
    }
}
