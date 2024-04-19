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

    public sealed class WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsConditionArgs>? _conditions;

        /// <summary>
        /// Defines the conditions when the naming rule should apply
        /// </summary>
        public InputList<Inputs.WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsConditionArgs>());
            set => _conditions = value;
        }

        public WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsArgs Empty => new WebApplicationUserActionNamingSettingsLoadActionNamingRulesRuleConditionsArgs();
    }
}
