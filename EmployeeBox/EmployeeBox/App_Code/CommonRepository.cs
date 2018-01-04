using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace EmployeeBox.App_Code
{
    public class CommonRepository
    {
        internal DataTable ConvertIEnumerableToDataTable<TSource>(IEnumerable<TSource> model)
        {
            var props = typeof(TSource).GetProperties();

            var dt = new DataTable();
            dt.Columns.AddRange(
              props.Select(p => new DataColumn(p.Name, Nullable.GetUnderlyingType(
                 p.PropertyType) ?? p.PropertyType)).ToArray());

            model.ToList().ForEach(
              i => dt.Rows.Add(props.Select(p => p.GetValue(i, null)).ToArray())
            );

            return dt;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        internal string GetCurrentMethodName()
        {
            var _stack = new StackTrace(new StackFrame(1));
            return _stack.GetFrame(0).GetMethod().Name;
        }

        internal void Dispose()
        {
            Dispose();
        }
    }
}