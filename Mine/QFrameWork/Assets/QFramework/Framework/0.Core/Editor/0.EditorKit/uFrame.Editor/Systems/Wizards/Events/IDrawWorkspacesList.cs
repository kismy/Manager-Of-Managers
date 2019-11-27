﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace QFramework.GraphDesigner.Systems.GraphUI.api
{
    public interface IDrawWorkspacesList
    {
        void DrawWorkspacesList(IPlatformDrawer platform, Rect bounds, List<WorkspacesListItem> items );
    }
}
