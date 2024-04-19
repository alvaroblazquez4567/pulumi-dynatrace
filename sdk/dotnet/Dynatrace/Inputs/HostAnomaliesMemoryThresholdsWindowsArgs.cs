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

    public sealed class HostAnomaliesMemoryThresholdsWindowsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Memory page fault rate is higher than *X* faults per second
        /// </summary>
        [Input("pageFaults", required: true)]
        public Input<int> PageFaults { get; set; } = null!;

        /// <summary>
        /// Memory usage is higher than *X*%
        /// </summary>
        [Input("usage", required: true)]
        public Input<int> Usage { get; set; } = null!;

        public HostAnomaliesMemoryThresholdsWindowsArgs()
        {
        }
        public static new HostAnomaliesMemoryThresholdsWindowsArgs Empty => new HostAnomaliesMemoryThresholdsWindowsArgs();
    }
}
