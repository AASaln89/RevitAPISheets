﻿using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPISheets
{
    public class MVVM
    {
        public ExternalCommandData _commandData;
        public DelegateCommand saveCommand { get; }

        public List<ViewSheet> titleBlockTypes { get; } = new List<ViewSheet>();

        public MVVM(ExternalCommandData commandData)
        {
            _commandData = commandData;
            saveCommand = new DelegateCommand(SaveCommand);
            titleBlockTypes = SheetsUtils.GetSheetTypes(commandData);
        }

        private void SaveCommand()
        {
            UIApplication uiapp = _commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Document doc = uidoc.Document;
            return;
        }
        public event EventHandler CloseRequest;
        private void RaiseCloseRequest()
        {
            CloseRequest?.Invoke(this, EventArgs.Empty);
        }
    }
}
