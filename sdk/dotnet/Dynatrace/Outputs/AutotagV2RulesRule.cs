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
    public sealed class AutotagV2RulesRule
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.AutotagV2RulesRuleAttributeRule? AttributeRule;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// The documentation of the entity selector can be found [here](https://dt-url.net/apientityselector).
        /// </summary>
        public readonly string? EntitySelector;
        /// <summary>
        /// Possible Values: `ME`, `SELECTOR`
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Type '{' for placeholder suggestions
        /// </summary>
        public readonly string? ValueFormat;
        /// <summary>
        /// Possible Values: `Leavetextas_is`, `Tolowercase`, `Touppercase`
        /// </summary>
        public readonly string ValueNormalization;

        [OutputConstructor]
        private AutotagV2RulesRule(
            Outputs.AutotagV2RulesRuleAttributeRule? attributeRule,

            bool enabled,

            string? entitySelector,

            string type,

            string? valueFormat,

            string valueNormalization)
        {
            AttributeRule = attributeRule;
            Enabled = enabled;
            EntitySelector = entitySelector;
            Type = type;
            ValueFormat = valueFormat;
            ValueNormalization = valueNormalization;
        }
    }
}
