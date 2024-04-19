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

    public sealed class HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("eventThresholds", required: true)]
        public Input<Inputs.HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsEventThresholdsGetArgs> EventThresholds { get; set; } = null!;

        /// <summary>
        /// Alert if the memory page fault rate on Unix systems is higher than this threshold for the defined amount of samples
        /// </summary>
        [Input("pageFaultsPerSecondNonWindows", required: true)]
        public Input<int> PageFaultsPerSecondNonWindows { get; set; } = null!;

        /// <summary>
        /// Alert if the memory page fault rate on Windows is higher than this threshold for the defined amount of samples
        /// </summary>
        [Input("pageFaultsPerSecondWindows", required: true)]
        public Input<int> PageFaultsPerSecondWindows { get; set; } = null!;

        /// <summary>
        /// Alert if the memory usage on Unix systems is higher than this threshold
        /// </summary>
        [Input("usedMemoryPercentageNonWindows", required: true)]
        public Input<int> UsedMemoryPercentageNonWindows { get; set; } = null!;

        /// <summary>
        /// Alert if the memory usage on Windows is higher than this threshold
        /// </summary>
        [Input("usedMemoryPercentageWindows", required: true)]
        public Input<int> UsedMemoryPercentageWindows { get; set; } = null!;

        public HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsGetArgs()
        {
        }
        public static new HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsGetArgs Empty => new HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsGetArgs();
    }
}
