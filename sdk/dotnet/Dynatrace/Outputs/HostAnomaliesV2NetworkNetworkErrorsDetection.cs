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
    public sealed class HostAnomaliesV2NetworkNetworkErrorsDetection
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for CPU saturation
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect host or monitoring connection lost problems
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private HostAnomaliesV2NetworkNetworkErrorsDetection(
            Outputs.HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}
