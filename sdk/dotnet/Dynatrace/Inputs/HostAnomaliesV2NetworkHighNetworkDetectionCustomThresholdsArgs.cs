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

    public sealed class HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if sent/received traffic utilization is higher than this threshold for the defined amount of samples
        /// </summary>
        [Input("errorsPercentage", required: true)]
        public Input<int> ErrorsPercentage { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("eventThresholds", required: true)]
        public Input<Inputs.HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsEventThresholdsArgs> EventThresholds { get; set; } = null!;

        public HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsArgs()
        {
        }
        public static new HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsArgs Empty => new HostAnomaliesV2NetworkHighNetworkDetectionCustomThresholdsArgs();
    }
}
