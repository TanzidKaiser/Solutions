using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiSolution.BusinessLayer
{
    public class Response
    {
        public Response()
        {
            Success = false;
            Message = "";
        }

        //public List<FeeCollectionTranDto> FeeCollectionTranDtos { get; set; }
        public long? UserId { get; set; }

        public String Complementary { get; set; }
        public bool? Success { get; set; }
        public string Message { get; set; }
    }
}