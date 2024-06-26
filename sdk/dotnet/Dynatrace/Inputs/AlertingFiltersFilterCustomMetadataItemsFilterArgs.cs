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

    public sealed class AlertingFiltersFilterCustomMetadataItemsFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// GET /api/v2/eventProperties for list of available keys
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Reverses the comparison **operator**. For example it turns the **begins with** into **does not begin with**
        /// </summary>
        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        /// <summary>
        /// The value to compare to
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public AlertingFiltersFilterCustomMetadataItemsFilterArgs()
        {
        }
        public static new AlertingFiltersFilterCustomMetadataItemsFilterArgs Empty => new AlertingFiltersFilterCustomMetadataItemsFilterArgs();
    }
}
