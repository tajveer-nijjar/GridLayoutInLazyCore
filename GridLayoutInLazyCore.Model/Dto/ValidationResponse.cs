using System;
using System.Collections.Generic;
using System.Text;

namespace GridLayoutInLazyCore.Model.Dto
{
    public class ValidationResponse
    {
        public string Message { get; set; }
        public string Next_Steps_Link { get; set; }
        public bool Token_Is_Authenticated { get; set; }
    }
}
