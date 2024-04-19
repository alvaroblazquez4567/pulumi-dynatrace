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

    public sealed class HostAnomaliesMemoryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Custom thresholds for high memory usage. If not set then the automatic mode is used. **Both** conditions must be met to trigger an alert
        /// </summary>
        [Input("thresholds")]
        public Input<Inputs.HostAnomaliesMemoryThresholdsArgs>? Thresholds { get; set; }

        public HostAnomaliesMemoryArgs()
        {
        }
        public static new HostAnomaliesMemoryArgs Empty => new HostAnomaliesMemoryArgs();
    }
}
