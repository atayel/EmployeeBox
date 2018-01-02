using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

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

        internal void Dispose()
        {
            Dispose();
        }
    }
}