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

    public sealed class WebApplicationUserActionNamingSettingsXhrActionNamingRulesArgs : global::Pulumi.ResourceArgs
    {
        [Input("rules", required: true)]
        private InputList<Inputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesRuleArgs>? _rules;

        /// <summary>
        /// Java script injection rule
        /// </summary>
        public InputList<Inputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesRuleArgs>());
            set => _rules = value;
        }

        public WebApplicationUserActionNamingSettingsXhrActionNamingRulesArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsXhrActionNamingRulesArgs Empty => new WebApplicationUserActionNamingSettingsXhrActionNamingRulesArgs();
    }
}