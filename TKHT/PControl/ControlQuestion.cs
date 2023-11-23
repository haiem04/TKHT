using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using TKHT.DTO;
using TKHT.PUtil;

namespace TKHT.PControl
{
    public class ControlQuestion : ControlDB
    {

        public static List<Question> getQuestionsByTestId(int testid)
        {
            var result = db.Tests.Where(a => a.id == testid).SelectMany(s => s.Questions).ToList();
            return result;
        }
    }
}
