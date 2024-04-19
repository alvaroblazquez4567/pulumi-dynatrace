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
    public sealed class WebAppKeyPerformanceLoadFallbackThresholds
    {
        /// <summary>
        /// If **User action duration** is above this value, the action is assigned to the Frustrated performance zone.
        /// </summary>
        public readonly double FrustratingFallbackThresholdSeconds;
        /// <summary>
        /// If **User action duration** is below this value, the action is assigned to the Satisfied performance zone.
        /// </summary>
        public readonly double ToleratedFallbackThresholdSeconds;

        [OutputConstructor]
        private WebAppKeyPerformanceLoadFallbackThresholds(
            double frustratingFallbackThresholdSeconds,

            double toleratedFallbackThresholdSeconds)
        {
            FrustratingFallbackThresholdSeconds = frustratingFallbackThresholdSeconds;
            ToleratedFallbackThresholdSeconds = toleratedFallbackThresholdSeconds;
        }
    }
}
