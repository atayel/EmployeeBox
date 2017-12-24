using EmployeeBox.Common.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace EmployeeBox.Common.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        public DataTable ConvertIEnumerableToDataTable<TSource>(IEnumerable<TSource> model)
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

        public void Dispose()
        {
            Dispose();
        }
    }
}