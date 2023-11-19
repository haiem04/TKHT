using System.Collections.Generic;
using System.Linq;
using TKHT.DTO;
using TKHT.PUtil;

namespace TKHT.PControl
{
    public class ControlAttempt : ControlDB
    {
        private static Student student = GlobalVar.studentInfo;
        public static List<DTOCustomzieTest> getTestByStudentAttemp()
        {

            var tests = db.Attempts.Where(x => x.StudentId == student.id).Select(s => new DTOCustomzieTest
            {
                id = s.Test.id,
                AttemptId = s.id,
                Date = s.Test.Date,
                Type = s.Test.Type.ToString(),
                Subject = s.Test.Subject.SubjectName
            }).ToList();
            return tests;
        }
        public static List<DTOCustomizeAttemptQuestion> getResultOfTest(int attemptId)
        {
            var result = db.Attempt_Question.Where(a => a.AttemptId == attemptId).Select(s => new DTOCustomizeAttemptQuestion
            {
                AttemptId = s.AttemptId,
                Question = s.Question.QuestionText,
                QuestionId = s.QuestionId,
                Answer = s.Answer,
                CorrectAnswer = s.Question.CorrectAnswer,
                ChapterName = s.Question.Chapter.ChapterName
            }).ToList();
            return result;
        }
    }

}
