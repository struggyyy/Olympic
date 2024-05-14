﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class GamesCompetitorDto
    {
        public int Id { get; set; }

        public int GamesId { get; set; }

        public int PersonId { get; set; }

        public int Age { get; set; }
    }
}
