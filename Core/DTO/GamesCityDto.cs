using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class GamesCityDto
    {
        public int GamesId { get; set; }

        public int CityId { get; set; }
    }
}
