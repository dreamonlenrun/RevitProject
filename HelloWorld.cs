using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRevitProject
{
    [Transaction(TransactionMode.Manual)]
    public class HelloWorld : IExternalCommand
    {
        
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            TaskDialog.Show("HelloWorld","My first revit project!!!");
            return Result.Succeeded;
            //throw new NotImplementedException();
        }
    }
}
