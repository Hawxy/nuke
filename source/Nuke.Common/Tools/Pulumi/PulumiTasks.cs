using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;

namespace Nuke.Common.Tools.Pulumi
{
    public partial class PulumiTasks
    {
        public static T GetStackOutput<T>(PulumiStackOutputSettings toolSettings = null)
        {
            toolSettings ??= new PulumiStackOutputSettings();
            var process = ProcessTasks.StartProcess(toolSettings.EnableJson()); 
            process.AssertZeroExitCode();
            var output = process.Output.EnsureOnlyStd().Select(x => x.Text).ToList();
            try
            {
                return JsonConvert.DeserializeObject<T>(string.Join("\r\n", output));
            }
            catch (Exception exception)
            {
                throw new Exception(
                    new[] { $"{nameof(Pulumi)} exited with code {process.ExitCode}, but cannot parse output as JSON:" }
                        .Concat(process.Output.Select(x => x.Text)).JoinNewLine(),
                    exception);
            }
        }
    }
}
