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

    public sealed class AutotagV2RulesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.AutotagV2RulesRuleGetArgs>? _rules;
        public InputList<Inputs.AutotagV2RulesRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.AutotagV2RulesRuleGetArgs>());
            set => _rules = value;
        }

        public AutotagV2RulesGetArgs()
        {
        }
        public static new AutotagV2RulesGetArgs Empty => new AutotagV2RulesGetArgs();
    }
}
