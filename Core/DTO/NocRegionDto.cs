using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class NocRegionDto
    {
        public int Id { get; set; }

        public string Noc { get; set; }

        public string RegionName { get; set; }
    }
}
