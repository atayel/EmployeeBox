using System;
using System.Collections.Generic;
using System.Data;

namespace EmployeeBox.Common.Factories
{
    interface ICommonRepository : IDisposable
    {
        DataTable ConvertIEnumerableToDataTable<TSource>(IEnumerable<TSource> model);
    }
}
