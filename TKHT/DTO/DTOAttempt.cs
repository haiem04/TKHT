﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKHT.DTO
{
    public class DTOAttempt
    {
        public int id { get; set; }
        public DateTime Date { get; set; }

        public int StudentId { get; set; }

        public int TestId { get; set; }
    }
}
