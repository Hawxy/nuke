using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;

namespace Nuke.Common.Tools.Pulumi
{
    public partial class PulumiTasks
    {
        public static void EnsureInstalled()
        {
            try
            {
                ToolPathResolver.GetPathExecutable("pulumi");
            }
            catch (Exception)
            {
                if (EnvironmentInfo.IsWin)
                {
                    var psScript = @"-NoProfile -InputFormat None -ExecutionPolicy Bypass -Command ""[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12; iex ((New-Object System.Net.WebClient).DownloadString('https://get.pulumi.com/install.ps1'))""";
                    ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("powershell"), psScript).AssertZeroExitCode();
                }
                else
                    ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("bash"), "curl -fsSL https://get.pulumi.com | sh").AssertZeroExitCode();
            }
        }

        public static IReadOnlyDictionary<string, object> GetStackOutput(PulumiStackOutputSettings toolSettings = null)
        {
            toolSettings ??= new PulumiStackOutputSettings();
            return ParseJson<IReadOnlyDictionary<string, object>>(toolSettings.EnableJson().DisableLogOutput());
        }

        public static IReadOnlyDictionary<string, PulumiConfig> GetConfigOutput(PulumiConfigSettings toolSettings = null)
        {
            toolSettings ??= new PulumiConfigSettings();
            return ParseJson<IReadOnlyDictionary<string, PulumiConfig>>(toolSettings.EnableJson().DisableLogOutput());
        }

        private static T ParseJson<T>(ToolSettings toolSettings)
        {
            var process = ProcessTasks.StartProcess(toolSettings);
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
    
    
   public class PulumiConfig
   {
       [CanBeNull] 
       public string Value { get; set; }
       public bool Secret { get; set; }
   }
}
