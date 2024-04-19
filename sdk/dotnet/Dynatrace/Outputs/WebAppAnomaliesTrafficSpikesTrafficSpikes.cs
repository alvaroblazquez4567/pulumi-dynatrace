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
    public sealed class WebAppAnomaliesTrafficSpikesTrafficSpikes
    {
        /// <summary>
        /// Only alert if the abnormal state remains for at least
        /// </summary>
        public readonly double MinutesAbnormalState;
        /// <summary>
        /// Alert if the observed traffic is more than this percentage of the expected value
        /// </summary>
        public readonly double TrafficSpikePercentage;

        [OutputConstructor]
        private WebAppAnomaliesTrafficSpikesTrafficSpikes(
            double minutesAbnormalState,

            double trafficSpikePercentage)
        {
            MinutesAbnormalState = minutesAbnormalState;
            TrafficSpikePercentage = trafficSpikePercentage;
        }
    }
}
