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
    public sealed class GetSyntheticNodesNodeResult
    {
        public readonly string ActiveGateVersion;
        public readonly bool AutoUpdate;
        public readonly bool BrowserMonitors;
        public readonly string HealthCheckStatus;
        public readonly string Hostname;
        public readonly string Id;
        public readonly ImmutableArray<string> Ips;
        public readonly bool OneAgentRouting;
        public readonly string OperatingSystem;
        public readonly string PlayerVersion;
        public readonly string Status;
        public readonly string Version;

        [OutputConstructor]
        private GetSyntheticNodesNodeResult(
            string activeGateVersion,

            bool autoUpdate,

            bool browserMonitors,

            string healthCheckStatus,

            string hostname,

            string id,

            ImmutableArray<string> ips,

            bool oneAgentRouting,

            string operatingSystem,

            string playerVersion,

            string status,

            string version)
        {
            ActiveGateVersion = activeGateVersion;
            AutoUpdate = autoUpdate;
            BrowserMonitors = browserMonitors;
            HealthCheckStatus = healthCheckStatus;
            Hostname = hostname;
            Id = id;
            Ips = ips;
            OneAgentRouting = oneAgentRouting;
            OperatingSystem = operatingSystem;
            PlayerVersion = playerVersion;
            Status = status;
            Version = version;
        }
    }
}