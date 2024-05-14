using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class GamesDto
    {
        public int Id { get; set; }

        public int GamesYear { get; set; }

        public string GamesName { get; set; }

        public string Season { get; set; }
    }
}
