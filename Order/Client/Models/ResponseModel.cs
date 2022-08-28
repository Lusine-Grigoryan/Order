using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Client.Models
{
    public class ResponseModel
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public ResponseModel()
        {

        }

        public ResponseModel(bool isSuccessful, string message)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }
    }
}
