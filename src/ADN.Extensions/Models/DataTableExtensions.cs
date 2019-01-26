using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="DataTable"/>.
    /// </summary>
    public static class DataTableExtensions
    {
        /// <summary>
        /// CSS classes.
        /// </summary>
        public class TableCssClasses
        {
            public string Table { get; set; } = string.Empty;
            public string Tr { get; set; } = string.Empty;
            public string Th { get; set; } = string.Empty;
            public string Td { get; set; } = string.Empty;
        }

        /// <summary>
        /// Convert a DataTable to the equivalent HTML table.
        /// </summary>
        /// <param name="dataTable">DataTable to convert.</param>
        /// <param name="tableCssClasses">Optional parameter. CSS classes.</param>
        /// <returns>HTML table.</returns>
        /// <example>
        /// <code lang="csharp">
        /// DataTable table = new DataTable(new DataTableExtensions.TableCssClasses()
        /// {
        ///     Table = "class-table",
        ///     Tr = "class-tr-1 class-tr-2",
        ///     Th = "class-th",
        ///     Td = "class-td",
        /// });
        /// // populate table
        /// var result = table.ToHtmlTable();
        /// </code>
        /// </example>
        public static string ToHtmlTable(this DataTable dataTable, TableCssClasses tableCssClasses = null)
        {
            string tableCss = string.Empty;
            string trCss = string.Empty;
            string thCss = string.Empty;
            string tdCss = string.Empty;

            if (tableCssClasses != null)
            {
                tableCss = (tableCssClasses.Table != string.Empty) ? $" class='{tableCssClasses.Table}'" : "";
                trCss = (tableCssClasses.Tr != string.Empty) ? $" class='{tableCssClasses.Tr}'" : "";
                thCss = (tableCssClasses.Th != string.Empty) ? $" class='{tableCssClasses.Th}'" : "";
                tdCss = (tableCssClasses.Td != string.Empty) ? $" class='{tableCssClasses.Td}'" : "";
            }

            int numColumns = dataTable.Columns.Count;
            string html = $"<table{tableCss}>";

            // header
            html += "<thead>";
            if (numColumns > 0)
            {
                html += $"<tr{trCss}>";
                for (int i = 0; i < numColumns; i++)
                {
                    html += $"<th{thCss}>{dataTable.Columns[i].ColumnName}</th>";
                }
                html += "</tr>";
            }
            html += "</thead>";

            // rows
            html += "<tbody>";
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                html += $"<tr{trCss}>";
                for (var j = 0; j < numColumns; j++)
                {
                    html += $"<td{tdCss}>{dataTable.Rows[i][j]}</td>";
                }

                html += "</tr>";
            }
            html += "</tbody>";
            html += "</table>";
            return html.ToString();
        }
    }
}
