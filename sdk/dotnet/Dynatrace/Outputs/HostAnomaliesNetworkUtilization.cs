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
    public sealed class HostAnomaliesNetworkUtilization
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Custom thresholds for high CPU saturation. If not set then the automatic mode is used
        /// </summary>
        public readonly Outputs.HostAnomaliesNetworkUtilizationThresholds? Thresholds;

        [OutputConstructor]
        private HostAnomaliesNetworkUtilization(
            bool enabled,

            Outputs.HostAnomaliesNetworkUtilizationThresholds? thresholds)
        {
            Enabled = enabled;
            Thresholds = thresholds;
        }
    }
}
