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

    public sealed class HostAnomaliesNetworkRetransmissionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Custom thresholds for high CPU saturation. If not set then the automatic mode is used
        /// </summary>
        [Input("thresholds")]
        public Input<Inputs.HostAnomaliesNetworkRetransmissionThresholdsArgs>? Thresholds { get; set; }

        public HostAnomaliesNetworkRetransmissionArgs()
        {
        }
        public static new HostAnomaliesNetworkRetransmissionArgs Empty => new HostAnomaliesNetworkRetransmissionArgs();
    }
}