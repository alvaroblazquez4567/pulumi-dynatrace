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

    public sealed class AutotagRuleConditionCustomProcessMetadataConditionKeyDynamicKeyArgs : global::Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AutotagRuleConditionCustomProcessMetadataConditionKeyDynamicKeyArgs()
        {
        }
        public static new AutotagRuleConditionCustomProcessMetadataConditionKeyDynamicKeyArgs Empty => new AutotagRuleConditionCustomProcessMetadataConditionKeyDynamicKeyArgs();
    }
}
