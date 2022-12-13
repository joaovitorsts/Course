using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingSchool.Models
{
    internal class Room
    {
        public bool? IsAvailable { get; set; } = true;

        public int Number { get; set; }

        public Student? Student { get; set; }
    }
}
