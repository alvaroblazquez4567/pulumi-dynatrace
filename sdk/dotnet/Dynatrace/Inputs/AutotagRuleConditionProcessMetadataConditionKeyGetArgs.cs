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

    public sealed class AutotagRuleConditionProcessMetadataConditionKeyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("attribute", required: true)]
        public Input<string> Attribute { get; set; } = null!;

        [Input("dynamicKey", required: true)]
        public Input<string> DynamicKey { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AutotagRuleConditionProcessMetadataConditionKeyGetArgs()
        {
        }
        public static new AutotagRuleConditionProcessMetadataConditionKeyGetArgs Empty => new AutotagRuleConditionProcessMetadataConditionKeyGetArgs();
    }
}
