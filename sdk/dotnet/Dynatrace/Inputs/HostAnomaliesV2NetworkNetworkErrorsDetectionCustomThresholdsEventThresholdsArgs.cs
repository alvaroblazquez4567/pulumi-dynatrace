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

    public sealed class HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholdsEventThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of **10-second samples** that form the sliding evaluation window for dealerting.
        /// </summary>
        [Input("dealertingEvaluationWindow", required: true)]
        public Input<int> DealertingEvaluationWindow { get; set; } = null!;

        /// <summary>
        /// The number of **10-second samples** within the evaluation window that must be lower the threshold to close an event
        /// </summary>
        [Input("dealertingSamples", required: true)]
        public Input<int> DealertingSamples { get; set; } = null!;

        /// <summary>
        /// The number of **10-second samples** that form the sliding evaluation window to detect violating samples.
        /// </summary>
        [Input("violatingEvaluationWindow", required: true)]
        public Input<int> ViolatingEvaluationWindow { get; set; } = null!;

        /// <summary>
        /// The number of **10-second samples** within the evaluation window that must exceed the threshold to trigger an event
        /// </summary>
        [Input("violatingSamples", required: true)]
        public Input<int> ViolatingSamples { get; set; } = null!;

        public HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholdsEventThresholdsArgs()
        {
        }
        public static new HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholdsEventThresholdsArgs Empty => new HostAnomaliesV2NetworkNetworkErrorsDetectionCustomThresholdsEventThresholdsArgs();
    }
}
