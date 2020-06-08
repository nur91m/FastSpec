using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Services
{
    public class RevitApplicationService
    {
        public static UIApplication RevitApplication
        {
            get; set;
        }

        public static Document ActiveDocument
        {
            get
            {
                return RevitApplication.ActiveUIDocument.Document;
            }
        }

    }
}
