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

    public sealed class AutotagRulesRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.AutotagRulesRulesRuleArgs>? _rules;
        public InputList<Inputs.AutotagRulesRulesRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.AutotagRulesRulesRuleArgs>());
            set => _rules = value;
        }

        public AutotagRulesRulesArgs()
        {
        }
        public static new AutotagRulesRulesArgs Empty => new AutotagRulesRulesArgs();
    }
}
