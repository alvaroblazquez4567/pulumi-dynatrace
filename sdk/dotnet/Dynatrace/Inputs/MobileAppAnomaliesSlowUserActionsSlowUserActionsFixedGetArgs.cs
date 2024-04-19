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

    public sealed class MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// To avoid over-alerting do not alert for low traffic applications with less than
        /// </summary>
        [Input("durationAvoidOveralerting", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationAvoidOveralertingGetArgs> DurationAvoidOveralerting { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of all user actions degrades beyond the absolute threshold:
        /// </summary>
        [Input("durationThresholdAllFixed", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdAllFixedGetArgs> DurationThresholdAllFixed { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of the slowest 10% of user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        [Input("durationThresholdSlowest", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedDurationThresholdSlowestGetArgs> DurationThresholdSlowest { get; set; } = null!;

        /// <summary>
        /// Possible Values: `Low`, `Medium`, `High`
        /// </summary>
        [Input("sensitivity", required: true)]
        public Input<string> Sensitivity { get; set; } = null!;

        public MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedGetArgs()
        {
        }
        public static new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedGetArgs Empty => new MobileAppAnomaliesSlowUserActionsSlowUserActionsFixedGetArgs();
    }
}
