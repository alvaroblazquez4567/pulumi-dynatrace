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

    public sealed class ApplicationAnomaliesFailureRateAutoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute increase of failing service calls to trigger an alert, %
        /// </summary>
        [Input("absolute", required: true)]
        public Input<int> Absolute { get; set; } = null!;

        /// <summary>
        /// Relative increase of failing service calls to trigger an alert, %
        /// </summary>
        [Input("relative", required: true)]
        public Input<int> Relative { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public ApplicationAnomaliesFailureRateAutoArgs()
        {
        }
        public static new ApplicationAnomaliesFailureRateAutoArgs Empty => new ApplicationAnomaliesFailureRateAutoArgs();
    }
}
