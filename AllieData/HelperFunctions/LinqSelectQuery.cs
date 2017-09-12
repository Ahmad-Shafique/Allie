using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllieData.HelperFunctions
{
    public class LinqSelectQuery<T>
    {
        //Resolve later
        //////Select * from table1 where table1.someId = someId
        //////public static IEnumerable<T> SelectWhere(DbSet<T> table1, string tableOneRow, string value)
        //////{
        //////    return table1.Where(tableOneRow.tableOneColumn == Value);
        //////}
    }
}
