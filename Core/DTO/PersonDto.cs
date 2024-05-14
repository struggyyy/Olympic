using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class PersonDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }
    }
}
