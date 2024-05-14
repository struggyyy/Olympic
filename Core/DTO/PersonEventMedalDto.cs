using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class PersonEventMedalDto
    {
        public string Person {  get; set; }
        public string Event { get; set; }
        public int MedalId { get; set; }
    }
}
