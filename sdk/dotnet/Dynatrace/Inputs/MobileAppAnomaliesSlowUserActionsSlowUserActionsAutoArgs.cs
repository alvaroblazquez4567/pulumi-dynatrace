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

    public sealed class MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// To avoid over-alerting do not alert for low traffic applications with less than
        /// </summary>
        [Input("durationAvoidOveralerting", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralertingArgs> DurationAvoidOveralerting { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of all user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        [Input("durationThresholdAll", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdAllArgs> DurationThresholdAll { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of the slowest 10% of user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        [Input("durationThresholdSlowest", required: true)]
        public Input<Inputs.MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowestArgs> DurationThresholdSlowest { get; set; } = null!;

        public MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs()
        {
        }
        public static new MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs Empty => new MobileAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs();
    }
}