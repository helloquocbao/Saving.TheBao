using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.Dto
{
    public interface IPageBaseFilterInputDto
    {
        /// <summary>
        /// Null => Get all, ignore filter
        /// True => only active item
        /// False => only de-active item
        /// </summary>
        bool? IsActive { get; set; }

        string Keyword { get; set; }
    }
}
