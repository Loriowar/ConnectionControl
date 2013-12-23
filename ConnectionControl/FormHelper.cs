using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// Declare custom types
using ConnectionControl.CommonTypes;

namespace ConnectionControl
{
    namespace FormHelper
    {
        public class TableMethods
        {
            public static DataTable GenerateDataSource(FullTableContent content)
            {
                var resultDataTable = new DataTable();
                var row_count = 0;
                // Go throw all table content
                foreach (var column in content)
                {
                    // Add new column name
                    resultDataTable.Columns.Add(column.Key);
                    // Adding enough rows
                    while (resultDataTable.Rows.Count < column.Value.Length)
                    {
                        resultDataTable.Rows.Add();
                    }
                    // Fill columns
                    for (int i = 0; i < column.Value.Length; i++)
                    {
                        resultDataTable.Rows[i][row_count] = (object) column.Value[i];
                    }
                    row_count++;
                }

                return resultDataTable;
            }
        }
    }
}
