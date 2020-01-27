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
        ///   <p>Cancel a stacks currently running update, if any.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.WorkingDirectory"/></li>
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
        ///   <p>Cancel a stacks currently running update, if any.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.WorkingDirectory"/></li>
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
        ///   <p>Cancel a stacks currently running update, if any.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;stack&gt;</c> via <see cref="PulumiCancelSettings.Stack"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiCancelSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiCancelSettings.WorkingDirectory"/></li>
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
        ///   <p>Lists all configuration values for a specific stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.WorkingDirectory"/></li>
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
        ///   <p>Lists all configuration values for a specific stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.WorkingDirectory"/></li>
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
        ///   <p>Lists all configuration values for a specific stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSettings.WorkingDirectory"/></li>
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
        ///   <p>Get a single configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.WorkingDirectory"/></li>
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
        ///   <p>Get a single configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.WorkingDirectory"/></li>
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
        ///   <p>Get a single configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigGetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigGetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigGetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigGetSettings.WorkingDirectory"/></li>
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
        ///   <p>Update the local configuration based on the most recent deployment of the stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.WorkingDirectory"/></li>
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
        ///   <p>Update the local configuration based on the most recent deployment of the stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.WorkingDirectory"/></li>
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
        ///   <p>Update the local configuration based on the most recent deployment of the stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRefreshSettings.WorkingDirectory"/></li>
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
        ///   <p>Remove configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.WorkingDirectory"/></li>
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
        ///   <p>Remove configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.WorkingDirectory"/></li>
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
        ///   <p>Remove configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigRemoveSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigRemoveSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigRemoveSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigRemoveSettings.WorkingDirectory"/></li>
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
        ///   <p>Set configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.WorkingDirectory"/></li>
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
        ///   <p>Set configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.WorkingDirectory"/></li>
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
        ///   <p>Set configuration value.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;value&gt;</c> via <see cref="PulumiConfigSetSettings.Value"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiConfigSetSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiConfigSetSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiConfigSetSettings.WorkingDirectory"/></li>
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
        ///   <p>Destroy an existing stack and its resources. Warning: this command is generally irreversible and should be used with great care.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiDestroySettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
        ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiDestroy(PulumiDestroySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiDestroySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Destroy an existing stack and its resources. Warning: this command is generally irreversible and should be used with great care.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiDestroySettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
        ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiDestroy(Configure<PulumiDestroySettings> configurator)
        {
            return PulumiDestroy(configurator(new PulumiDestroySettings()));
        }
        /// <summary>
        ///   <p>Destroy an existing stack and its resources. Warning: this command is generally irreversible and should be used with great care.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiDestroySettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiDestroySettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiDestroySettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiDestroySettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiDestroySettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiDestroySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiDestroySettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiDestroySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiDestroySettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiDestroySettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiDestroySettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiDestroySettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiDestroySettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiDestroySettings.Refresh"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiDestroySettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiDestroySettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiDestroySettings.ShowSames"/></li>
        ///     <li><c>--skip-preview</c> via <see cref="PulumiDestroySettings.SkipPreview"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiDestroySettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiDestroySettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiDestroySettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiDestroySettings.TargetDependents"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiDestroySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiDestroySettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiDestroySettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiDestroySettings Settings, IReadOnlyCollection<Output> Output)> PulumiDestroy(CombinatorialConfigure<PulumiDestroySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiDestroy, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Update history for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiHistorySettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiHistorySettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiHistorySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiHistorySettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiHistorySettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiHistorySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiHistorySettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiHistorySettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiHistorySettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiHistorySettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiHistorySettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiHistorySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiHistorySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiHistory(PulumiHistorySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiHistorySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Update history for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiHistorySettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiHistorySettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiHistorySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiHistorySettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiHistorySettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiHistorySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiHistorySettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiHistorySettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiHistorySettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiHistorySettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiHistorySettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiHistorySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiHistorySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiHistory(Configure<PulumiHistorySettings> configurator)
        {
            return PulumiHistory(configurator(new PulumiHistorySettings()));
        }
        /// <summary>
        ///   <p>Update history for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiHistorySettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiHistorySettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiHistorySettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiHistorySettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiHistorySettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiHistorySettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiHistorySettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiHistorySettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiHistorySettings.Profiling"/></li>
        ///     <li><c>--show-secrets</c> via <see cref="PulumiHistorySettings.ShowSecrets"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiHistorySettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiHistorySettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiHistorySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiHistorySettings Settings, IReadOnlyCollection<Output> Output)> PulumiHistory(CombinatorialConfigure<PulumiHistorySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiHistory, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Log onto the Pulumi stack. For CI/CD scenarios, an env variable of <c>PULUMI_ACCESS_TOKEN</c> should be set.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLoginSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLoginSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLoginSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLoginSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLoginSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLoginSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLoginSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLoginSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLoginSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLoginSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLoginSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLoginSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLoginSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogin(PulumiLoginSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiLoginSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Log onto the Pulumi stack. For CI/CD scenarios, an env variable of <c>PULUMI_ACCESS_TOKEN</c> should be set.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLoginSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLoginSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLoginSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLoginSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLoginSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLoginSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLoginSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLoginSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLoginSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLoginSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLoginSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLoginSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLoginSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogin(Configure<PulumiLoginSettings> configurator)
        {
            return PulumiLogin(configurator(new PulumiLoginSettings()));
        }
        /// <summary>
        ///   <p>Log onto the Pulumi stack. For CI/CD scenarios, an env variable of <c>PULUMI_ACCESS_TOKEN</c> should be set.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLoginSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLoginSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLoginSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLoginSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLoginSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLoginSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLoginSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLoginSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLoginSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLoginSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLoginSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLoginSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLoginSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiLoginSettings Settings, IReadOnlyCollection<Output> Output)> PulumiLogin(CombinatorialConfigure<PulumiLoginSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiLogin, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Log out of the Pulumi service.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLogoutSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLogoutSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLogoutSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogoutSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogoutSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogoutSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLogoutSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogoutSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogoutSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogoutSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogoutSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogoutSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogoutSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogout(PulumiLogoutSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiLogoutSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Log out of the Pulumi service.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLogoutSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLogoutSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLogoutSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogoutSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogoutSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogoutSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLogoutSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogoutSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogoutSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogoutSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogoutSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogoutSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogoutSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogout(Configure<PulumiLogoutSettings> configurator)
        {
            return PulumiLogout(configurator(new PulumiLogoutSettings()));
        }
        /// <summary>
        ///   <p>Log out of the Pulumi service.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;location&gt;</c> via <see cref="PulumiLogoutSettings.Location"/></li>
        ///     <li><c>--cloud-url</c> via <see cref="PulumiLogoutSettings.CloudUrl"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiLogoutSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogoutSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogoutSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogoutSettings.Help"/></li>
        ///     <li><c>--local</c> via <see cref="PulumiLogoutSettings.Local"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogoutSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogoutSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogoutSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogoutSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogoutSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogoutSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiLogoutSettings Settings, IReadOnlyCollection<Output> Output)> PulumiLogout(CombinatorialConfigure<PulumiLogoutSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiLogout, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Show aggregated logs for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiLogsSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiLogsSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogsSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogsSettings.Emoji"/></li>
        ///     <li><c>--follow</c> via <see cref="PulumiLogsSettings.Follow"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogsSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiLogsSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogsSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogsSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogsSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogsSettings.Profiling"/></li>
        ///     <li><c>--resource</c> via <see cref="PulumiLogsSettings.Resource"/></li>
        ///     <li><c>--since</c> via <see cref="PulumiLogsSettings.Since"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiLogsSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogsSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogs(PulumiLogsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiLogsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Show aggregated logs for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiLogsSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiLogsSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogsSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogsSettings.Emoji"/></li>
        ///     <li><c>--follow</c> via <see cref="PulumiLogsSettings.Follow"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogsSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiLogsSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogsSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogsSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogsSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogsSettings.Profiling"/></li>
        ///     <li><c>--resource</c> via <see cref="PulumiLogsSettings.Resource"/></li>
        ///     <li><c>--since</c> via <see cref="PulumiLogsSettings.Since"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiLogsSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogsSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiLogs(Configure<PulumiLogsSettings> configurator)
        {
            return PulumiLogs(configurator(new PulumiLogsSettings()));
        }
        /// <summary>
        ///   <p>Show aggregated logs for a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiLogsSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiLogsSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiLogsSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiLogsSettings.Emoji"/></li>
        ///     <li><c>--follow</c> via <see cref="PulumiLogsSettings.Follow"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiLogsSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiLogsSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiLogsSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiLogsSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiLogsSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiLogsSettings.Profiling"/></li>
        ///     <li><c>--resource</c> via <see cref="PulumiLogsSettings.Resource"/></li>
        ///     <li><c>--since</c> via <see cref="PulumiLogsSettings.Since"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiLogsSettings.Stack"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiLogsSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiLogsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiLogsSettings Settings, IReadOnlyCollection<Output> Output)> PulumiLogs(CombinatorialConfigure<PulumiLogsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiLogs, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Install one or more plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginInstallSettings.KindNameVersion"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginInstallSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginInstallSettings.Emoji"/></li>
        ///     <li><c>--exact</c> via <see cref="PulumiPluginInstallSettings.Exact"/></li>
        ///     <li><c>--file</c> via <see cref="PulumiPluginInstallSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginInstallSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginInstallSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginInstallSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginInstallSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginInstallSettings.Profiling"/></li>
        ///     <li><c>--reinstall</c> via <see cref="PulumiPluginInstallSettings.Reinstall"/></li>
        ///     <li><c>--server</c> via <see cref="PulumiPluginInstallSettings.Server"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginInstallSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginInstallSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginInstall(PulumiPluginInstallSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiPluginInstallSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Install one or more plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginInstallSettings.KindNameVersion"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginInstallSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginInstallSettings.Emoji"/></li>
        ///     <li><c>--exact</c> via <see cref="PulumiPluginInstallSettings.Exact"/></li>
        ///     <li><c>--file</c> via <see cref="PulumiPluginInstallSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginInstallSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginInstallSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginInstallSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginInstallSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginInstallSettings.Profiling"/></li>
        ///     <li><c>--reinstall</c> via <see cref="PulumiPluginInstallSettings.Reinstall"/></li>
        ///     <li><c>--server</c> via <see cref="PulumiPluginInstallSettings.Server"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginInstallSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginInstallSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginInstall(Configure<PulumiPluginInstallSettings> configurator)
        {
            return PulumiPluginInstall(configurator(new PulumiPluginInstallSettings()));
        }
        /// <summary>
        ///   <p>Install one or more plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginInstallSettings.KindNameVersion"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginInstallSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginInstallSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginInstallSettings.Emoji"/></li>
        ///     <li><c>--exact</c> via <see cref="PulumiPluginInstallSettings.Exact"/></li>
        ///     <li><c>--file</c> via <see cref="PulumiPluginInstallSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginInstallSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginInstallSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginInstallSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginInstallSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginInstallSettings.Profiling"/></li>
        ///     <li><c>--reinstall</c> via <see cref="PulumiPluginInstallSettings.Reinstall"/></li>
        ///     <li><c>--server</c> via <see cref="PulumiPluginInstallSettings.Server"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginInstallSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginInstallSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiPluginInstallSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPluginInstall(CombinatorialConfigure<PulumiPluginInstallSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiPluginInstall, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>List plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPluginListSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginListSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginListSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginListSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPluginListSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginListSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginListSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginListSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginListSettings.Profiling"/></li>
        ///     <li><c>--project</c> via <see cref="PulumiPluginListSettings.Project"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginListSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginList(PulumiPluginListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiPluginListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>List plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPluginListSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginListSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginListSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginListSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPluginListSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginListSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginListSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginListSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginListSettings.Profiling"/></li>
        ///     <li><c>--project</c> via <see cref="PulumiPluginListSettings.Project"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginListSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginList(Configure<PulumiPluginListSettings> configurator)
        {
            return PulumiPluginList(configurator(new PulumiPluginListSettings()));
        }
        /// <summary>
        ///   <p>List plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPluginListSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginListSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginListSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginListSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPluginListSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginListSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginListSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginListSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginListSettings.Profiling"/></li>
        ///     <li><c>--project</c> via <see cref="PulumiPluginListSettings.Project"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginListSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiPluginListSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPluginList(CombinatorialConfigure<PulumiPluginListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiPluginList, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Remove plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginRemoveSettings.KindNameVersion"/></li>
        ///     <li><c>--all</c> via <see cref="PulumiPluginRemoveSettings.All"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginRemoveSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginRemoveSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginRemoveSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginRemoveSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiPluginRemoveSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginRemove(PulumiPluginRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiPluginRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Remove plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginRemoveSettings.KindNameVersion"/></li>
        ///     <li><c>--all</c> via <see cref="PulumiPluginRemoveSettings.All"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginRemoveSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginRemoveSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginRemoveSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginRemoveSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiPluginRemoveSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPluginRemove(Configure<PulumiPluginRemoveSettings> configurator)
        {
            return PulumiPluginRemove(configurator(new PulumiPluginRemoveSettings()));
        }
        /// <summary>
        ///   <p>Remove plugins.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;kindNameVersion&gt;</c> via <see cref="PulumiPluginRemoveSettings.KindNameVersion"/></li>
        ///     <li><c>--all</c> via <see cref="PulumiPluginRemoveSettings.All"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiPluginRemoveSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPluginRemoveSettings.WorkingDirectory"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPluginRemoveSettings.Emoji"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPluginRemoveSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPluginRemoveSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPluginRemoveSettings.LogToStderr"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPluginRemoveSettings.NonInteractive"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPluginRemoveSettings.Profiling"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPluginRemoveSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPluginRemoveSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiPluginRemoveSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiPluginRemoveSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPluginRemove(CombinatorialConfigure<PulumiPluginRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiPluginRemove, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Show a preview of updates to a stack's resources.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
        ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
        ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
        ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
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
        ///   <p>Show a preview of updates to a stack's resources.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
        ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
        ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
        ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiPreview(Configure<PulumiPreviewSettings> configurator)
        {
            return PulumiPreview(configurator(new PulumiPreviewSettings()));
        }
        /// <summary>
        ///   <p>Show a preview of updates to a stack's resources.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiPreviewSettings.Color"/></li>
        ///     <li><c>--config</c> via <see cref="PulumiPreviewSettings.Config"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiPreviewSettings.ConfigFile"/></li>
        ///     <li><c>--config-path</c> via <see cref="PulumiPreviewSettings.ConfigPath"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiPreviewSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiPreviewSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiPreviewSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiPreviewSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiPreviewSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiPreviewSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiPreviewSettings.Help"/></li>
        ///     <li><c>--json</c> via <see cref="PulumiPreviewSettings.Json"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiPreviewSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiPreviewSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiPreviewSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiPreviewSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiPreviewSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiPreviewSettings.Profiling"/></li>
        ///     <li><c>--refresh</c> via <see cref="PulumiPreviewSettings.Refresh"/></li>
        ///     <li><c>--replace</c> via <see cref="PulumiPreviewSettings.Replace"/></li>
        ///     <li><c>--show-config</c> via <see cref="PulumiPreviewSettings.ShowConfig"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiPreviewSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiPreviewSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiPreviewSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiPreviewSettings.Target"/></li>
        ///     <li><c>--target-dependents</c> via <see cref="PulumiPreviewSettings.TargetDependents"/></li>
        ///     <li><c>--target-replace</c> via <see cref="PulumiPreviewSettings.TargetReplace"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiPreviewSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiPreviewSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiPreviewSettings Settings, IReadOnlyCollection<Output> Output)> PulumiPreview(CombinatorialConfigure<PulumiPreviewSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiPreview, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Refresh the resources in a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiRefreshSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiRefreshSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiRefreshSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiRefreshSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiRefreshSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiRefreshSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiRefreshSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiRefreshSettings.Profiling"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiRefreshSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiRefreshSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiRefreshSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiRefreshSettings.Target"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiRefreshSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiRefreshSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiRefresh(PulumiRefreshSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new PulumiRefreshSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Refresh the resources in a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiRefreshSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiRefreshSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiRefreshSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiRefreshSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiRefreshSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiRefreshSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiRefreshSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiRefreshSettings.Profiling"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiRefreshSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiRefreshSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiRefreshSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiRefreshSettings.Target"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiRefreshSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiRefreshSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> PulumiRefresh(Configure<PulumiRefreshSettings> configurator)
        {
            return PulumiRefresh(configurator(new PulumiRefreshSettings()));
        }
        /// <summary>
        ///   <p>Refresh the resources in a stack.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiRefreshSettings.Color"/></li>
        ///     <li><c>--config-file</c> via <see cref="PulumiRefreshSettings.ConfigFile"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiRefreshSettings.WorkingDirectory"/></li>
        ///     <li><c>--debug</c> via <see cref="PulumiRefreshSettings.Debug"/></li>
        ///     <li><c>--diff</c> via <see cref="PulumiRefreshSettings.Diff"/></li>
        ///     <li><c>--disable-integrity-checking</c> via <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></li>
        ///     <li><c>--emoji</c> via <see cref="PulumiRefreshSettings.Emoji"/></li>
        ///     <li><c>--expect-no-changes</c> via <see cref="PulumiRefreshSettings.ExpectNoChanges"/></li>
        ///     <li><c>--help</c> via <see cref="PulumiRefreshSettings.Help"/></li>
        ///     <li><c>--logflow</c> via <see cref="PulumiRefreshSettings.LogFlow"/></li>
        ///     <li><c>--logtostderr</c> via <see cref="PulumiRefreshSettings.LogToStderr"/></li>
        ///     <li><c>--message</c> via <see cref="PulumiRefreshSettings.Message"/></li>
        ///     <li><c>--non-interactive</c> via <see cref="PulumiRefreshSettings.NonInteractive"/></li>
        ///     <li><c>--parallel</c> via <see cref="PulumiRefreshSettings.Parallel"/></li>
        ///     <li><c>--profiling</c> via <see cref="PulumiRefreshSettings.Profiling"/></li>
        ///     <li><c>--show-replacement-steps</c> via <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></li>
        ///     <li><c>--show-sames</c> via <see cref="PulumiRefreshSettings.ShowSames"/></li>
        ///     <li><c>--stack</c> via <see cref="PulumiRefreshSettings.Stack"/></li>
        ///     <li><c>--suppress-outputs</c> via <see cref="PulumiRefreshSettings.SuppressOutputs"/></li>
        ///     <li><c>--target</c> via <see cref="PulumiRefreshSettings.Target"/></li>
        ///     <li><c>--tracing</c> via <see cref="PulumiRefreshSettings.Tracing"/></li>
        ///     <li><c>--verbose</c> via <see cref="PulumiRefreshSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="PulumiRefreshSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(PulumiRefreshSettings Settings, IReadOnlyCollection<Output> Output)> PulumiRefresh(CombinatorialConfigure<PulumiRefreshSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(PulumiRefresh, PulumiLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage stacks.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.WorkingDirectory"/></li>
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
        ///   <p>Manage stacks.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.WorkingDirectory"/></li>
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
        ///   <p>Manage stacks.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--color</c> via <see cref="PulumiStackSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackSettings.WorkingDirectory"/></li>
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
        ///   <p>Show a stacks output properties.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.WorkingDirectory"/></li>
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
        ///   <p>Show a stacks output properties.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.WorkingDirectory"/></li>
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
        ///   <p>Show a stacks output properties.</p>
        ///   <p>For more details, visit the <a href="https://www.pulumi.com/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;propertyName&gt;</c> via <see cref="PulumiStackOutputSettings.PropertyName"/></li>
        ///     <li><c>--color</c> via <see cref="PulumiStackOutputSettings.Color"/></li>
        ///     <li><c>--cwd</c> via <see cref="PulumiStackOutputSettings.WorkingDirectory"/></li>
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
        ///   The name of the stack to operate on. Defaults to the current stack.
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Skip confirmation prompts, and proceed with cancellation anyway.
        /// </summary>
        public virtual bool? Yes { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        /// <summary>
        ///    Emit output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   Show secret values when listing config instead of displaying blinded values.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   The configuration value to get.
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   Emit output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to get.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   Overwrite configuration file, if it exists, without creating a backup.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   The configuration value to remove.
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to remove.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   The configuration value to set.
        /// </summary>
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   The key contains a path to a property in a map or list to set.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   Save the value as plaintext (unencrypted).
        /// </summary>
        public virtual bool? Plaintext { get; internal set; }
        /// <summary>
        ///   Encrypt the value instead of storing it in plaintext.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiDestroySettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiDestroySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Print detailed debugging output during resource operations.
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        /// <summary>
        ///   Display operation as a rich diff showing the overall change.
        /// </summary>
        public virtual bool? Diff { get; internal set; }
        /// <summary>
        ///   Optional message to associate with the destroy operation.
        /// </summary>
        public virtual string Message { get; internal set; }
        /// <summary>
        ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).
        /// </summary>
        public virtual int? Parallel { get; internal set; }
        /// <summary>
        ///   Refresh the state of the stack's resources before this update.
        /// </summary>
        public virtual bool? Refresh { get; internal set; }
        /// <summary>
        ///   Show configuration keys and variables.
        /// </summary>
        public virtual bool? ShowConfig { get; internal set; }
        /// <summary>
        ///   Show detailed resource replacement creates and deletes instead of a single step.
        /// </summary>
        public virtual bool? ShowReplacementSteps { get; internal set; }
        /// <summary>
        ///   Show resources that don't need to be updated because they haven't changed, alongside those that do.
        /// </summary>
        public virtual bool? ShowSames { get; internal set; }
        /// <summary>
        ///   Do not perform a preview before performing the destroy.
        /// </summary>
        public virtual bool? SkipPreview { get; internal set; }
        /// <summary>
        ///   Suppress display of stack outputs (in case they contain sensitive values).
        /// </summary>
        public virtual bool? SuppressOutputs { get; internal set; }
        /// <summary>
        ///   Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: --target urn1 --target urn2.
        /// </summary>
        public virtual string Target { get; internal set; }
        /// <summary>
        ///   Allows destroying of dependent targets discovered but not specified in --target list.
        /// </summary>
        public virtual bool? TargetDependents { get; internal set; }
        /// <summary>
        ///   Automatically approve and perform the destroy after previewing it.
        /// </summary>
        public virtual bool? Yes { get; internal set; }
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("destroy")
              .Add("--debug", Debug)
              .Add("--diff", Diff)
              .Add("--message {value}", Message)
              .Add("--parallel {value}", Parallel)
              .Add("--refresh", Refresh)
              .Add("--show-config", ShowConfig)
              .Add("--show-replacement-steps", ShowReplacementSteps)
              .Add("--show-sames", ShowSames)
              .Add("--skip-preview", SkipPreview)
              .Add("--suppress-outputs", SuppressOutputs)
              .Add("--target {value}", Target)
              .Add("--target-dependents {value}", TargetDependents)
              .Add("--yes", Yes)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiHistorySettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiHistorySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Emit output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   Show secret values when listing config instead of displaying blinded values.
        /// </summary>
        public virtual bool? ShowSecrets { get; internal set; }
        /// <summary>
        ///   The name of the stack to operate on. Defaults to the current stack
        /// </summary>
        public virtual string Stack { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("history")
              .Add("--json", Json)
              .Add("--show-secrets", ShowSecrets)
              .Add("--stack {value}", Stack)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiLoginSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiLoginSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Specify a URL or a local/cloud path to the Pulumi instance you wish to use. Defaults to app.pulumi.com.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   A cloud URL to log into. This is the same as specifying a location.
        /// </summary>
        public virtual string CloudUrl { get; internal set; }
        /// <summary>
        ///   Use Pulumi in local-only mode.
        /// </summary>
        public virtual bool? Local { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("login")
              .Add("{value}", Location)
              .Add("--cloud-url {value}", CloudUrl)
              .Add("--local", Local)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiLogoutSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiLogoutSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Specify a URL or a local/cloud path to the Pulumi instance you wish to logout from. If no URL is provided, you will be logged out of the current backend.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///    A cloud URL to log out of (defaults to current cloud). This is the same as specifying a location.
        /// </summary>
        public virtual string CloudUrl { get; internal set; }
        /// <summary>
        ///   Log out of using local mode.
        /// </summary>
        public virtual bool? Local { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("logout")
              .Add("{value}", Location)
              .Add("--cloud-url {value}", CloudUrl)
              .Add("--local", Local)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiLogsSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiLogsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Follow the log stream in real time (like tail -f).
        /// </summary>
        public virtual bool? Follow { get; internal set; }
        /// <summary>
        ///   Emit output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   Only return logs for the requested resource ('name', 'type::name' or full URN).  Defaults to returning all logs.
        /// </summary>
        public virtual string Resource { get; internal set; }
        /// <summary>
        ///   Only return logs newer than a relative duration ('5s', '2m', '3h') or absolute timestamp.  Defaults to returning the last 1 hour of logs. (default 1h).
        /// </summary>
        public virtual string Since { get; internal set; }
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("logs")
              .Add("--follow", Follow)
              .Add("--json", Json)
              .Add("--resource {value}", Resource)
              .Add("--since {value}", Since)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiPluginInstallSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiPluginInstallSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Installation may be run either with a specific KIND, NAME, and VERSION, or by omitting these and letting Pulumi compute the set of plugins that may be required by the current project. VERSION cannot be a range: it must be a specific number.
        /// </summary>
        public virtual string KindNameVersion { get; internal set; }
        /// <summary>
        ///   Force installation of an exact version match (usually >= is accepted).
        /// </summary>
        public virtual bool? Exact { get; internal set; }
        /// <summary>
        ///   Install a plugin from a tarball file, instead of downloading it.
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   Reinstall a plugin even if it already exists.
        /// </summary>
        public virtual bool? Reinstall { get; internal set; }
        /// <summary>
        ///   A URL to download plugins from.
        /// </summary>
        public virtual string Server { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("plugin install")
              .Add("{value}", KindNameVersion)
              .Add("--exact", Exact)
              .Add("--file {value}", File)
              .Add("--reinstall", Reinstall)
              .Add("--server {value}", Server)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiPluginListSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiPluginListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Emit output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   List only the plugins used by the current project.
        /// </summary>
        public virtual bool? Project { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("plugin ls")
              .Add("--json", Json)
              .Add("--project", Project)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiPluginRemoveSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiPluginRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Specify KIND, NAME, and/or VERSION to narrow down what will be removed. If none are specified, the entire cache will be cleared. If only KIND and NAME are specified, but not VERSION, all versions of the plugin with the given KIND and NAME will be removed. VERSION may be a range.
        /// </summary>
        public virtual string KindNameVersion { get; internal set; }
        /// <summary>
        ///   Remove all plugins.
        /// </summary>
        public virtual bool? All { get; internal set; }
        /// <summary>
        ///   Skip confirmation prompts, and proceed with removal anyway.
        /// </summary>
        public virtual bool? Yes { get; internal set; }
        /// <summary>
        ///   Colorize output. Choices are: always, never, raw, auto (default is auto)
        /// </summary>
        public virtual ColorizeOutput Color { get; internal set; }
        /// <summary>
        ///   Run pulumi as if it had been started in another directory
        /// </summary>
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("plugin rm")
              .Add("{value}", KindNameVersion)
              .Add("--all", All)
              .Add("--yes", Yes)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   Config to use during the preview.
        /// </summary>
        public virtual IReadOnlyList<string> Config => ConfigInternal.AsReadOnly();
        internal List<string> ConfigInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Config keys contain a path to a property in a map or list to set.
        /// </summary>
        public virtual bool? ConfigPath { get; internal set; }
        /// <summary>
        ///   Print detailed debugging output during resource operations.
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        /// <summary>
        ///   Display operation as a rich diff showing the overall chang.e
        /// </summary>
        public virtual bool? Diff { get; internal set; }
        /// <summary>
        ///   Return an error if any changes are proposed by this preview.
        /// </summary>
        public virtual bool? ExpectNoChanges { get; internal set; }
        /// <summary>
        ///   Serialize the preview diffs, operations, and overall output as JSON.
        /// </summary>
        public virtual bool? Json { get; internal set; }
        /// <summary>
        ///   Optional message to associate with the preview operation.
        /// </summary>
        public virtual string Message { get; internal set; }
        /// <summary>
        ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).
        /// </summary>
        public virtual int? Parallel { get; internal set; }
        /// <summary>
        ///   Refresh the state of the stack's resources before this update.
        /// </summary>
        public virtual bool? Refresh { get; internal set; }
        /// <summary>
        ///   Refresh the state of the stack's resources before this update.
        /// </summary>
        public virtual IReadOnlyList<string> Replace => ReplaceInternal.AsReadOnly();
        internal List<string> ReplaceInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Show configuration keys and variables.
        /// </summary>
        public virtual bool? ShowConfig { get; internal set; }
        /// <summary>
        ///   Show detailed resource replacement creates and deletes instead of a single step.
        /// </summary>
        public virtual bool? ShowReplacementSteps { get; internal set; }
        /// <summary>
        ///   Show resources that don't need to be updated because they haven't changed, alongside those that do.
        /// </summary>
        public virtual bool? ShowSames { get; internal set; }
        /// <summary>
        ///   Suppress display of stack outputs (in case they contain sensitive values).
        /// </summary>
        public virtual bool? SuppressOutputs { get; internal set; }
        /// <summary>
        ///   Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.
        /// </summary>
        public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
        internal List<string> TargetInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Allows updating of dependent targets discovered but not specified in --target list.
        /// </summary>
        public virtual bool? TargetDependents { get; internal set; }
        /// <summary>
        ///   Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.
        /// </summary>
        public virtual IReadOnlyList<string> TargetReplace => TargetReplaceInternal.AsReadOnly();
        internal List<string> TargetReplaceInternal { get; set; } = new List<string>();
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--config {value}", Config, separator: ',')
              .Add("--config-path", ConfigPath)
              .Add("--debug", Debug)
              .Add("--diff", Diff)
              .Add("--expect-no-changes", ExpectNoChanges)
              .Add("--json", Json)
              .Add("--message {value}", Message)
              .Add("--parallel {value}", Parallel)
              .Add("--refresh", Refresh)
              .Add("--replace", Replace, separator: ',')
              .Add("--show-config", ShowConfig)
              .Add("--show-replacement-steps", ShowReplacementSteps)
              .Add("--show-sames", ShowSames)
              .Add("--suppress-outputs", SuppressOutputs)
              .Add("--target {value}", Target, separator: ',')
              .Add("--target-dependents {value}", TargetDependents)
              .Add("--target-replace {value}", TargetReplace, separator: ',')
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
    #region PulumiRefreshSettings
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class PulumiRefreshSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the Pulumi executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? PulumiTasks.PulumiPath;
        public override Action<OutputType, string> CustomLogger => PulumiTasks.PulumiLogger;
        /// <summary>
        ///   Print detailed debugging output during resource operations.
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        /// <summary>
        ///   Display operation as a rich diff showing the overall change.
        /// </summary>
        public virtual bool? Diff { get; internal set; }
        /// <summary>
        ///   Return an error if any changes occur during this update.
        /// </summary>
        public virtual bool? ExpectNoChanges { get; internal set; }
        /// <summary>
        ///   Optional message to associate with the update operation.
        /// </summary>
        public virtual string Message { get; internal set; }
        /// <summary>
        ///   Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).
        /// </summary>
        public virtual int? Parallel { get; internal set; }
        /// <summary>
        ///   Show detailed resource replacement creates and deletes instead of a single step.
        /// </summary>
        public virtual bool? ShowReplacementSteps { get; internal set; }
        /// <summary>
        ///   Show resources that don't need to be updated because they haven't changed, alongside those that do.
        /// </summary>
        public virtual bool? ShowSames { get; internal set; }
        /// <summary>
        ///   Suppress display of stack outputs (in case they contain sensitive values).
        /// </summary>
        public virtual bool? SuppressOutputs { get; internal set; }
        /// <summary>
        ///   Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.
        /// </summary>
        public virtual IReadOnlyList<string> Target => TargetInternal.AsReadOnly();
        internal List<string> TargetInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Automatically approve and perform the refresh after previewing it.
        /// </summary>
        public virtual bool? Yes { get; internal set; }
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--debug", Debug)
              .Add("--diff", Diff)
              .Add("--expect-no-changes", ExpectNoChanges)
              .Add("--message {value}", Message)
              .Add("--parallel {value}", Parallel)
              .Add("--show-replacement-steps", ShowReplacementSteps)
              .Add("--show-sames", ShowSames)
              .Add("--suppress-outputs", SuppressOutputs)
              .Add("--target {value}", Target, separator: ',')
              .Add("--yes", Yes)
              .Add("--stack {value}", Stack)
              .Add("--config-file {value}", ConfigFile)
              .Add("--color {value}", Color)
              .Add("--cwd {value}", WorkingDirectory)
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   Show value of specific property.
        /// </summary>
        public virtual string PropertyName { get; internal set; }
        /// <summary>
        ///   Emit output as JSON.
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
        public virtual string WorkingDirectory { get; internal set; }
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
              .Add("--cwd {value}", WorkingDirectory)
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
        ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
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
        ///   <p>The name of the stack to operate on. Defaults to the current stack.</p>
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
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway.</p>
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
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway.</p>
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
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway.</p>
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
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway.</p>
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
        ///   <p>Skip confirmation prompts, and proceed with cancellation anyway.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiCancelSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings SetWorkingDirectory(this PulumiCancelSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiCancelSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiCancelSettings ResetWorkingDirectory(this PulumiCancelSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p> Emit output as JSON.</p>
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
        ///   <p> Emit output as JSON.</p>
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
        ///   <p> Emit output as JSON.</p>
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
        ///   <p> Emit output as JSON.</p>
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
        ///   <p> Emit output as JSON.</p>
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
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
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
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
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
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
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
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
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
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings SetWorkingDirectory(this PulumiConfigSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSettings ResetWorkingDirectory(this PulumiConfigSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p>The configuration value to get.</p>
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
        ///   <p>The configuration value to get.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>The key contains a path to a property in a map or list to get.</p>
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
        ///   <p>The key contains a path to a property in a map or list to get.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigGetSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings SetWorkingDirectory(this PulumiConfigGetSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigGetSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigGetSettings ResetWorkingDirectory(this PulumiConfigGetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
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
        ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
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
        ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
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
        ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
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
        ///   <p>Overwrite configuration file, if it exists, without creating a backup.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRefreshSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings SetWorkingDirectory(this PulumiConfigRefreshSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRefreshSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRefreshSettings ResetWorkingDirectory(this PulumiConfigRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p>The configuration value to remove.</p>
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
        ///   <p>The configuration value to remove.</p>
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
        ///   <p>The key contains a path to a property in a map or list to remove.</p>
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
        ///   <p>The key contains a path to a property in a map or list to remove.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigRemoveSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings SetWorkingDirectory(this PulumiConfigRemoveSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigRemoveSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigRemoveSettings ResetWorkingDirectory(this PulumiConfigRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p>The configuration value to set.</p>
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
        ///   <p>The configuration value to set.</p>
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
        ///   <p>The key contains a path to a property in a map or list to set.</p>
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
        ///   <p>The key contains a path to a property in a map or list to set.</p>
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
        ///   <p>Save the value as plaintext (unencrypted).</p>
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
        ///   <p>Save the value as plaintext (unencrypted).</p>
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
        ///   <p>Save the value as plaintext (unencrypted).</p>
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
        ///   <p>Save the value as plaintext (unencrypted).</p>
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
        ///   <p>Save the value as plaintext (unencrypted).</p>
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
        ///   <p>Encrypt the value instead of storing it in plaintext.</p>
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
        ///   <p>Encrypt the value instead of storing it in plaintext.</p>
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
        ///   <p>Encrypt the value instead of storing it in plaintext.</p>
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
        ///   <p>Encrypt the value instead of storing it in plaintext.</p>
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
        ///   <p>Encrypt the value instead of storing it in plaintext.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiConfigSetSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings SetWorkingDirectory(this PulumiConfigSetSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiConfigSetSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiConfigSetSettings ResetWorkingDirectory(this PulumiConfigSetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
    #region PulumiDestroySettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiDestroySettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetDebug(this PulumiDestroySettings toolSettings, bool? debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetDebug(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableDebug(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableDebug(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleDebug(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
        #region Diff
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetDiff(this PulumiDestroySettings toolSettings, bool? diff)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = diff;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetDiff(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableDiff(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableDiff(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleDiff(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = !toolSettings.Diff;
            return toolSettings;
        }
        #endregion
        #region Message
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Message"/></em></p>
        ///   <p>Optional message to associate with the destroy operation.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetMessage(this PulumiDestroySettings toolSettings, string message)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = message;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Message"/></em></p>
        ///   <p>Optional message to associate with the destroy operation.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetMessage(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = null;
            return toolSettings;
        }
        #endregion
        #region Parallel
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetParallel(this PulumiDestroySettings toolSettings, int? parallel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = parallel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetParallel(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = null;
            return toolSettings;
        }
        #endregion
        #region Refresh
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetRefresh(this PulumiDestroySettings toolSettings, bool? refresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = refresh;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetRefresh(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableRefresh(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableRefresh(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleRefresh(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = !toolSettings.Refresh;
            return toolSettings;
        }
        #endregion
        #region ShowConfig
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetShowConfig(this PulumiDestroySettings toolSettings, bool? showConfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = showConfig;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetShowConfig(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableShowConfig(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableShowConfig(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleShowConfig(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = !toolSettings.ShowConfig;
            return toolSettings;
        }
        #endregion
        #region ShowReplacementSteps
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetShowReplacementSteps(this PulumiDestroySettings toolSettings, bool? showReplacementSteps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = showReplacementSteps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetShowReplacementSteps(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableShowReplacementSteps(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableShowReplacementSteps(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleShowReplacementSteps(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
            return toolSettings;
        }
        #endregion
        #region ShowSames
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetShowSames(this PulumiDestroySettings toolSettings, bool? showSames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = showSames;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetShowSames(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableShowSames(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableShowSames(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleShowSames(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = !toolSettings.ShowSames;
            return toolSettings;
        }
        #endregion
        #region SkipPreview
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
        ///   <p>Do not perform a preview before performing the destroy.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetSkipPreview(this PulumiDestroySettings toolSettings, bool? skipPreview)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipPreview = skipPreview;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
        ///   <p>Do not perform a preview before performing the destroy.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetSkipPreview(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipPreview = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
        ///   <p>Do not perform a preview before performing the destroy.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableSkipPreview(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipPreview = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
        ///   <p>Do not perform a preview before performing the destroy.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableSkipPreview(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipPreview = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.SkipPreview"/></em></p>
        ///   <p>Do not perform a preview before performing the destroy.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleSkipPreview(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipPreview = !toolSettings.SkipPreview;
            return toolSettings;
        }
        #endregion
        #region SuppressOutputs
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetSuppressOutputs(this PulumiDestroySettings toolSettings, bool? suppressOutputs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = suppressOutputs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetSuppressOutputs(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableSuppressOutputs(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableSuppressOutputs(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleSuppressOutputs(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetTarget(this PulumiDestroySettings toolSettings, string target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = target;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to destroy. All resources necessary to destroy this target will also be destroyed. Multiple resources can be specified using: --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetTarget(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Target = null;
            return toolSettings;
        }
        #endregion
        #region TargetDependents
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
        ///   <p>Allows destroying of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetTargetDependents(this PulumiDestroySettings toolSettings, bool? targetDependents)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = targetDependents;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
        ///   <p>Allows destroying of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetTargetDependents(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
        ///   <p>Allows destroying of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableTargetDependents(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
        ///   <p>Allows destroying of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableTargetDependents(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.TargetDependents"/></em></p>
        ///   <p>Allows destroying of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleTargetDependents(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = !toolSettings.TargetDependents;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the destroy after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetYes(this PulumiDestroySettings toolSettings, bool? yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the destroy after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetYes(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the destroy after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableYes(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the destroy after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableYes(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the destroy after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleYes(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = !toolSettings.Yes;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetStack(this PulumiDestroySettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetStack(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetConfigFile(this PulumiDestroySettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetConfigFile(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetColor(this PulumiDestroySettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetColor(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetWorkingDirectory(this PulumiDestroySettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetWorkingDirectory(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetDisableIntegrityChecking(this PulumiDestroySettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetDisableIntegrityChecking(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableDisableIntegrityChecking(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableDisableIntegrityChecking(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleDisableIntegrityChecking(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetEmoji(this PulumiDestroySettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetEmoji(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableEmoji(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableEmoji(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleEmoji(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetHelp(this PulumiDestroySettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetHelp(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableHelp(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableHelp(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleHelp(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetLogFlow(this PulumiDestroySettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetLogFlow(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableLogFlow(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableLogFlow(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleLogFlow(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetLogToStderr(this PulumiDestroySettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetLogToStderr(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableLogToStderr(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableLogToStderr(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleLogToStderr(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetNonInteractive(this PulumiDestroySettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetNonInteractive(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings EnableNonInteractive(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings DisableNonInteractive(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiDestroySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ToggleNonInteractive(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetProfiling(this PulumiDestroySettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetProfiling(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetTracing(this PulumiDestroySettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetTracing(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiDestroySettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings SetVerbose(this PulumiDestroySettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiDestroySettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiDestroySettings ResetVerbose(this PulumiDestroySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiHistorySettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiHistorySettingsExtensions
    {
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetJson(this PulumiHistorySettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetJson(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableJson(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableJson(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleJson(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region ShowSecrets
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetShowSecrets(this PulumiHistorySettings toolSettings, bool? showSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = showSecrets;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetShowSecrets(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableShowSecrets(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableShowSecrets(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.ShowSecrets"/></em></p>
        ///   <p>Show secret values when listing config instead of displaying blinded values.</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleShowSecrets(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSecrets = !toolSettings.ShowSecrets;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetStack(this PulumiHistorySettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetStack(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetColor(this PulumiHistorySettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetColor(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetWorkingDirectory(this PulumiHistorySettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetWorkingDirectory(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetDisableIntegrityChecking(this PulumiHistorySettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetDisableIntegrityChecking(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableDisableIntegrityChecking(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableDisableIntegrityChecking(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleDisableIntegrityChecking(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetEmoji(this PulumiHistorySettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetEmoji(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableEmoji(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableEmoji(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleEmoji(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetHelp(this PulumiHistorySettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetHelp(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableHelp(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableHelp(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleHelp(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetLogFlow(this PulumiHistorySettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetLogFlow(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableLogFlow(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableLogFlow(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleLogFlow(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetLogToStderr(this PulumiHistorySettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetLogToStderr(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableLogToStderr(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableLogToStderr(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleLogToStderr(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetNonInteractive(this PulumiHistorySettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetNonInteractive(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiHistorySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings EnableNonInteractive(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiHistorySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings DisableNonInteractive(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiHistorySettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ToggleNonInteractive(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetProfiling(this PulumiHistorySettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetProfiling(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetTracing(this PulumiHistorySettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetTracing(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiHistorySettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings SetVerbose(this PulumiHistorySettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiHistorySettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiHistorySettings ResetVerbose(this PulumiHistorySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiLoginSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiLoginSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Location"/></em></p>
        ///   <p>Specify a URL or a local/cloud path to the Pulumi instance you wish to use. Defaults to app.pulumi.com.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetLocation(this PulumiLoginSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Location"/></em></p>
        ///   <p>Specify a URL or a local/cloud path to the Pulumi instance you wish to use. Defaults to app.pulumi.com.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetLocation(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region CloudUrl
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.CloudUrl"/></em></p>
        ///   <p>A cloud URL to log into. This is the same as specifying a location.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetCloudUrl(this PulumiLoginSettings toolSettings, string cloudUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudUrl = cloudUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.CloudUrl"/></em></p>
        ///   <p>A cloud URL to log into. This is the same as specifying a location.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetCloudUrl(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudUrl = null;
            return toolSettings;
        }
        #endregion
        #region Local
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Local"/></em></p>
        ///   <p>Use Pulumi in local-only mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetLocal(this PulumiLoginSettings toolSettings, bool? local)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = local;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Local"/></em></p>
        ///   <p>Use Pulumi in local-only mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetLocal(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.Local"/></em></p>
        ///   <p>Use Pulumi in local-only mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableLocal(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.Local"/></em></p>
        ///   <p>Use Pulumi in local-only mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableLocal(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.Local"/></em></p>
        ///   <p>Use Pulumi in local-only mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleLocal(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = !toolSettings.Local;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetColor(this PulumiLoginSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetColor(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetWorkingDirectory(this PulumiLoginSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetWorkingDirectory(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetDisableIntegrityChecking(this PulumiLoginSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetDisableIntegrityChecking(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableDisableIntegrityChecking(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableDisableIntegrityChecking(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleDisableIntegrityChecking(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetEmoji(this PulumiLoginSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetEmoji(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableEmoji(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableEmoji(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleEmoji(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetHelp(this PulumiLoginSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetHelp(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableHelp(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableHelp(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleHelp(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetLogFlow(this PulumiLoginSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetLogFlow(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableLogFlow(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableLogFlow(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleLogFlow(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetLogToStderr(this PulumiLoginSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetLogToStderr(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableLogToStderr(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableLogToStderr(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleLogToStderr(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetNonInteractive(this PulumiLoginSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetNonInteractive(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLoginSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings EnableNonInteractive(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLoginSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings DisableNonInteractive(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLoginSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ToggleNonInteractive(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetProfiling(this PulumiLoginSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetProfiling(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetTracing(this PulumiLoginSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetTracing(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLoginSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings SetVerbose(this PulumiLoginSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLoginSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLoginSettings ResetVerbose(this PulumiLoginSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiLogoutSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiLogoutSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Location"/></em></p>
        ///   <p>Specify a URL or a local/cloud path to the Pulumi instance you wish to logout from. If no URL is provided, you will be logged out of the current backend.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetLocation(this PulumiLogoutSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Location"/></em></p>
        ///   <p>Specify a URL or a local/cloud path to the Pulumi instance you wish to logout from. If no URL is provided, you will be logged out of the current backend.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetLocation(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region CloudUrl
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.CloudUrl"/></em></p>
        ///   <p> A cloud URL to log out of (defaults to current cloud). This is the same as specifying a location.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetCloudUrl(this PulumiLogoutSettings toolSettings, string cloudUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudUrl = cloudUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.CloudUrl"/></em></p>
        ///   <p> A cloud URL to log out of (defaults to current cloud). This is the same as specifying a location.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetCloudUrl(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CloudUrl = null;
            return toolSettings;
        }
        #endregion
        #region Local
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Local"/></em></p>
        ///   <p>Log out of using local mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetLocal(this PulumiLogoutSettings toolSettings, bool? local)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = local;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Local"/></em></p>
        ///   <p>Log out of using local mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetLocal(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.Local"/></em></p>
        ///   <p>Log out of using local mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableLocal(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.Local"/></em></p>
        ///   <p>Log out of using local mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableLocal(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.Local"/></em></p>
        ///   <p>Log out of using local mode.</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleLocal(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Local = !toolSettings.Local;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetColor(this PulumiLogoutSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetColor(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetWorkingDirectory(this PulumiLogoutSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetWorkingDirectory(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetDisableIntegrityChecking(this PulumiLogoutSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetDisableIntegrityChecking(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableDisableIntegrityChecking(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableDisableIntegrityChecking(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleDisableIntegrityChecking(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetEmoji(this PulumiLogoutSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetEmoji(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableEmoji(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableEmoji(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleEmoji(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetHelp(this PulumiLogoutSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetHelp(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableHelp(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableHelp(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleHelp(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetLogFlow(this PulumiLogoutSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetLogFlow(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableLogFlow(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableLogFlow(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleLogFlow(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetLogToStderr(this PulumiLogoutSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetLogToStderr(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableLogToStderr(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableLogToStderr(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleLogToStderr(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetNonInteractive(this PulumiLogoutSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetNonInteractive(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogoutSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings EnableNonInteractive(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogoutSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings DisableNonInteractive(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogoutSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ToggleNonInteractive(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetProfiling(this PulumiLogoutSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetProfiling(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetTracing(this PulumiLogoutSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetTracing(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogoutSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings SetVerbose(this PulumiLogoutSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogoutSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLogoutSettings ResetVerbose(this PulumiLogoutSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiLogsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiLogsSettingsExtensions
    {
        #region Follow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Follow"/></em></p>
        ///   <p>Follow the log stream in real time (like tail -f).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetFollow(this PulumiLogsSettings toolSettings, bool? follow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = follow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Follow"/></em></p>
        ///   <p>Follow the log stream in real time (like tail -f).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetFollow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.Follow"/></em></p>
        ///   <p>Follow the log stream in real time (like tail -f).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableFollow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.Follow"/></em></p>
        ///   <p>Follow the log stream in real time (like tail -f).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableFollow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.Follow"/></em></p>
        ///   <p>Follow the log stream in real time (like tail -f).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleFollow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Follow = !toolSettings.Follow;
            return toolSettings;
        }
        #endregion
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetJson(this PulumiLogsSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetJson(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableJson(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableJson(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleJson(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region Resource
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Resource"/></em></p>
        ///   <p>Only return logs for the requested resource ('name', 'type::name' or full URN).  Defaults to returning all logs.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetResource(this PulumiLogsSettings toolSettings, string resource)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = resource;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Resource"/></em></p>
        ///   <p>Only return logs for the requested resource ('name', 'type::name' or full URN).  Defaults to returning all logs.</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetResource(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Resource = null;
            return toolSettings;
        }
        #endregion
        #region Since
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Since"/></em></p>
        ///   <p>Only return logs newer than a relative duration ('5s', '2m', '3h') or absolute timestamp.  Defaults to returning the last 1 hour of logs. (default 1h).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetSince(this PulumiLogsSettings toolSettings, string since)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Since = since;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Since"/></em></p>
        ///   <p>Only return logs newer than a relative duration ('5s', '2m', '3h') or absolute timestamp.  Defaults to returning the last 1 hour of logs. (default 1h).</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetSince(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Since = null;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetStack(this PulumiLogsSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetStack(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetConfigFile(this PulumiLogsSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetConfigFile(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetColor(this PulumiLogsSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetColor(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetWorkingDirectory(this PulumiLogsSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetWorkingDirectory(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetDisableIntegrityChecking(this PulumiLogsSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetDisableIntegrityChecking(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableDisableIntegrityChecking(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableDisableIntegrityChecking(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleDisableIntegrityChecking(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetEmoji(this PulumiLogsSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetEmoji(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableEmoji(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableEmoji(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleEmoji(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetHelp(this PulumiLogsSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetHelp(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableHelp(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableHelp(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleHelp(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetLogFlow(this PulumiLogsSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetLogFlow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableLogFlow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableLogFlow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleLogFlow(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetLogToStderr(this PulumiLogsSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetLogToStderr(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableLogToStderr(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableLogToStderr(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleLogToStderr(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetNonInteractive(this PulumiLogsSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetNonInteractive(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiLogsSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings EnableNonInteractive(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiLogsSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings DisableNonInteractive(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiLogsSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ToggleNonInteractive(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetProfiling(this PulumiLogsSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetProfiling(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetTracing(this PulumiLogsSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetTracing(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiLogsSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings SetVerbose(this PulumiLogsSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiLogsSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiLogsSettings ResetVerbose(this PulumiLogsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiPluginInstallSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiPluginInstallSettingsExtensions
    {
        #region KindNameVersion
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.KindNameVersion"/></em></p>
        ///   <p>Installation may be run either with a specific KIND, NAME, and VERSION, or by omitting these and letting Pulumi compute the set of plugins that may be required by the current project. VERSION cannot be a range: it must be a specific number.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetKindNameVersion(this PulumiPluginInstallSettings toolSettings, string kindNameVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KindNameVersion = kindNameVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.KindNameVersion"/></em></p>
        ///   <p>Installation may be run either with a specific KIND, NAME, and VERSION, or by omitting these and letting Pulumi compute the set of plugins that may be required by the current project. VERSION cannot be a range: it must be a specific number.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetKindNameVersion(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KindNameVersion = null;
            return toolSettings;
        }
        #endregion
        #region Exact
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Exact"/></em></p>
        ///   <p>Force installation of an exact version match (usually >= is accepted).</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetExact(this PulumiPluginInstallSettings toolSettings, bool? exact)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = exact;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Exact"/></em></p>
        ///   <p>Force installation of an exact version match (usually >= is accepted).</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetExact(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.Exact"/></em></p>
        ///   <p>Force installation of an exact version match (usually >= is accepted).</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableExact(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.Exact"/></em></p>
        ///   <p>Force installation of an exact version match (usually >= is accepted).</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableExact(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.Exact"/></em></p>
        ///   <p>Force installation of an exact version match (usually >= is accepted).</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleExact(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exact = !toolSettings.Exact;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.File"/></em></p>
        ///   <p>Install a plugin from a tarball file, instead of downloading it.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetFile(this PulumiPluginInstallSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.File"/></em></p>
        ///   <p>Install a plugin from a tarball file, instead of downloading it.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetFile(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Reinstall
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Reinstall"/></em></p>
        ///   <p>Reinstall a plugin even if it already exists.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetReinstall(this PulumiPluginInstallSettings toolSettings, bool? reinstall)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reinstall = reinstall;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Reinstall"/></em></p>
        ///   <p>Reinstall a plugin even if it already exists.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetReinstall(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reinstall = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.Reinstall"/></em></p>
        ///   <p>Reinstall a plugin even if it already exists.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableReinstall(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reinstall = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.Reinstall"/></em></p>
        ///   <p>Reinstall a plugin even if it already exists.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableReinstall(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reinstall = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.Reinstall"/></em></p>
        ///   <p>Reinstall a plugin even if it already exists.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleReinstall(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Reinstall = !toolSettings.Reinstall;
            return toolSettings;
        }
        #endregion
        #region Server
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Server"/></em></p>
        ///   <p>A URL to download plugins from.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetServer(this PulumiPluginInstallSettings toolSettings, string server)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = server;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Server"/></em></p>
        ///   <p>A URL to download plugins from.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetServer(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Server = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetColor(this PulumiPluginInstallSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetColor(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetWorkingDirectory(this PulumiPluginInstallSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetWorkingDirectory(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetDisableIntegrityChecking(this PulumiPluginInstallSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetDisableIntegrityChecking(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableDisableIntegrityChecking(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableDisableIntegrityChecking(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleDisableIntegrityChecking(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetEmoji(this PulumiPluginInstallSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetEmoji(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableEmoji(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableEmoji(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleEmoji(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetHelp(this PulumiPluginInstallSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetHelp(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableHelp(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableHelp(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleHelp(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetLogFlow(this PulumiPluginInstallSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetLogFlow(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableLogFlow(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableLogFlow(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleLogFlow(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetLogToStderr(this PulumiPluginInstallSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetLogToStderr(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableLogToStderr(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableLogToStderr(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleLogToStderr(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetNonInteractive(this PulumiPluginInstallSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetNonInteractive(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginInstallSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings EnableNonInteractive(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginInstallSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings DisableNonInteractive(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginInstallSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ToggleNonInteractive(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetProfiling(this PulumiPluginInstallSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetProfiling(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetTracing(this PulumiPluginInstallSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetTracing(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginInstallSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings SetVerbose(this PulumiPluginInstallSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginInstallSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginInstallSettings ResetVerbose(this PulumiPluginInstallSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiPluginListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiPluginListSettingsExtensions
    {
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetJson(this PulumiPluginListSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetJson(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableJson(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableJson(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.Json"/></em></p>
        ///   <p>Emit output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleJson(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region Project
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Project"/></em></p>
        ///   <p>List only the plugins used by the current project.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetProject(this PulumiPluginListSettings toolSettings, bool? project)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = project;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Project"/></em></p>
        ///   <p>List only the plugins used by the current project.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetProject(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.Project"/></em></p>
        ///   <p>List only the plugins used by the current project.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableProject(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.Project"/></em></p>
        ///   <p>List only the plugins used by the current project.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableProject(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.Project"/></em></p>
        ///   <p>List only the plugins used by the current project.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleProject(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Project = !toolSettings.Project;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetColor(this PulumiPluginListSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetColor(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetWorkingDirectory(this PulumiPluginListSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetWorkingDirectory(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetDisableIntegrityChecking(this PulumiPluginListSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetDisableIntegrityChecking(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableDisableIntegrityChecking(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableDisableIntegrityChecking(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleDisableIntegrityChecking(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetEmoji(this PulumiPluginListSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetEmoji(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableEmoji(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableEmoji(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleEmoji(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetHelp(this PulumiPluginListSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetHelp(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableHelp(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableHelp(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleHelp(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetLogFlow(this PulumiPluginListSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetLogFlow(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableLogFlow(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableLogFlow(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleLogFlow(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetLogToStderr(this PulumiPluginListSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetLogToStderr(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableLogToStderr(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableLogToStderr(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleLogToStderr(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetNonInteractive(this PulumiPluginListSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetNonInteractive(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginListSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings EnableNonInteractive(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginListSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings DisableNonInteractive(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginListSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ToggleNonInteractive(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetProfiling(this PulumiPluginListSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetProfiling(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetTracing(this PulumiPluginListSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetTracing(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginListSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings SetVerbose(this PulumiPluginListSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginListSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginListSettings ResetVerbose(this PulumiPluginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region PulumiPluginRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiPluginRemoveSettingsExtensions
    {
        #region KindNameVersion
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.KindNameVersion"/></em></p>
        ///   <p>Specify KIND, NAME, and/or VERSION to narrow down what will be removed. If none are specified, the entire cache will be cleared. If only KIND and NAME are specified, but not VERSION, all versions of the plugin with the given KIND and NAME will be removed. VERSION may be a range.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetKindNameVersion(this PulumiPluginRemoveSettings toolSettings, string kindNameVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KindNameVersion = kindNameVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.KindNameVersion"/></em></p>
        ///   <p>Specify KIND, NAME, and/or VERSION to narrow down what will be removed. If none are specified, the entire cache will be cleared. If only KIND and NAME are specified, but not VERSION, all versions of the plugin with the given KIND and NAME will be removed. VERSION may be a range.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetKindNameVersion(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KindNameVersion = null;
            return toolSettings;
        }
        #endregion
        #region All
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.All"/></em></p>
        ///   <p>Remove all plugins.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetAll(this PulumiPluginRemoveSettings toolSettings, bool? all)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = all;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.All"/></em></p>
        ///   <p>Remove all plugins.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetAll(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.All"/></em></p>
        ///   <p>Remove all plugins.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableAll(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.All"/></em></p>
        ///   <p>Remove all plugins.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableAll(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.All"/></em></p>
        ///   <p>Remove all plugins.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleAll(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.All = !toolSettings.All;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetYes(this PulumiPluginRemoveSettings toolSettings, bool? yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetYes(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableYes(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableYes(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.Yes"/></em></p>
        ///   <p>Skip confirmation prompts, and proceed with removal anyway.</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleYes(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = !toolSettings.Yes;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetColor(this PulumiPluginRemoveSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetColor(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetWorkingDirectory(this PulumiPluginRemoveSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetWorkingDirectory(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetDisableIntegrityChecking(this PulumiPluginRemoveSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetDisableIntegrityChecking(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableDisableIntegrityChecking(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableDisableIntegrityChecking(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleDisableIntegrityChecking(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetEmoji(this PulumiPluginRemoveSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetEmoji(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableEmoji(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableEmoji(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleEmoji(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetHelp(this PulumiPluginRemoveSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetHelp(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableHelp(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableHelp(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleHelp(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetLogFlow(this PulumiPluginRemoveSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetLogFlow(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableLogFlow(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableLogFlow(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleLogFlow(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetLogToStderr(this PulumiPluginRemoveSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetLogToStderr(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableLogToStderr(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableLogToStderr(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleLogToStderr(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetNonInteractive(this PulumiPluginRemoveSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetNonInteractive(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPluginRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings EnableNonInteractive(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPluginRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings DisableNonInteractive(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPluginRemoveSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ToggleNonInteractive(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetProfiling(this PulumiPluginRemoveSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetProfiling(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetTracing(this PulumiPluginRemoveSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetTracing(this PulumiPluginRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPluginRemoveSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings SetVerbose(this PulumiPluginRemoveSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPluginRemoveSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiPluginRemoveSettings ResetVerbose(this PulumiPluginRemoveSettings toolSettings)
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        ///   <p>Config to use during the preview.</p>
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
        #region ConfigPath
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
        ///   <p>Config keys contain a path to a property in a map or list to set.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetConfigPath(this PulumiPreviewSettings toolSettings, bool? configPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigPath = configPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
        ///   <p>Config keys contain a path to a property in a map or list to set.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetConfigPath(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigPath = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
        ///   <p>Config keys contain a path to a property in a map or list to set.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableConfigPath(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigPath = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
        ///   <p>Config keys contain a path to a property in a map or list to set.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableConfigPath(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigPath = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ConfigPath"/></em></p>
        ///   <p>Config keys contain a path to a property in a map or list to set.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleConfigPath(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigPath = !toolSettings.ConfigPath;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetDebug(this PulumiPreviewSettings toolSettings, bool? debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetDebug(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableDebug(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableDebug(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleDebug(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
        #region Diff
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall chang.e</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetDiff(this PulumiPreviewSettings toolSettings, bool? diff)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = diff;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall chang.e</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetDiff(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall chang.e</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableDiff(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall chang.e</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableDiff(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall chang.e</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleDiff(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = !toolSettings.Diff;
            return toolSettings;
        }
        #endregion
        #region ExpectNoChanges
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes are proposed by this preview.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetExpectNoChanges(this PulumiPreviewSettings toolSettings, bool? expectNoChanges)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = expectNoChanges;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes are proposed by this preview.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetExpectNoChanges(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes are proposed by this preview.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableExpectNoChanges(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes are proposed by this preview.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableExpectNoChanges(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes are proposed by this preview.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleExpectNoChanges(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = !toolSettings.ExpectNoChanges;
            return toolSettings;
        }
        #endregion
        #region Json
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Json"/></em></p>
        ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetJson(this PulumiPreviewSettings toolSettings, bool? json)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = json;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Json"/></em></p>
        ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetJson(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Json"/></em></p>
        ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableJson(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Json"/></em></p>
        ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableJson(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Json"/></em></p>
        ///   <p>Serialize the preview diffs, operations, and overall output as JSON.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleJson(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Json = !toolSettings.Json;
            return toolSettings;
        }
        #endregion
        #region Message
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Message"/></em></p>
        ///   <p>Optional message to associate with the preview operation.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetMessage(this PulumiPreviewSettings toolSettings, string message)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = message;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Message"/></em></p>
        ///   <p>Optional message to associate with the preview operation.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetMessage(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = null;
            return toolSettings;
        }
        #endregion
        #region Parallel
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetParallel(this PulumiPreviewSettings toolSettings, int? parallel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = parallel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetParallel(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = null;
            return toolSettings;
        }
        #endregion
        #region Refresh
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetRefresh(this PulumiPreviewSettings toolSettings, bool? refresh)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = refresh;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetRefresh(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableRefresh(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableRefresh(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.Refresh"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleRefresh(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Refresh = !toolSettings.Refresh;
            return toolSettings;
        }
        #endregion
        #region Replace
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Replace"/> to a new list</em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetReplace(this PulumiPreviewSettings toolSettings, params string[] replace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplaceInternal = replace.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Replace"/> to a new list</em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> replace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplaceInternal = replace.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Replace"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddReplace(this PulumiPreviewSettings toolSettings, params string[] replace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplaceInternal.AddRange(replace);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Replace"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> replace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplaceInternal.AddRange(replace);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="PulumiPreviewSettings.Replace"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ClearReplace(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplaceInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Replace"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveReplace(this PulumiPreviewSettings toolSettings, params string[] replace)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replace);
            toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Replace"/></em></p>
        ///   <p>Refresh the state of the stack's resources before this update.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> replace)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replace);
            toolSettings.ReplaceInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region ShowConfig
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetShowConfig(this PulumiPreviewSettings toolSettings, bool? showConfig)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = showConfig;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetShowConfig(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableShowConfig(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableShowConfig(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowConfig"/></em></p>
        ///   <p>Show configuration keys and variables.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleShowConfig(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowConfig = !toolSettings.ShowConfig;
            return toolSettings;
        }
        #endregion
        #region ShowReplacementSteps
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetShowReplacementSteps(this PulumiPreviewSettings toolSettings, bool? showReplacementSteps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = showReplacementSteps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetShowReplacementSteps(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableShowReplacementSteps(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableShowReplacementSteps(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleShowReplacementSteps(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
            return toolSettings;
        }
        #endregion
        #region ShowSames
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetShowSames(this PulumiPreviewSettings toolSettings, bool? showSames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = showSames;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetShowSames(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableShowSames(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableShowSames(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleShowSames(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = !toolSettings.ShowSames;
            return toolSettings;
        }
        #endregion
        #region SuppressOutputs
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetSuppressOutputs(this PulumiPreviewSettings toolSettings, bool? suppressOutputs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = suppressOutputs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetSuppressOutputs(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableSuppressOutputs(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableSuppressOutputs(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleSuppressOutputs(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Target"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTarget(this PulumiPreviewSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Target"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTarget(this PulumiPreviewSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddTarget(this PulumiPreviewSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddTarget(this PulumiPreviewSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="PulumiPreviewSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ClearTarget(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveTarget(this PulumiPreviewSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to update. Other resources will not be updated. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveTarget(this PulumiPreviewSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region TargetDependents
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
        ///   <p>Allows updating of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTargetDependents(this PulumiPreviewSettings toolSettings, bool? targetDependents)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = targetDependents;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
        ///   <p>Allows updating of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetTargetDependents(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
        ///   <p>Allows updating of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings EnableTargetDependents(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
        ///   <p>Allows updating of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings DisableTargetDependents(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiPreviewSettings.TargetDependents"/></em></p>
        ///   <p>Allows updating of dependent targets discovered but not specified in --target list.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ToggleTargetDependents(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetDependents = !toolSettings.TargetDependents;
            return toolSettings;
        }
        #endregion
        #region TargetReplace
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetReplace"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTargetReplace(this PulumiPreviewSettings toolSettings, params string[] targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetReplaceInternal = targetReplace.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.TargetReplace"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetTargetReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetReplaceInternal = targetReplace.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddTargetReplace(this PulumiPreviewSettings toolSettings, params string[] targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetReplaceInternal.AddRange(targetReplace);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings AddTargetReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetReplaceInternal.AddRange(targetReplace);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ClearTargetReplace(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetReplaceInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveTargetReplace(this PulumiPreviewSettings toolSettings, params string[] targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetReplace);
            toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiPreviewSettings.TargetReplace"/></em></p>
        ///   <p>Specify a single resource URN to replace. Other resources will not be updated. Shorthand for --target urn --replace urn.</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings RemoveTargetReplace(this PulumiPreviewSettings toolSettings, IEnumerable<string> targetReplace)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(targetReplace);
            toolSettings.TargetReplaceInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetStack(this PulumiPreviewSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetStack(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetConfigFile(this PulumiPreviewSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetConfigFile(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiPreviewSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings SetWorkingDirectory(this PulumiPreviewSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiPreviewSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiPreviewSettings ResetWorkingDirectory(this PulumiPreviewSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
    #region PulumiRefreshSettingsExtensions
    /// <summary>
    ///   Used within <see cref="PulumiTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class PulumiRefreshSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetDebug(this PulumiRefreshSettings toolSettings, bool? debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetDebug(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableDebug(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableDebug(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.Debug"/></em></p>
        ///   <p>Print detailed debugging output during resource operations.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleDebug(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
        #region Diff
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetDiff(this PulumiRefreshSettings toolSettings, bool? diff)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = diff;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetDiff(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableDiff(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableDiff(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.Diff"/></em></p>
        ///   <p>Display operation as a rich diff showing the overall change.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleDiff(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Diff = !toolSettings.Diff;
            return toolSettings;
        }
        #endregion
        #region ExpectNoChanges
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes occur during this update.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetExpectNoChanges(this PulumiRefreshSettings toolSettings, bool? expectNoChanges)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = expectNoChanges;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes occur during this update.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetExpectNoChanges(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes occur during this update.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableExpectNoChanges(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes occur during this update.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableExpectNoChanges(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.ExpectNoChanges"/></em></p>
        ///   <p>Return an error if any changes occur during this update.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleExpectNoChanges(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ExpectNoChanges = !toolSettings.ExpectNoChanges;
            return toolSettings;
        }
        #endregion
        #region Message
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Message"/></em></p>
        ///   <p>Optional message to associate with the update operation.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetMessage(this PulumiRefreshSettings toolSettings, string message)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = message;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Message"/></em></p>
        ///   <p>Optional message to associate with the update operation.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetMessage(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Message = null;
            return toolSettings;
        }
        #endregion
        #region Parallel
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetParallel(this PulumiRefreshSettings toolSettings, int? parallel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = parallel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Parallel"/></em></p>
        ///   <p>Allow P resource operations to run in parallel at once (1 for no parallelism). Defaults to unbounded. (default 2147483647).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetParallel(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parallel = null;
            return toolSettings;
        }
        #endregion
        #region ShowReplacementSteps
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetShowReplacementSteps(this PulumiRefreshSettings toolSettings, bool? showReplacementSteps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = showReplacementSteps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetShowReplacementSteps(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableShowReplacementSteps(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableShowReplacementSteps(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.ShowReplacementSteps"/></em></p>
        ///   <p>Show detailed resource replacement creates and deletes instead of a single step.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleShowReplacementSteps(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowReplacementSteps = !toolSettings.ShowReplacementSteps;
            return toolSettings;
        }
        #endregion
        #region ShowSames
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetShowSames(this PulumiRefreshSettings toolSettings, bool? showSames)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = showSames;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetShowSames(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableShowSames(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableShowSames(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.ShowSames"/></em></p>
        ///   <p>Show resources that don't need to be updated because they haven't changed, alongside those that do.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleShowSames(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ShowSames = !toolSettings.ShowSames;
            return toolSettings;
        }
        #endregion
        #region SuppressOutputs
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetSuppressOutputs(this PulumiRefreshSettings toolSettings, bool? suppressOutputs)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = suppressOutputs;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetSuppressOutputs(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableSuppressOutputs(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableSuppressOutputs(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.SuppressOutputs"/></em></p>
        ///   <p>Suppress display of stack outputs (in case they contain sensitive values).</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleSuppressOutputs(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SuppressOutputs = !toolSettings.SuppressOutputs;
            return toolSettings;
        }
        #endregion
        #region Target
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Target"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetTarget(this PulumiRefreshSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Target"/> to a new list</em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetTarget(this PulumiRefreshSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal = target.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiRefreshSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings AddTarget(this PulumiRefreshSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="PulumiRefreshSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings AddTarget(this PulumiRefreshSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.AddRange(target);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="PulumiRefreshSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ClearTarget(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiRefreshSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings RemoveTarget(this PulumiRefreshSettings toolSettings, params string[] target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="PulumiRefreshSettings.Target"/></em></p>
        ///   <p>Specify a single resource URN to refresh. Multiple resources can be specified using --target urn1 --target urn2.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings RemoveTarget(this PulumiRefreshSettings toolSettings, IEnumerable<string> target)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(target);
            toolSettings.TargetInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the refresh after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetYes(this PulumiRefreshSettings toolSettings, bool? yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the refresh after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetYes(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the refresh after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableYes(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the refresh after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableYes(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.Yes"/></em></p>
        ///   <p>Automatically approve and perform the refresh after previewing it.</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleYes(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = !toolSettings.Yes;
            return toolSettings;
        }
        #endregion
        #region Stack
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetStack(this PulumiRefreshSettings toolSettings, string stack)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = stack;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Stack"/></em></p>
        ///   <p>The name of the stack to operate on. Defaults to the current stack</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetStack(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Stack = null;
            return toolSettings;
        }
        #endregion
        #region ConfigFile
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetConfigFile(this PulumiRefreshSettings toolSettings, string configFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = configFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.ConfigFile"/></em></p>
        ///   <p>Use the configuration values in the specified file rather than detecting the file name</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetConfigFile(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConfigFile = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetColor(this PulumiRefreshSettings toolSettings, ColorizeOutput color)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Color"/></em></p>
        ///   <p>Colorize output. Choices are: always, never, raw, auto (default is auto)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetColor(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetWorkingDirectory(this PulumiRefreshSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetWorkingDirectory(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
            return toolSettings;
        }
        #endregion
        #region DisableIntegrityChecking
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetDisableIntegrityChecking(this PulumiRefreshSettings toolSettings, bool? disableIntegrityChecking)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = disableIntegrityChecking;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetDisableIntegrityChecking(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableDisableIntegrityChecking(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableDisableIntegrityChecking(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.DisableIntegrityChecking"/></em></p>
        ///   <p>Disable integrity checking of checkpoint files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleDisableIntegrityChecking(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableIntegrityChecking = !toolSettings.DisableIntegrityChecking;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetEmoji(this PulumiRefreshSettings toolSettings, bool? emoji)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetEmoji(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableEmoji(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableEmoji(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.Emoji"/></em></p>
        ///   <p>Enable emojis in the output (default is true)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleEmoji(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = !toolSettings.Emoji;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetHelp(this PulumiRefreshSettings toolSettings, bool? help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetHelp(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableHelp(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableHelp(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.Help"/></em></p>
        ///   <p>Help for Pulumi</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleHelp(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region LogFlow
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetLogFlow(this PulumiRefreshSettings toolSettings, bool? logFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = logFlow;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetLogFlow(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableLogFlow(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableLogFlow(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.LogFlow"/></em></p>
        ///   <p>Flow log settings to child processes (like plugins)</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleLogFlow(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogFlow = !toolSettings.LogFlow;
            return toolSettings;
        }
        #endregion
        #region LogToStderr
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetLogToStderr(this PulumiRefreshSettings toolSettings, bool? logToStderr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = logToStderr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetLogToStderr(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableLogToStderr(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableLogToStderr(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.LogToStderr"/></em></p>
        ///   <p>Log to stderr instead of to files</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleLogToStderr(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LogToStderr = !toolSettings.LogToStderr;
            return toolSettings;
        }
        #endregion
        #region NonInteractive
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetNonInteractive(this PulumiRefreshSettings toolSettings, bool? nonInteractive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = nonInteractive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetNonInteractive(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="PulumiRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings EnableNonInteractive(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="PulumiRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings DisableNonInteractive(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="PulumiRefreshSettings.NonInteractive"/></em></p>
        ///   <p>Disable interactive mode for all commands</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ToggleNonInteractive(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NonInteractive = !toolSettings.NonInteractive;
            return toolSettings;
        }
        #endregion
        #region Profiling
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetProfiling(this PulumiRefreshSettings toolSettings, string profiling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = profiling;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Profiling"/></em></p>
        ///   <p>Emit CPU and memory profiles and an execution trace to '[filename].[pid].{cpu,mem,trace}', respectively</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetProfiling(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Profiling = null;
            return toolSettings;
        }
        #endregion
        #region Tracing
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetTracing(this PulumiRefreshSettings toolSettings, string tracing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = tracing;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Tracing"/></em></p>
        ///   <p>Emit tracing to the specified endpoint. Use the file: scheme to write tracing data to a local file</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetTracing(this PulumiRefreshSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tracing = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiRefreshSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings SetVerbose(this PulumiRefreshSettings toolSettings, int? verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiRefreshSettings.Verbose"/></em></p>
        ///   <p>Enable verbose logging (e.g., v=3); anything >3 is very verbose</p>
        /// </summary>
        [Pure]
        public static PulumiRefreshSettings ResetVerbose(this PulumiRefreshSettings toolSettings)
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings SetWorkingDirectory(this PulumiStackSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackSettings ResetWorkingDirectory(this PulumiStackSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
        ///   <p>Show value of specific property.</p>
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
        ///   <p>Show value of specific property.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        ///   <p>Emit output as JSON.</p>
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
        #region WorkingDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="PulumiStackOutputSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings SetWorkingDirectory(this PulumiStackOutputSettings toolSettings, string workingDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = workingDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="PulumiStackOutputSettings.WorkingDirectory"/></em></p>
        ///   <p>Run pulumi as if it had been started in another directory</p>
        /// </summary>
        [Pure]
        public static PulumiStackOutputSettings ResetWorkingDirectory(this PulumiStackOutputSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkingDirectory = null;
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
