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

    public sealed class AutotagRuleConditionBitnessArgs : global::Pulumi.ResourceArgs
    {
        [Input("negate")]
        public Input<bool>? Negate { get; set; }

        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        public AutotagRuleConditionBitnessArgs()
        {
        }
        public static new AutotagRuleConditionBitnessArgs Empty => new AutotagRuleConditionBitnessArgs();
    }
}
