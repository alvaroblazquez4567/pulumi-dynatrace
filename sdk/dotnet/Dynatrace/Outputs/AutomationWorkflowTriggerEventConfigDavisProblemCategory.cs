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
    public sealed class AutomationWorkflowTriggerEventConfigDavisProblemCategory
    {
        public readonly bool? Availability;
        /// <summary>
        /// A custom condition that needs to be met for the current task to get executed
        /// </summary>
        public readonly bool? Custom;
        public readonly bool? Error;
        public readonly bool? Info;
        public readonly bool? MonitoringUnavailable;
        public readonly bool? Resource;
        public readonly bool? Slowdown;

        [OutputConstructor]
        private AutomationWorkflowTriggerEventConfigDavisProblemCategory(
            bool? availability,

            bool? custom,

            bool? error,

            bool? info,

            bool? monitoringUnavailable,

            bool? resource,

            bool? slowdown)
        {
            Availability = availability;
            Custom = custom;
            Error = error;
            Info = info;
            MonitoringUnavailable = monitoringUnavailable;
            Resource = resource;
            Slowdown = slowdown;
        }
    }
}
