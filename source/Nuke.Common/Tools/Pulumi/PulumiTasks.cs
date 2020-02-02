using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Utilities;

namespace Nuke.Common.Tools.Pulumi
{
    public partial class PulumiTasks
    {
        internal static string GetToolPath()
        {
            //After installation, the set path may not be available until the next job/task
            try
            {
                return ToolPathResolver.GetPathExecutable("pulumi");
            }
            catch
            {
                return EnvironmentInfo.IsWin
                    ? Path.Combine(EnvironmentInfo.GetVariable<string>("USERPROFILE") ?? throw new InvalidOperationException(), ".pulumi", "bin", "pulumi.exe")
                    : Path.Combine(EnvironmentInfo.GetVariable<string>("HOME") ?? throw new InvalidOperationException(), ".pulumi", "bin", "pulumi");
            }
        }
        public static void InstallIfMissing()
        {
            try
            {
                ToolPathResolver.GetPathExecutable("pulumi");
            }
            catch (Exception)
            {
                Logger.Info("Installing Pulumi...");
                if (EnvironmentInfo.IsWin)
                    InstallWin();
                else
                    InstallUnix();
            }
        }

        private static void InstallWin()
        {
            var file = NukeBuild.TemporaryDirectory / "install.ps1";
            HttpTasks.HttpDownloadFile("https://get.pulumi.com/install.ps1", file);
            var psScript = $"-NoProfile -InputFormat None -ExecutionPolicy Bypass -Command {file}";
            ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("powershell"), psScript).AssertZeroExitCode();
        }

        private static void InstallUnix()
        {
            var file = NukeBuild.TemporaryDirectory / "install.sh";
            HttpTasks.HttpDownloadFile("https://get.pulumi.com/install.sh", file);
            ProcessTasks.StartProcess(ToolPathResolver.GetPathExecutable("bash"), $"{file} | export PATH=$PATH:$HOME/.pulumi/bin").AssertZeroExitCode();
        }

        public static IReadOnlyDictionary<string, object> GetStackOutput(Configure<PulumiStackOutputSettings> configurator)
        {
            return GetStackOutput(configurator(new PulumiStackOutputSettings()));
        }

        public static IReadOnlyDictionary<string, object> GetStackOutput(PulumiStackOutputSettings toolSettings = null)
        {
            toolSettings ??= new PulumiStackOutputSettings();
            return ParseJson<IReadOnlyDictionary<string, object>>(toolSettings.EnableJson().DisableLogOutput());
        }

        public static IReadOnlyDictionary<string, PulumiConfig> GetConfigOutput(Configure<PulumiConfigSettings> configurator)
        {
            return GetConfigOutput(configurator(new PulumiConfigSettings()));
        }
        public static IReadOnlyDictionary<string, PulumiConfig> GetConfigOutput(PulumiConfigSettings toolSettings = null)
        {
            toolSettings ??= new PulumiConfigSettings();
            return ParseJson<IReadOnlyDictionary<string, PulumiConfig>>(toolSettings.EnableJson().DisableLogOutput());
        }

        private static T ParseJson<T>(ToolSettings toolSettings)
        {
            var process = ProcessTasks.StartProcess(toolSettings).AssertZeroExitCode();
            var output = process.Output.EnsureOnlyStd().Select(x => x.Text).ToList();
            try
            {
                return JsonConvert.DeserializeObject<T>(output.JoinNewLine());
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
