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

    public sealed class AutotagRulesRulesRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("attributeRule")]
        public Input<Inputs.AutotagRulesRulesRuleAttributeRuleArgs>? AttributeRule { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// The documentation of the entity selector can be found [here](https://dt-url.net/apientityselector).
        /// </summary>
        [Input("entitySelector")]
        public Input<string>? EntitySelector { get; set; }

        /// <summary>
        /// Possible Values: `ME`, `SELECTOR`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Type '{' for placeholder suggestions
        /// </summary>
        [Input("valueFormat")]
        public Input<string>? ValueFormat { get; set; }

        /// <summary>
        /// Possible Values: `Leavetextas_is`, `Tolowercase`, `Touppercase`
        /// </summary>
        [Input("valueNormalization", required: true)]
        public Input<string> ValueNormalization { get; set; } = null!;

        public AutotagRulesRulesRuleArgs()
        {
        }
        public static new AutotagRulesRulesRuleArgs Empty => new AutotagRulesRulesRuleArgs();
    }
}
