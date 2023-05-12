using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM
{
    public class TotalClass
    {
        public static int TotalOfColumnWithoutCondition(string tableName, string ColumnName)
        {
            int total = 0;

            var TotalValuesList = CRUDOperation.GetColumnValues(tableName, ColumnName);
            
            foreach (var value in TotalValuesList)
            {
                total+=int.Parse(value);
            }

            return total;
        }

        public static int TotalOfColumnWithCondition(string tableName, string ColumnName, string Condition)
        {
            int total = 0;

            var TotalValuesList = CRUDOperation.GetColumnValues(tableName, ColumnName, Condition);

            foreach (var value in TotalValuesList)
            {
                total += int.Parse(value);
            }

            return total;
        }
    }
}
