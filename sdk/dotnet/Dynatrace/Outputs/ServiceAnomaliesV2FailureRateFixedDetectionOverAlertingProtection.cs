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
    public sealed class ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection
    {
        /// <summary>
        /// Only alert if the abnormal state remains for at least
        /// </summary>
        public readonly int MinutesAbnormalState;
        /// <summary>
        /// Only alert if there are at least
        /// </summary>
        public readonly double RequestsPerMinute;

        [OutputConstructor]
        private ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection(
            int minutesAbnormalState,

            double requestsPerMinute)
        {
            MinutesAbnormalState = minutesAbnormalState;
            RequestsPerMinute = requestsPerMinute;
        }
    }
}
