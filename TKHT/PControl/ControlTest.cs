using System.Collections.Generic;
using System.Linq;
using TKHT.DTO;
using TKHT.PUtil;

namespace TKHT.PControl
{
    public class ControlTest : ControlDB
    {
        private static Student student = GlobalVar.studentInfo;

        
        public static List<DTOTest> getTestsBySubjectId(int subjectId)
        {
            var result = db.Tests.Where(a => a.SubjectId == subjectId).Select(s => new DTOTest
            {
                id = s.id,
                Date = s.Date,
                Name = s.Name,
                Type = s.Type == 0 ? "Thi thử" : "Tổng hợp",
                Duration = s.Duration,
                MaxAttempts = s.MaxAttempts,
                Subject = s.Subject.SubjectName,
            }).ToList();
            return result;
        }
    }

}
