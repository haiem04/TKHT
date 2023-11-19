using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using TKHT.PUtil;

namespace TKHT.PControl
{
    public class ControlAccount : ControlDB
    {
    
        public static bool login(string userName , string pw)
        {
            var acc =  db.Accounts.FirstOrDefault(x => x.Password == pw && x.UserName == userName);
            if (acc != null)
            {
                GlobalVar.studentInfo = acc.Student;
                Debug.WriteLine(GlobalVar.studentInfo.id);
                return true;
            }
            return false;

        }
    }
}
