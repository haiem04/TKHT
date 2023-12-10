using System.Collections.Generic;
using System.Linq;
using TKHT.DTO;

namespace TKHT.PControl
{
    public class ControlSubject : ControlDB
    {

        public static List<DTOSubject> getSubjectsByClassId(int classId)
        {
            {
                var result = db.Subjects.Where(a => a.Classes.Any(c => c.id == classId)).Select(s => new DTOSubject
                {
                    id = s.id,
                    SubjectName = s.SubjectName
                }).ToList();
                return result;
            }
        }
    }
}
