﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
    public class MedalDto
    {
        public int Id { get; set; }

        public string MedalName { get; set; }
    }
}
