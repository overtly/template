using System;
using System.Collections.Generic;
using System.Text;

namespace Overt.GrpcTemplate.Application.Models
{
    public class PageSearchModel : IsMasterModel
    {
        public int Page { get; set; }

        public int Rows { get; set; }
    }
}
