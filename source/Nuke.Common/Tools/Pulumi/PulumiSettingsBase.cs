using System;
using System.Collections.Generic;
using System.Text;
using Nuke.Common.Tooling;

namespace Nuke.Common.Tools.Pulumi
{
    [Serializable]
    public abstract class PulumiBaseSettings : ToolSettings
    {
        public string GetToolPath()
        {
            return PulumiTasks.GetToolPath();
        }
    }
}
