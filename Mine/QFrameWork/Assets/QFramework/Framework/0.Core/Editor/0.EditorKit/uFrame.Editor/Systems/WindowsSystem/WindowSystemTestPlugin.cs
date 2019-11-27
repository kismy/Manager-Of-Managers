﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QFramework.GraphDesigner.Unity.WindowsPlugin;
using QFramework;
using UnityEditor;

namespace QFramework.GraphDesigner.Unity.WindowsSystem
{
    
    public class WindowSystemTestPlugin : DiagramPlugin, IContextMenuQuery
    {
        public override void Initialize(QFrameworkContainer container)
        {
            base.Initialize(container);
            container.RegisterDrawer<HelloWorldWindowViewModel,HelloWorldWindowDrawer>();
        }


        public void QueryContextMenu(ICommandUI ui, object obj)
        {
//            var diagramNode = obj as DiagramNodeViewModel;
//            if (diagramNode != null)
//            {
//                ui.AddCommand(new OpenWinCommand());
//            }
        }

        public void QueryContextMenu(ContextMenuUI ui, MouseEvent evt, params object[] obj)
        {
          //  throw new NotImplementedException();
        }
    }
}
