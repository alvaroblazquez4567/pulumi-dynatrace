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
    public sealed class ServiceAnomaliesV2ResponseTime
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.ServiceAnomaliesV2ResponseTimeAutoDetection? AutoDetection;
        /// <summary>
        /// Possible Values: `Auto`, `Fixed`
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.ServiceAnomaliesV2ResponseTimeFixedDetection? FixedDetection;

        [OutputConstructor]
        private ServiceAnomaliesV2ResponseTime(
            Outputs.ServiceAnomaliesV2ResponseTimeAutoDetection? autoDetection,

            string? detectionMode,

            bool enabled,

            Outputs.ServiceAnomaliesV2ResponseTimeFixedDetection? fixedDetection)
        {
            AutoDetection = autoDetection;
            DetectionMode = detectionMode;
            Enabled = enabled;
            FixedDetection = fixedDetection;
        }
    }
}
