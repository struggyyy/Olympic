using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class PersonRegionDto
    {
        public int PersonId { get; set; }

        public int RegionId { get; set; }
    }
}
