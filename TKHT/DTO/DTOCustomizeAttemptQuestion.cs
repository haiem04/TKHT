using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKHT.DTO
{
    public class DTOCustomizeAttemptQuestion
    {
        public int AttemptId { get; set; }
        public string Question { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public string CorrectAnswer { get; set; }
        public string ChapterName { get; set; }
    }
}
