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

    public sealed class CustomAnomaliesStrategyGenericGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines the actual set of fields depending on the value
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CustomAnomaliesStrategyGenericGetArgs()
        {
        }
        public static new CustomAnomaliesStrategyGenericGetArgs Empty => new CustomAnomaliesStrategyGenericGetArgs();
    }
}
