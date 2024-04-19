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

    public sealed class HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("eventThresholds", required: true)]
        public Input<Inputs.HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsEventThresholdsGetArgs> EventThresholds { get; set; } = null!;

        /// <summary>
        /// Alert if the number of Java out-of-threads exceptions is at least this value
        /// </summary>
        [Input("outOfThreadsExceptionsNumber", required: true)]
        public Input<int> OutOfThreadsExceptionsNumber { get; set; } = null!;

        public HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsGetArgs()
        {
        }
        public static new HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsGetArgs Empty => new HostAnomaliesV2HostOutOfThreadsDetectionCustomThresholdsGetArgs();
    }
}