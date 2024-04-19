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
    public sealed class HttpMonitorAnomalyDetectionOutageHandlingLocalOutagePolicy
    {
        /// <summary>
        /// The number of affected locations to trigger an alert
        /// </summary>
        public readonly int AffectedLocations;
        /// <summary>
        /// The number of consecutive fails to trigger an alert
        /// </summary>
        public readonly int ConsecutiveRuns;

        [OutputConstructor]
        private HttpMonitorAnomalyDetectionOutageHandlingLocalOutagePolicy(
            int affectedLocations,

            int consecutiveRuns)
        {
            AffectedLocations = affectedLocations;
            ConsecutiveRuns = consecutiveRuns;
        }
    }
}
