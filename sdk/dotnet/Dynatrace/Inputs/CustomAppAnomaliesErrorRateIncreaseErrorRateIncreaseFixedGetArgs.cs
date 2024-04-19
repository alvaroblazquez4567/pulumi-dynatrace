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

    public sealed class CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixedGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `Low`, `Medium`, `High`
        /// </summary>
        [Input("sensitivity", required: true)]
        public Input<string> Sensitivity { get; set; } = null!;

        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("thresholdAbsolute", required: true)]
        public Input<double> ThresholdAbsolute { get; set; } = null!;

        public CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixedGetArgs()
        {
        }
        public static new CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixedGetArgs Empty => new CustomAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixedGetArgs();
    }
}