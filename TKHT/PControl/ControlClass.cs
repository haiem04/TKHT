using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKHT.PControl
{
    public class ControlClass : ControlDB
    {
        public static List<Class> FindAll() {
            return db.Classes.ToList();
        }
    }
}
