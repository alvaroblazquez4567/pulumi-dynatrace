// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class WebApplicationUserActionNamingSettingsXhrActionNamingRulesRule
    {
        /// <summary>
        /// Defines the conditions when the naming rule should apply
        /// </summary>
        public readonly Outputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesRuleConditions? Conditions;
        /// <summary>
        /// Naming pattern. Use Curly brackets `{}` to select placeholders
        /// </summary>
        public readonly string Template;
        /// <summary>
        /// If set to `true` the conditions will be connected by logical OR instead of logical AND
        /// </summary>
        public readonly bool? UseOrConditions;

        [OutputConstructor]
        private WebApplicationUserActionNamingSettingsXhrActionNamingRulesRule(
            Outputs.WebApplicationUserActionNamingSettingsXhrActionNamingRulesRuleConditions? conditions,

            string template,

            bool? useOrConditions)
        {
            Conditions = conditions;
            Template = template;
            UseOrConditions = useOrConditions;
        }
    }
}
