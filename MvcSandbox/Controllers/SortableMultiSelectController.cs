using System.Collections.Generic;
using System.Web.Mvc;
using MvcSandbox.Models;

namespace MvcSandbox.Controllers
{
    public class SortableMultiSelectController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SortableMultiSelectViewModel sortableMultiSelectViewModel = new SortableMultiSelectViewModel
            {
                // Some database call that returns the list of columns already active (i.e. SortOrder > 0)
                Columns = new List<Column> { 
                    new Column {ColumnId = 111, ColumnName = "First Name", SortOrder = 2},
                    new Column {ColumnId = 222, ColumnName = "Last Name", SortOrder = 1}
                }
            };

            return View(sortableMultiSelectViewModel);
        }

        [HttpPost]
        public ActionResult Index(SortableMultiSelectViewModel sortableMultiSelectViewModel)
        {

            // Some database post 

            return View();
        }

        public JsonResult GetMultiSelectColumns()
        {
            // Some database call that returns the full list of columns
            List<Column> columns = new List<Column>
            {
                new Column {ColumnId = 111, ColumnName = "First Name", SortOrder = 2},
                new Column {ColumnId = 222, ColumnName = "Last Name", SortOrder = 1},
                new Column {ColumnId = 333, ColumnName = "Modified On"},
                new Column {ColumnId = 444, ColumnName = "Pool"},
                new Column {ColumnId = 555, ColumnName = "Last Company Interviewed"},
                new Column {ColumnId = 666, ColumnName = "Created On"}
            };

            return Json(columns, JsonRequestBehavior.AllowGet);
        }
    }
}