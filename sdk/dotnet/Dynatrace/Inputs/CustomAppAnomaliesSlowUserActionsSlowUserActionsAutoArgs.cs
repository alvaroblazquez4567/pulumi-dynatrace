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

    public sealed class CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// To avoid over-alerting do not alert for low traffic applications with less than
        /// </summary>
        [Input("durationAvoidOveralerting", required: true)]
        public Input<Inputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationAvoidOveralertingArgs> DurationAvoidOveralerting { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of all user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        [Input("durationThresholdAll", required: true)]
        public Input<Inputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdAllArgs> DurationThresholdAll { get; set; } = null!;

        /// <summary>
        /// Alert if the action duration of the slowest 10% of user actions degrades beyond **both** the absolute and relative threshold:
        /// </summary>
        [Input("durationThresholdSlowest", required: true)]
        public Input<Inputs.CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoDurationThresholdSlowestArgs> DurationThresholdSlowest { get; set; } = null!;

        public CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs()
        {
        }
        public static new CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs Empty => new CustomAppAnomaliesSlowUserActionsSlowUserActionsAutoArgs();
    }
}
