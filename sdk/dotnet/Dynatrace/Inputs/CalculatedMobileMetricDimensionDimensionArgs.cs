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

    public sealed class CalculatedMobileMetricDimensionDimensionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A dimensions for the metric usage
        /// </summary>
        [Input("dimension", required: true)]
        public Input<string> Dimension { get; set; } = null!;

        /// <summary>
        /// The number of top values to be calculated
        /// </summary>
        [Input("topX", required: true)]
        public Input<int> TopX { get; set; } = null!;

        public CalculatedMobileMetricDimensionDimensionArgs()
        {
        }
        public static new CalculatedMobileMetricDimensionDimensionArgs Empty => new CalculatedMobileMetricDimensionDimensionArgs();
    }
}
