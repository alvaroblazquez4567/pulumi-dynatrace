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

    public sealed class ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditions", required: true)]
        private InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionGetArgs>? _conditions;

        /// <summary>
        /// Attribute conditions
        /// </summary>
        public InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsConditionGetArgs>());
            set => _conditions = value;
        }

        public ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsGetArgs()
        {
        }
        public static new ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsGetArgs Empty => new ManagementZoneV2RulesRuleAttributeRuleAttributeConditionsGetArgs();
    }
}
