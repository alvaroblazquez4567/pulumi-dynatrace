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

    public sealed class HostAnomaliesNetworkDroppedPacketsThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of high number of dropped packets detection
        /// </summary>
        [Input("droppedPackets", required: true)]
        public Input<int> DroppedPackets { get; set; } = null!;

        /// <summary>
        /// Total receive/transmit packets rate is higher than *X* packets per second in 3 out of 5 samples
        /// </summary>
        [Input("totalPacketsRate", required: true)]
        public Input<int> TotalPacketsRate { get; set; } = null!;

        public HostAnomaliesNetworkDroppedPacketsThresholdsGetArgs()
        {
        }
        public static new HostAnomaliesNetworkDroppedPacketsThresholdsGetArgs Empty => new HostAnomaliesNetworkDroppedPacketsThresholdsGetArgs();
    }
}
