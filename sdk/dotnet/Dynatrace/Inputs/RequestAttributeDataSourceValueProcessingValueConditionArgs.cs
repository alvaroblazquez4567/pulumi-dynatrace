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

    public sealed class RequestAttributeDataSourceValueProcessingValueConditionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Negate the comparison
        /// </summary>
        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        /// <summary>
        /// Operator comparing the extracted value to the comparison value
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The value to compare to
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public RequestAttributeDataSourceValueProcessingValueConditionArgs()
        {
        }
        public static new RequestAttributeDataSourceValueProcessingValueConditionArgs Empty => new RequestAttributeDataSourceValueProcessingValueConditionArgs();
    }
}