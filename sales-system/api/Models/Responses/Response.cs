using System;
using System.Collections.Generic;

#nullable disable

namespace sales_system.Models.Responses
{
    public class Response
    {
        public int status { get; set; }
        public string message { get; set; }
        public object data { get; set; }

        public Response()
        {
            this.status = 0;
        }
    }
}
