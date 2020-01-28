using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;

namespace Nuke.Common.Tools.Pulumi
{
    public partial class PulumiTasks
    {
        public static async Task EnsureInstalled()
        {
            try
            {
                ToolPathResolver.GetPathExecutable("pulumi");
            }
            catch (Exception)
            {
                Logger.Info("Installing Pulumi...");
                if (EnvironmentInfo.IsWin)
                {
                    var file = NukeBuild.TemporaryDirectory / "install.ps1";
                    await HttpTasks.HttpDownloadFileAsync("https://get.pulumi.com/install.ps1", file);
                    var psScript = $"-NoProfile -InputFormat None -ExecutionPolicy Bypass -Command {file}";
                    ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("powershell"), psScript).AssertZeroExitCode();
                }
                else
                    ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("bash"), "curl -fsSL https://get.pulumi.com | sh").AssertZeroExitCode();
            }

            //Fix an issue on azure pipelines where DOTNET_CLI_HOME isn't set for the dotnet runner.
            if (AzurePipelines.IsRunningAzurePipelines)
            {
                if (EnvironmentInfo.GetVariable<string>("DOTNET_CLI_HOME") is null)
                {
                    Logger.Info("DOTNET_CLI_HOME is missing, setting...");
                    EnvironmentInfo.SetVariable("DOTNET_CLI_HOME", EnvironmentInfo.GetVariable<string>("AGENT_TEMPDIRECTORY"));
                }
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
