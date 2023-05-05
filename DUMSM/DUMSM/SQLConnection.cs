using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM
{
    internal class SQLConnection
    {
        public static string conReturn()
        {
            //return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("BasicsoftDB.mdf") + ";Integrated Security=True;Connect Timeout=30");
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Tahsin Hasan Turab\Documents\DUMSMDataBase.mdf"";Integrated Security=True;Connect Timeout=30");
        }
    }
}
