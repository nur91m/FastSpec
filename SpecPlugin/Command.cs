#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using SpecUI;
using SpecUI.Services;
using SpecUI.Views;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
#endregion

namespace SpecPlugin
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            RevitApplicationService.RevitApplication = uiapp;

            // Initialize App
            if (System.Windows.Application.Current == null)
            {
                System.Windows.Application app1 = new System.Windows.Application { ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown };
                app1.Resources.Add("Bootstrapper", new Bootstrapper());
            }

            //Run App
            GetBootStrapper().StartSpecApp();

            return Result.Succeeded;
        }

        private Bootstrapper GetBootStrapper()
        {
            return System.Windows.Application.Current.Resources["Bootstrapper"] as Bootstrapper;
        }
    }
}
