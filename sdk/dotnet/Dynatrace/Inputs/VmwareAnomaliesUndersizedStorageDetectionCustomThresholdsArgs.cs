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

    public sealed class VmwareAnomaliesUndersizedStorageDetectionCustomThresholdsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Average queue command latency is higher than
        /// </summary>
        [Input("averageQueueCommandLatency", required: true)]
        public Input<int> AverageQueueCommandLatency { get; set; } = null!;

        /// <summary>
        /// Peak queue command latency is higher than
        /// </summary>
        [Input("peakQueueCommandLatency", required: true)]
        public Input<int> PeakQueueCommandLatency { get; set; } = null!;

        public VmwareAnomaliesUndersizedStorageDetectionCustomThresholdsArgs()
        {
        }
        public static new VmwareAnomaliesUndersizedStorageDetectionCustomThresholdsArgs Empty => new VmwareAnomaliesUndersizedStorageDetectionCustomThresholdsArgs();
    }
}