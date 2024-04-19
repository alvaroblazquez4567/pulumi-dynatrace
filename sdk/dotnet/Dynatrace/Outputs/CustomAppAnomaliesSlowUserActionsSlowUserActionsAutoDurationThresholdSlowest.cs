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
    public sealed class CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowest
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        public readonly double DurationThreshold;
        /// <summary>
        /// Relative threshold
        /// </summary>
        public readonly double SlowdownPercentage;

        [OutputConstructor]
        private CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowest(
            double durationThreshold,

            double slowdownPercentage)
        {
            DurationThreshold = durationThreshold;
            SlowdownPercentage = slowdownPercentage;
        }
    }
}
