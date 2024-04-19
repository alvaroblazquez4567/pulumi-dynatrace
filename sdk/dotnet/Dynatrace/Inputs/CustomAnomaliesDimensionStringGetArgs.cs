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

    public sealed class CustomAnomaliesDimensionStringGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A filter for a string value based on the given operator
        /// </summary>
        [Input("filter", required: true)]
        public Input<Inputs.CustomAnomaliesDimensionStringFilterGetArgs> Filter { get; set; } = null!;

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("index")]
        public Input<int>? Index { get; set; }

        /// <summary>
        /// The dimensions key on the metric
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CustomAnomaliesDimensionStringGetArgs()
        {
        }
        public static new CustomAnomaliesDimensionStringGetArgs Empty => new CustomAnomaliesDimensionStringGetArgs();
    }
}