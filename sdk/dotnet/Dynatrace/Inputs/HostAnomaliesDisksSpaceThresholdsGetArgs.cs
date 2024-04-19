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

    public sealed class HostAnomaliesDisksSpaceThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if percentage of available inodes is lower than *X*% in 3 out of 5 samples
        /// </summary>
        [Input("percentage", required: true)]
        public Input<int> Percentage { get; set; } = null!;

        public HostAnomaliesDisksSpaceThresholdsGetArgs()
        {
        }
        public static new HostAnomaliesDisksSpaceThresholdsGetArgs Empty => new HostAnomaliesDisksSpaceThresholdsGetArgs();
    }
}
