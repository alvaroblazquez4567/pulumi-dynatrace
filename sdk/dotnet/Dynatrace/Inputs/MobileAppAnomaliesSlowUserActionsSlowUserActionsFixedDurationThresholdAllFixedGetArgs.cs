// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("durationThreshold", required: true)]
        public Input<double> DurationThreshold { get; set; } = null!;

        public MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedGetArgs()
        {
        }
        public static new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedGetArgs Empty => new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedGetArgs();
    }
}
