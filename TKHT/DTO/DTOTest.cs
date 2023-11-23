using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKHT.DTO
{
    public class DTOTest
    {
        public int id { get; set; }

        public DateTime Date { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public int? Duration { get; set; }

        public int? MaxAttempts { get; set; }

        public string Subject { get; set; }
    }
}
