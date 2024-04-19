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
    public sealed class HostAnomaliesV2HostOutOfThreadsDetection
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for CPU saturation
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect host or monitoring connection lost problems
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private HostAnomaliesV2HostOutOfThreadsDetection(
            Outputs.HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}
