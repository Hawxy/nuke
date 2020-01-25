// Generated from https://github.com/Hawxy/nuke/blob/master/build/specifications/Pulumi.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Pulumi
{
    /// <summary>
    ///   <p>Pulumi is controlled primarily using the command line interface (CLI). It works in conjunction with the Pulumi service to deploy changes to your cloud apps and infrastructure. It keeps a history of who updated what in your team and when. This CLI has been designed for great inner loop productivity, in addition to continuous integration and delivery scenarios.</p>
    ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiTasks
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public static string PulumiPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("PULUMI_EXE") ??
            ToolPathResolver.GetPathExecutable("pulumi");
        public static Action<OutputType, string> PulumiLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>Pulumi is controlled primarily using the command line interface (CLI). It works in conjunction with the Pulumi service to deploy changes to your cloud apps and infrastructure. It keeps a history of who updated what in your team and when. This CLI has been designed for great inner loop productivity, in addition to continuous integration and delivery scenarios.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> Pulumi(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(PulumiPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, PulumiLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Cancel a stacks currently running update, if any</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiCancelSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiCancelSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiCancelSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiCancelSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiCancelSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiCancelSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiCancelSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiCancelSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiCancelSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiCancel(PulumiCancelSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiCancelSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Cancel a stacks currently running update, if any</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiCancelSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiCancelSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiCancelSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiCancelSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiCancelSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiCancelSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiCancelSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiCancelSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiCancelSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiCancel(Configure<PulumiCancelSettings> configurator)
        {
            return PulumiCancel(configurator(new PulumiCancelSettings()));
        }
        /// <summary>
        ///   <p>Cancel a stacks currently running update, if any</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiCancelSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiCancelSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiCancelSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiCancelSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiCancelSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiCancelSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiCancelSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiCancelSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiCancelSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiCancelSettings Settings, IReadOnlyCollection<Output> Output)> PulumiCancel(CombinatorialConfigure<PulumiCancelSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiCancel, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Lists all configuration values for a specific stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfig(PulumiConfigSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiConfigSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Lists all configuration values for a specific stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfig(Configure<PulumiConfigSettings> configurator)
        {
            return PulumiConfig(configurator(new PulumiConfigSettings()));
        }
        /// <summary>
        ///   <p>Lists all configuration values for a specific stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiConfigSettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiConfigSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfig(CombinatorialConfigure<PulumiConfigSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiConfig, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Get a single configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigGetSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigGetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigGet(PulumiConfigGetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiConfigGetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Get a single configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigGetSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigGetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigGet(Configure<PulumiConfigGetSettings> configurator)
        {
            return PulumiConfigGet(configurator(new PulumiConfigGetSettings()));
        }
        /// <summary>
        ///   <p>Get a single configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigGetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigGetSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiConfigGetSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigGetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigGetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigGetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigGetSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigGetSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigGetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigGetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigGetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiConfigGetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigGet(CombinatorialConfigure<PulumiConfigGetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiConfigGet, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Update the local configuration based on the most recent deployment of the stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
        ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRefreshSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigRefresh(PulumiConfigRefreshSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiConfigRefreshSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Update the local configuration based on the most recent deployment of the stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
        ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRefreshSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigRefresh(Configure<PulumiConfigRefreshSettings> configurator)
        {
            return PulumiConfigRefresh(configurator(new PulumiConfigRefreshSettings()));
        }
        /// <summary>
        ///   <p>Update the local configuration based on the most recent deployment of the stack</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRefreshSettings.Emoji"/></li>
        ///     <li><c>--force</c> via <see cref="PulumiConfigRefreshSettings.Force"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRefreshSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRefreshSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRefreshSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiConfigRefreshSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigRefresh(CombinatorialConfigure<PulumiConfigRefreshSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiConfigRefresh, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Remove configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRemoveSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigRemove(PulumiConfigRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiConfigRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Remove configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRemoveSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigRemove(Configure<PulumiConfigRemoveSettings> configurator)
        {
            return PulumiConfigRemove(configurator(new PulumiConfigRemoveSettings()));
        }
        /// <summary>
        ///   <p>Remove configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigRemoveSettings.Path"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigRemoveSettings.Profiling"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigRemoveSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigRemoveSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiConfigRemoveSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigRemove(CombinatorialConfigure<PulumiConfigRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiConfigRemove, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Set configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSetSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
        ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
        ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigSet(PulumiConfigSetSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiConfigSetSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Set configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSetSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
        ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
        ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiConfigSet(Configure<PulumiConfigSetSettings> configurator)
        {
            return PulumiConfigSet(configurator(new PulumiConfigSetSettings()));
        }
        /// <summary>
        ///   <p>Set configuration value</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiConfigSetSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiConfigSetSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiConfigSetSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiConfigSetSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiConfigSetSettings.NonInteractive"/></li>
        ///     <li><c>--path</c> via <see cref="PulumiConfigSetSettings.Path"/></li>
        ///     <li><c>--plaintext</c> via <see cref="PulumiConfigSetSettings.Plaintext"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiConfigSetSettings.Profiling"/></li>
        ///     <li><c>--secret</c> via <see cref="PulumiConfigSetSettings.Secret"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiConfigSetSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiConfigSetSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiConfigSetSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiConfigSetSettings Settings, IReadOnlyCollection<Output> Output)> PulumiConfigSet(CombinatorialConfigure<PulumiConfigSetSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiConfigSet, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Show a preview of updates to a stacks resources</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPreview(PulumiPreviewSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiPreviewSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Show a preview of updates to a stacks resources</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPreview(Configure<PulumiPreviewSettings> configurator)
        {
            return PulumiPreview(configurator(new PulumiPreviewSettings()));
        }
        /// <summary>
        ///   <p>Show a preview of updates to a stacks resources</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiPreviewSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPreview(CombinatorialConfigure<PulumiPreviewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiPreview, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage stacks</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiStack(PulumiStackSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiStackSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage stacks</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiStack(Configure<PulumiStackSettings> configurator)
        {
            return PulumiStack(configurator(new PulumiStackSettings()));
        }
        /// <summary>
        ///   <p>Manage stacks</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiStackSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStack(CombinatorialConfigure<PulumiStackSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiStack, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Show a stacks output properties</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackOutputSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackOutputSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackOutputSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackOutputSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiStackOutput(PulumiStackOutputSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiStackOutputSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Show a stacks output properties</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackOutputSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackOutputSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackOutputSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackOutputSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiStackOutput(Configure<PulumiStackOutputSettings> configurator)
        {
            return PulumiStackOutput(configurator(new PulumiStackOutputSettings()));
        }
        /// <summary>
        ///   <p>Show a stacks output properties</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.Cwd"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiStackOutputSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiStackOutputSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiStackOutputSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiStackOutputSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiStackOutputSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiStackOutputSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiStackOutputSettings.Profiling"/></li>
        ///     <li><c>--show-ids</c> via <see cref="PulumiStackOutputSettings.ShowIds"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiStackOutputSettings.ShowSecrets"/></li>
        ///     <li><c>--show-urns</c> via <see cref="PulumiStackOutputSettings.ShowUrns"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiStackOutputSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiStackOutputSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiStackOutputSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiStackOutputSettings Settings, IReadOnlyCollection<Output> Output)> PulumiStackOutput(CombinatorialConfigure<PulumiStackOutputSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiStackOutput, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region PulumiCancelSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiCancelSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Skip confirmation prompts, and proceed with cancellation anyway
        /// </summary>
        public virtual bool? Yes { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("cancel")
              .Add("{value}", Stack)
              .Add("--yes", Yes)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiConfigSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiConfigSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   Show secret values when listing config instead of displaying blinded values
        /// </summary>
        public virtual bool? ShowSecrets { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Use the configuration values in the specified file rather than detecting the file name
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("config")
              .Add("--json", Json)
              .Add("--show-secrets", ShowSecrets)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiConfigGetSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiConfigGetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   The configuration value to get
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   Emit output as JSON
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to get
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Use the configuration values in the specified file rather than detecting the file name
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("config get")
              .Add("{value}", Value)
              .Add("--json", Json)
              .Add("--path {value}", Path)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiConfigRefreshSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiConfigRefreshSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Overwrite configuration file, if it exists, without creating a backup
        /// </summary>
        public virtual bool? Force { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Use the configuration values in the specified file rather than detecting the file name
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("config refresh")
              .Add("--force", Force)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiConfigRemoveSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiConfigRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   The configuration value to remove
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to remove
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Use the configuration values in the specified file rather than detecting the file name
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("config rm")
              .Add("{value}", Value)
              .Add("--path {value}", Path)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiConfigSetSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiConfigSetSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   The configuration value to set
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to set
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Save the value as plaintext (unencrypted)
        /// </summary>
        public virtual bool? Plaintext { get; internal set; }
        /// <summary>
        ///   Encrypt the value instead of storing it in plaintext
        /// </summary>
        public virtual bool? Secret { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Use the configuration values in the specified file rather than detecting the file name
        /// </summary>
        public virtual string ConfigFile { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("config rm")
              .Add("{value}", Value)
              .Add("--path {value}", Path)
              .Add("--plaintext", Plaintext)
              .Add("--secret", Secret)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiPreviewSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiPreviewSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Config to use during the preview
        /// </summary>
        public virtual IReadOnlyList<string> Config => ConfigInternal.AsReadOnly();
        internal List<string> ConfigInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("preview")
              .Add("--config {value}", Config)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiStackSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiStackSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Display each resource's provider-assigned unique ID
        /// </summary>
        public virtual bool? ShowIds { get; internal set; }
        /// <summary>
        ///   Display stack outputs which are marked as secret in plaintext
        /// </summary>
        public virtual bool? ShowSecrets { get; internal set; }
        /// <summary>
        ///   Display each resource's Pulumi-assigned globally unique URN
        /// </summary>
        public virtual bool? ShowUrns { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("stack")
              .Add("--stack {value}", Stack)
              .Add("--show-ids", ShowIds)
              .Add("--show-secrets", ShowSecrets)
              .Add("--show-urns", ShowUrns)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiStackOutputSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiStackOutputSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Show value of specific property
        /// </summary>
        public virtual string PropertyName { get; internal set; }
        /// <summary>
        ///   Emit output as JSON
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Display each resource's provider-assigned unique ID
        /// </summary>
        public virtual bool? ShowIds { get; internal set; }
        /// <summary>
        ///   Display stack outputs which are marked as secret in plaintext
        /// </summary>
        public virtual bool? ShowSecrets { get; internal set; }
        /// <summary>
        ///   Display each resource's Pulumi-assigned globally unique URN
        /// </summary>
        public virtual bool? ShowUrns { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string Cwd { get; internal set; }
        /// <summary>
        ///   Disable integrity checking of checkpoint files
        /// </summary>
        public virtual bool? DisableIntegrityChecking { get; internal set; }
        /// <summary>
        ///   Enable emojis in the output (default is true)
        /// </summary>
        public virtual bool? Emoji { get; internal set; }
        /// <summary>
        ///   Help for Pulumi
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Flow log settings to child processes (like plugins)
        /// </summary>
        public virtual bool? LogFlow { get; internal set; }
        /// <summary>
        ///   Log to stderr instead of to files
        /// </summary>
        public virtual bool? LogToStderr { get; internal set; }
        /// <summary>
        ///   Disable interactive mode for all commands
        /// </summary>
        public virtual bool? NonInteractive { get; internal set; }
        /// <summary>
        ///   Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively
        /// </summary>
        public virtual string Profiling { get; internal set; }
        /// <summary>
        ///   Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file
        /// </summary>
        public virtual string Tracing { get; internal set; }
        /// <summary>
        ///   Enable verbose logging (e.g., v=3); anything >3 is very verbose
        /// </summary>
        public virtual int? Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("stack output")
              .Add("{value}", PropertyName)
              .Add("--json", Json)
              .Add("--stack {value}", Stack)
              .Add("--show-ids", ShowIds)
              .Add("--show-secrets", ShowSecrets)
              .Add("--show-urns", ShowUrns)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", Cwd)
              .Add("--disable-integrity-checking", DisableIntegrityChecking)
              .Add("--emoji", Emoji)
              .Add("--help", Help)
              .Add("--logflow", LogFlow)
              .Add("--logtostderr", LogToStderr)
              .Add("--non-interactive", NonInteractive)
              .Add("--profiling {value}", Profiling)
              .Add("--tracing {value}", Tracing)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region PulumiCancelSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiCancelSettingsExtensions
    {
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetStack(this PulumiCancelSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetStack(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetYes(this PulumiCancelSettings toolSettings, bool? yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetYes(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableYes(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableYes(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleYes(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = !toolSettings.Yes;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetColor(this PulumiCancelSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetColor(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetCwd(this PulumiCancelSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetCwd(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetDisableIntegrityChecking(this PulumiCancelSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetDisableIntegrityChecking(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableDisableIntegrityChecking(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableDisableIntegrityChecking(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleDisableIntegrityChecking(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetEmoji(this PulumiCancelSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetEmoji(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableEmoji(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableEmoji(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleEmoji(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetHelp(this PulumiCancelSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetHelp(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableHelp(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableHelp(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleHelp(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetLogFlow(this PulumiCancelSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetLogFlow(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableLogFlow(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableLogFlow(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleLogFlow(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetLogToStderr(this PulumiCancelSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetLogToStderr(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableLogToStderr(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableLogToStderr(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleLogToStderr(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetNonInteractive(this PulumiCancelSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetNonInteractive(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiCancelSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings EnableNonInteractive(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiCancelSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings DisableNonInteractive(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiCancelSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ToggleNonInteractive(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetProfiling(this PulumiCancelSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetProfiling(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetTracing(this PulumiCancelSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetTracing(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetVerbose(this PulumiCancelSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetVerbose(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiConfigSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiConfigSettingsExtensions
    {
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Json"/></em></p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetJson(this PulumiConfigSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Json"/></em></p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetJson(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.Json"/></em></p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableJson(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.Json"/></em></p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableJson(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.Json"/></em></p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleJson(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region ShowSecrets
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetShowSecrets(this PulumiConfigSettings toolSettings, bool? showSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = showSecrets;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetShowSecrets(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableShowSecrets(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableShowSecrets(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleShowSecrets(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetStack(this PulumiConfigSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetStack(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetConfigFile(this PulumiConfigSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetConfigFile(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetColor(this PulumiConfigSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetColor(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetCwd(this PulumiConfigSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetCwd(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetDisableIntegrityChecking(this PulumiConfigSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetDisableIntegrityChecking(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableDisableIntegrityChecking(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableDisableIntegrityChecking(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleDisableIntegrityChecking(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetEmoji(this PulumiConfigSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetEmoji(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableEmoji(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableEmoji(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleEmoji(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetHelp(this PulumiConfigSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetHelp(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableHelp(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableHelp(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleHelp(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetLogFlow(this PulumiConfigSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetLogFlow(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableLogFlow(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableLogFlow(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleLogFlow(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetLogToStderr(this PulumiConfigSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetLogToStderr(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableLogToStderr(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableLogToStderr(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleLogToStderr(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetNonInteractive(this PulumiConfigSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetNonInteractive(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings EnableNonInteractive(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings DisableNonInteractive(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ToggleNonInteractive(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetProfiling(this PulumiConfigSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetProfiling(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetTracing(this PulumiConfigSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetTracing(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetVerbose(this PulumiConfigSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetVerbose(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiConfigGetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiConfigGetSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Value"/></em></p>
        ///   <p>The configuration value to get</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetValue(this PulumiConfigGetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Value"/></em></p>
        ///   <p>The configuration value to get</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetValue(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetJson(this PulumiConfigGetSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetJson(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableJson(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableJson(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleJson(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to get</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetPath(this PulumiConfigGetSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to get</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetPath(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetStack(this PulumiConfigGetSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetStack(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetConfigFile(this PulumiConfigGetSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetConfigFile(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetColor(this PulumiConfigGetSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetColor(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetCwd(this PulumiConfigGetSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetCwd(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetDisableIntegrityChecking(this PulumiConfigGetSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetDisableIntegrityChecking(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableDisableIntegrityChecking(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableDisableIntegrityChecking(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleDisableIntegrityChecking(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetEmoji(this PulumiConfigGetSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetEmoji(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableEmoji(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableEmoji(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleEmoji(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetHelp(this PulumiConfigGetSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetHelp(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableHelp(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableHelp(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleHelp(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetLogFlow(this PulumiConfigGetSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetLogFlow(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableLogFlow(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableLogFlow(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleLogFlow(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetLogToStderr(this PulumiConfigGetSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetLogToStderr(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableLogToStderr(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableLogToStderr(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleLogToStderr(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetNonInteractive(this PulumiConfigGetSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetNonInteractive(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings EnableNonInteractive(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings DisableNonInteractive(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigGetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ToggleNonInteractive(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetProfiling(this PulumiConfigGetSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetProfiling(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetTracing(this PulumiConfigGetSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetTracing(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetVerbose(this PulumiConfigGetSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetVerbose(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiConfigRefreshSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiConfigRefreshSettingsExtensions
    {
        #region Force
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
        ///   <p>Overwrite configuration file, if it exists, without creating a backup</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetForce(this PulumiConfigRefreshSettings toolSettings, bool? force)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = force;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
        ///   <p>Overwrite configuration file, if it exists, without creating a backup</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetForce(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
        ///   <p>Overwrite configuration file, if it exists, without creating a backup</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableForce(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
        ///   <p>Overwrite configuration file, if it exists, without creating a backup</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableForce(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.Force"/></em></p>
        ///   <p>Overwrite configuration file, if it exists, without creating a backup</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleForce(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Force = !toolSettings.Force;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetStack(this PulumiConfigRefreshSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetStack(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetConfigFile(this PulumiConfigRefreshSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetConfigFile(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetColor(this PulumiConfigRefreshSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetColor(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetCwd(this PulumiConfigRefreshSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetCwd(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetDisableIntegrityChecking(this PulumiConfigRefreshSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetDisableIntegrityChecking(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableDisableIntegrityChecking(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableDisableIntegrityChecking(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleDisableIntegrityChecking(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetEmoji(this PulumiConfigRefreshSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetEmoji(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableEmoji(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableEmoji(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleEmoji(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetHelp(this PulumiConfigRefreshSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetHelp(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableHelp(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableHelp(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleHelp(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetLogFlow(this PulumiConfigRefreshSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetLogFlow(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableLogFlow(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableLogFlow(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleLogFlow(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetLogToStderr(this PulumiConfigRefreshSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetLogToStderr(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableLogToStderr(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableLogToStderr(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleLogToStderr(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetNonInteractive(this PulumiConfigRefreshSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetNonInteractive(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings EnableNonInteractive(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings DisableNonInteractive(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ToggleNonInteractive(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetProfiling(this PulumiConfigRefreshSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetProfiling(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetTracing(this PulumiConfigRefreshSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetTracing(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetVerbose(this PulumiConfigRefreshSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetVerbose(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiConfigRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiConfigRemoveSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Value"/></em></p>
        ///   <p>The configuration value to remove</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetValue(this PulumiConfigRemoveSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Value"/></em></p>
        ///   <p>The configuration value to remove</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetValue(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to remove</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetPath(this PulumiConfigRemoveSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to remove</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetPath(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetStack(this PulumiConfigRemoveSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetStack(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetConfigFile(this PulumiConfigRemoveSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetConfigFile(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetColor(this PulumiConfigRemoveSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetColor(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetCwd(this PulumiConfigRemoveSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetCwd(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetDisableIntegrityChecking(this PulumiConfigRemoveSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetDisableIntegrityChecking(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableDisableIntegrityChecking(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableDisableIntegrityChecking(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleDisableIntegrityChecking(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetEmoji(this PulumiConfigRemoveSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetEmoji(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableEmoji(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableEmoji(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleEmoji(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetHelp(this PulumiConfigRemoveSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetHelp(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableHelp(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableHelp(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleHelp(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetLogFlow(this PulumiConfigRemoveSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetLogFlow(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableLogFlow(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableLogFlow(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleLogFlow(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetLogToStderr(this PulumiConfigRemoveSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetLogToStderr(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableLogToStderr(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableLogToStderr(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleLogToStderr(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetNonInteractive(this PulumiConfigRemoveSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetNonInteractive(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings EnableNonInteractive(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings DisableNonInteractive(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ToggleNonInteractive(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetProfiling(this PulumiConfigRemoveSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetProfiling(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetTracing(this PulumiConfigRemoveSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetTracing(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetVerbose(this PulumiConfigRemoveSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetVerbose(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiConfigSetSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiConfigSetSettingsExtensions
    {
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Value"/></em></p>
        ///   <p>The configuration value to set</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetValue(this PulumiConfigSetSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Value"/></em></p>
        ///   <p>The configuration value to set</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetValue(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to set</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetPath(this PulumiConfigSetSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Path"/></em></p>
        ///   <p>The key contains a path to a property in a map or list to set</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetPath(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region Plaintext
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
        ///   <p>Save the value as plaintext (unencrypted)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetPlaintext(this PulumiConfigSetSettings toolSettings, bool? plaintext)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plaintext = plaintext;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
        ///   <p>Save the value as plaintext (unencrypted)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetPlaintext(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plaintext = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
        ///   <p>Save the value as plaintext (unencrypted)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnablePlaintext(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plaintext = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
        ///   <p>Save the value as plaintext (unencrypted)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisablePlaintext(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plaintext = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Plaintext"/></em></p>
        ///   <p>Save the value as plaintext (unencrypted)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings TogglePlaintext(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Plaintext = !toolSettings.Plaintext;
            return toolSettings;
        }
        #endregion
        #region Secret
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Secret"/></em></p>
        ///   <p>Encrypt the value instead of storing it in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetSecret(this PulumiConfigSetSettings toolSettings, bool? secret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = secret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Secret"/></em></p>
        ///   <p>Encrypt the value instead of storing it in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetSecret(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Secret"/></em></p>
        ///   <p>Encrypt the value instead of storing it in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableSecret(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Secret"/></em></p>
        ///   <p>Encrypt the value instead of storing it in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableSecret(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Secret"/></em></p>
        ///   <p>Encrypt the value instead of storing it in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleSecret(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = !toolSettings.Secret;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetStack(this PulumiConfigSetSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetStack(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetConfigFile(this PulumiConfigSetSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetConfigFile(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetColor(this PulumiConfigSetSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetColor(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetCwd(this PulumiConfigSetSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetCwd(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetDisableIntegrityChecking(this PulumiConfigSetSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetDisableIntegrityChecking(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableDisableIntegrityChecking(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableDisableIntegrityChecking(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleDisableIntegrityChecking(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetEmoji(this PulumiConfigSetSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetEmoji(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableEmoji(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableEmoji(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleEmoji(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetHelp(this PulumiConfigSetSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetHelp(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableHelp(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableHelp(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleHelp(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetLogFlow(this PulumiConfigSetSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetLogFlow(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableLogFlow(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableLogFlow(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleLogFlow(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetLogToStderr(this PulumiConfigSetSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetLogToStderr(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableLogToStderr(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableLogToStderr(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleLogToStderr(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetNonInteractive(this PulumiConfigSetSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetNonInteractive(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings EnableNonInteractive(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings DisableNonInteractive(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiConfigSetSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ToggleNonInteractive(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetProfiling(this PulumiConfigSetSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetProfiling(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetTracing(this PulumiConfigSetSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetTracing(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetVerbose(this PulumiConfigSetSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetVerbose(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiPreviewSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiPreviewSettingsExtensions
    {
        #region Config
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Config"/> to a new list</em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetConfig(this PulumiPreviewSettings toolSettings, params string[] config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigInternal = config.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Config"/> to a new list</em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetConfig(this PulumiPreviewSettings toolSettings, IEnumerable<string> config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigInternal = config.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Config"/></em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddConfig(this PulumiPreviewSettings toolSettings, params string[] config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigInternal.AddRange(config);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Config"/></em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddConfig(this PulumiPreviewSettings toolSettings, IEnumerable<string> config)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigInternal.AddRange(config);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="PulumiPreviewSettings.Config"/></em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ClearConfig(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Config"/></em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveConfig(this PulumiPreviewSettings toolSettings, params string[] config)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(config);
            toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Config"/></em></p>
        ///   <p>Config to use during the preview</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveConfig(this PulumiPreviewSettings toolSettings, IEnumerable<string> config)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(config);
            toolSettings.ConfigInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetColor(this PulumiPreviewSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetColor(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetCwd(this PulumiPreviewSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetCwd(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetDisableIntegrityChecking(this PulumiPreviewSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetDisableIntegrityChecking(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableDisableIntegrityChecking(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableDisableIntegrityChecking(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleDisableIntegrityChecking(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetEmoji(this PulumiPreviewSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetEmoji(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableEmoji(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableEmoji(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleEmoji(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetHelp(this PulumiPreviewSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetHelp(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableHelp(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableHelp(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleHelp(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetLogFlow(this PulumiPreviewSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetLogFlow(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableLogFlow(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableLogFlow(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleLogFlow(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetLogToStderr(this PulumiPreviewSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetLogToStderr(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableLogToStderr(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableLogToStderr(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleLogToStderr(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetNonInteractive(this PulumiPreviewSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetNonInteractive(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableNonInteractive(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableNonInteractive(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleNonInteractive(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetProfiling(this PulumiPreviewSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetProfiling(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTracing(this PulumiPreviewSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetTracing(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetVerbose(this PulumiPreviewSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetVerbose(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiStackSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiStackSettingsExtensions
    {
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetStack(this PulumiStackSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetStack(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ShowIds
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetShowIds(this PulumiStackSettings toolSettings, bool? showIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = showIds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetShowIds(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableShowIds(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableShowIds(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleShowIds(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = !toolSettings.ShowIds;
            return toolSettings;
        }
        #endregion
        #region ShowSecrets
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetShowSecrets(this PulumiStackSettings toolSettings, bool? showSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = showSecrets;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetShowSecrets(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableShowSecrets(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableShowSecrets(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleShowSecrets(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
            return toolSettings;
        }
        #endregion
        #region ShowUrns
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetShowUrns(this PulumiStackSettings toolSettings, bool? showUrns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = showUrns;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetShowUrns(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableShowUrns(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableShowUrns(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleShowUrns(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = !toolSettings.ShowUrns;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetColor(this PulumiStackSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetColor(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetCwd(this PulumiStackSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetCwd(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetDisableIntegrityChecking(this PulumiStackSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetDisableIntegrityChecking(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableDisableIntegrityChecking(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableDisableIntegrityChecking(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleDisableIntegrityChecking(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetEmoji(this PulumiStackSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetEmoji(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableEmoji(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableEmoji(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleEmoji(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetHelp(this PulumiStackSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetHelp(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableHelp(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableHelp(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleHelp(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetLogFlow(this PulumiStackSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetLogFlow(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableLogFlow(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableLogFlow(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleLogFlow(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetLogToStderr(this PulumiStackSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetLogToStderr(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableLogToStderr(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableLogToStderr(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleLogToStderr(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetNonInteractive(this PulumiStackSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetNonInteractive(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings EnableNonInteractive(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings DisableNonInteractive(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ToggleNonInteractive(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetProfiling(this PulumiStackSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetProfiling(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetTracing(this PulumiStackSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetTracing(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetVerbose(this PulumiStackSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetVerbose(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiStackOutputSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiStackOutputSettingsExtensions
    {
        #region PropertyName
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.PropertyName"/></em></p>
        ///   <p>Show value of specific property</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetPropertyName(this PulumiStackOutputSettings toolSettings, string propertyName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PropertyName = propertyName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.PropertyName"/></em></p>
        ///   <p>Show value of specific property</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetPropertyName(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PropertyName = null;
            return toolSettings;
        }
        #endregion
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetJson(this PulumiStackOutputSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetJson(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableJson(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableJson(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.Json"/></em></p>
        ///   <p>Emit output as JSON</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleJson(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetStack(this PulumiStackOutputSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetStack(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ShowIds
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetShowIds(this PulumiStackOutputSettings toolSettings, bool? showIds)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = showIds;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetShowIds(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableShowIds(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableShowIds(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.ShowIds"/></em></p>
        ///   <p>Display each resource's provider-assigned unique ID</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleShowIds(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowIds = !toolSettings.ShowIds;
            return toolSettings;
        }
        #endregion
        #region ShowSecrets
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetShowSecrets(this PulumiStackOutputSettings toolSettings, bool? showSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = showSecrets;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetShowSecrets(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableShowSecrets(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableShowSecrets(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.ShowSecrets"/></em></p>
        ///   <p>Display stack outputs which are marked as secret in plaintext</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleShowSecrets(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
            return toolSettings;
        }
        #endregion
        #region ShowUrns
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetShowUrns(this PulumiStackOutputSettings toolSettings, bool? showUrns)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = showUrns;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetShowUrns(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableShowUrns(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableShowUrns(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.ShowUrns"/></em></p>
        ///   <p>Display each resource's Pulumi-assigned globally unique URN</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleShowUrns(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowUrns = !toolSettings.ShowUrns;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetColor(this PulumiStackOutputSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetColor(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region Cwd
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetCwd(this PulumiStackOutputSettings toolSettings, string cwd)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = cwd;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Cwd"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetCwd(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cwd = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetDisableIntegrityChecking(this PulumiStackOutputSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetDisableIntegrityChecking(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableDisableIntegrityChecking(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableDisableIntegrityChecking(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleDisableIntegrityChecking(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetEmoji(this PulumiStackOutputSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetEmoji(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableEmoji(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableEmoji(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleEmoji(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetHelp(this PulumiStackOutputSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetHelp(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableHelp(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableHelp(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleHelp(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetLogFlow(this PulumiStackOutputSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetLogFlow(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableLogFlow(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableLogFlow(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleLogFlow(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetLogToStderr(this PulumiStackOutputSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetLogToStderr(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableLogToStderr(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableLogToStderr(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleLogToStderr(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetNonInteractive(this PulumiStackOutputSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetNonInteractive(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings EnableNonInteractive(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings DisableNonInteractive(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiStackOutputSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ToggleNonInteractive(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetProfiling(this PulumiStackOutputSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetProfiling(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetTracing(this PulumiStackOutputSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetTracing(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetVerbose(this PulumiStackOutputSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetVerbose(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ColorizeOutput
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ColorizeOutput>))]
    public partial class ColorizeOutput : Enumeration
    {
        public static ColorizeOutput Always = (ColorizeOutput) "Always";
        public static ColorizeOutput Never = (ColorizeOutput) "Never";
        public static ColorizeOutput Raw = (ColorizeOutput) "Raw";
        public static ColorizeOutput Auto = (ColorizeOutput) "Auto";
        public static explicit operator ColorizeOutput(string value)
        {
            return new ColorizeOutput { Value = value };
        }
    }
    #endregion
}
