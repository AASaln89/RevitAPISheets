using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPISheets
{
    class SheetsUtils
    {
        public static List<ViewSheet> GetSheetTypes(ExternalCommandData commandData)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;

            var views
               = new FilteredElementCollector(doc)
                   .OfClass(typeof(ViewSheet))
                   .Cast<ViewSheet>()
                   .ToList();
            return views;
        }
    }
}
