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

    public sealed class CustomAnomaliesDimensionEntityGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A filter for a string value based on the given operator
        /// </summary>
        [Input("filter", required: true)]
        public Input<Inputs.CustomAnomaliesDimensionEntityFilterGetArgs> Filter { get; set; } = null!;

        /// <summary>
        /// The dimensions key on the metric
        /// </summary>
        [Input("key")]
        public Input<string>? Key { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CustomAnomaliesDimensionEntityGetArgs()
        {
        }
        public static new CustomAnomaliesDimensionEntityGetArgs Empty => new CustomAnomaliesDimensionEntityGetArgs();
    }
}
