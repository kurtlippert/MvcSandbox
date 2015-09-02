using System.Collections.Generic;

namespace MvcSandbox.Models
{
    public class SortableMultiSelectViewModel
    {
        public List<Column> Columns { get; set; }
    }

    public class Column
    {
        public int ColumnId { get; set; }

        public string ColumnName { get; set; }

        public int SortOrder { get; set; }
    }
}