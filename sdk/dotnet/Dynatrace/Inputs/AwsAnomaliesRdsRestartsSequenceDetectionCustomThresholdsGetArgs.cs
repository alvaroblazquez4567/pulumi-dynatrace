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

    public sealed class AwsAnomaliesRdsRestartsSequenceDetectionCustomThresholdsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of restarts per minute is equal or higher than
        /// </summary>
        [Input("restartsPerMinute", required: true)]
        public Input<int> RestartsPerMinute { get; set; } = null!;

        public AwsAnomaliesRdsRestartsSequenceDetectionCustomThresholdsGetArgs()
        {
        }
        public static new AwsAnomaliesRdsRestartsSequenceDetectionCustomThresholdsGetArgs Empty => new AwsAnomaliesRdsRestartsSequenceDetectionCustomThresholdsGetArgs();
    }
}