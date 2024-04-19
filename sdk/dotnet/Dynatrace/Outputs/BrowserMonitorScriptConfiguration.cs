// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class BrowserMonitorScriptConfiguration
    {
        /// <summary>
        /// The emulated device of the monitor—holds either the parameters of the custom device or the name and orientation of the preconfigured device.
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationBandwidth? Bandwidth;
        public readonly ImmutableArray<string> Blocks;
        public readonly bool? BypassCsp;
        /// <summary>
        /// Every cookie must be unique within the list. However, you can use the same cookie again in other event
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptConfigurationCookies? Cookies;
        public readonly Outputs.BrowserMonitorScriptConfigurationDevice? Device;
        public readonly bool? DisableWebSecurity;
        public readonly Outputs.BrowserMonitorScriptConfigurationHeaders? Headers;
        public readonly Outputs.BrowserMonitorScriptConfigurationIgnoredErrorCodes? IgnoredErrorCodes;
        public readonly Outputs.BrowserMonitorScriptConfigurationJavascriptSetttings? JavascriptSetttings;
        public readonly bool? MonitorFrames;
        public readonly string? UserAgent;

        [OutputConstructor]
        private BrowserMonitorScriptConfiguration(
            Outputs.BrowserMonitorScriptConfigurationBandwidth? bandwidth,

            ImmutableArray<string> blocks,

            bool? bypassCsp,

            Outputs.BrowserMonitorScriptConfigurationCookies? cookies,

            Outputs.BrowserMonitorScriptConfigurationDevice? device,

            bool? disableWebSecurity,

            Outputs.BrowserMonitorScriptConfigurationHeaders? headers,

            Outputs.BrowserMonitorScriptConfigurationIgnoredErrorCodes? ignoredErrorCodes,

            Outputs.BrowserMonitorScriptConfigurationJavascriptSetttings? javascriptSetttings,

            bool? monitorFrames,

            string? userAgent)
        {
            Bandwidth = bandwidth;
            Blocks = blocks;
            BypassCsp = bypassCsp;
            Cookies = cookies;
            Device = device;
            DisableWebSecurity = disableWebSecurity;
            Headers = headers;
            IgnoredErrorCodes = ignoredErrorCodes;
            JavascriptSetttings = javascriptSetttings;
            MonitorFrames = monitorFrames;
            UserAgent = userAgent;
        }
    }
}
