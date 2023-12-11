using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TKHT.DTO;
using TKHT.PUtil;
using TKHT.PView;

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
                Subject = s.Test.Subject.SubjectName,
                Name = s.Test.Name
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

        public static List<DTOAttempt> getAttemptsByStudentId(int studentId)
        {
            var result = db.Attempts.Where(a => a.StudentId == studentId).Select(s => new DTOAttempt
            {
                id = s.id,
                Date = s.Date,
                StudentId = (int)s.StudentId,
                TestId = (int)s.TestId,
            }).ToList();
            return result;
        }

        public static Attempt createAttempt(int studentId, int testid)
        {
            Attempt newAttempt = new Attempt
            {
                Date = DateTime.Now,
                StudentId = studentId,
                TestId = testid
            };

            db.Attempts.Add(newAttempt);
            db.SaveChanges();

            return newAttempt;
        }

        public static List<Attempt_Question> createAttemptQuestion(Attempt attempt, List<Question> questions, List<string> answers)
        {
            List<Attempt_Question> newAttemptQuestions = new List<Attempt_Question>{};
            for (int i = 0; i < questions.Count; i++)
            {
                Attempt_Question newAttemptQuestion = new Attempt_Question
                {
                    QuestionId = questions[i].id,
                    AttemptId = attempt.id,
                    Answer = (i < answers.Count) ? answers[i] : ""
                };
                    db.Attempt_Question.Add(newAttemptQuestion);
                newAttemptQuestions.Add(newAttemptQuestion);

            }
            db.SaveChanges();
            
            return newAttemptQuestions;
        }
    }
}
