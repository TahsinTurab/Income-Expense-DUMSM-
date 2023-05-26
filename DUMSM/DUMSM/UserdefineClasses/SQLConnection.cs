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
            //return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("DUMSMDataBase.mdf") + ";Integrated Security=True;Connect Timeout=30");
            return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\DUMSM\DUMSM\DUMSM\DUMSMDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            //return (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Tahsin Hasan Turab\Desktop\DUMSM\DUMSM\DUMSM\DUMSMDataBase.mdf"";Integrated Security=True;Connect Timeout=30");
        }
    }
}
