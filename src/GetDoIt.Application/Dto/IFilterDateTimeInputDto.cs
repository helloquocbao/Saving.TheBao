using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.Dto
{
    public interface IFilterDateTimeInputDto
    {
        DateTime? FromDate { get; set; }
        DateTime? ToDate { get; set; }
    }
}
