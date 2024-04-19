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

    public sealed class GenericTypesRulesRuleAttributesAttributeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The human readable attribute name for this extraction rule. Leave blank to use the key as the display name.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The attribute key is the unique name of the attribute.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Pattern for specifying the value for the extracted attribute. Can be a static value, placeholders or a combination of both.
        /// </summary>
        [Input("pattern", required: true)]
        public Input<string> Pattern { get; set; } = null!;

        public GenericTypesRulesRuleAttributesAttributeGetArgs()
        {
        }
        public static new GenericTypesRulesRuleAttributesAttributeGetArgs Empty => new GenericTypesRulesRuleAttributesAttributeGetArgs();
    }
}
