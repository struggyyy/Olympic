using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class CompetitorEventDto
    {
        public int EventId { get; set; }

        public int CompetitorId { get; set; }

        public int MedalId { get; set; }
    }
}
