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
    public sealed class HostAnomaliesNetworkErrorsThresholds
    {
        /// <summary>
        /// Receive/transmit error packet percentage is higher than *X*% in 3 out of 5 samples
        /// </summary>
        public readonly int ErrorsPercentage;
        /// <summary>
        /// Total receive/transmit packets rate is higher than *X* packets per second in 3 out of 5 samples
        /// </summary>
        public readonly int TotalPacketsRate;

        [OutputConstructor]
        private HostAnomaliesNetworkErrorsThresholds(
            int errorsPercentage,

            int totalPacketsRate)
        {
            ErrorsPercentage = errorsPercentage;
            TotalPacketsRate = totalPacketsRate;
        }
    }
}
