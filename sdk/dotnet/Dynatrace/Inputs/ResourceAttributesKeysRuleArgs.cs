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

    public sealed class ResourceAttributesKeysRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attribute key **service.name** is automatically captured by default
        /// </summary>
        [Input("attributeKey", required: true)]
        public Input<string> AttributeKey { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Possible Values: `MASK_ENTIRE_VALUE`, `MASK_ONLY_CONFIDENTIAL_DATA`, `NOT_MASKED`
        /// </summary>
        [Input("masking", required: true)]
        public Input<string> Masking { get; set; } = null!;

        public ResourceAttributesKeysRuleArgs()
        {
        }
        public static new ResourceAttributesKeysRuleArgs Empty => new ResourceAttributesKeysRuleArgs();
    }
}
