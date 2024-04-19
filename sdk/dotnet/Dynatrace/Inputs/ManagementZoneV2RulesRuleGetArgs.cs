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

    public sealed class ManagementZoneV2RulesRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("attributeRule")]
        public Input<Inputs.ManagementZoneV2RulesRuleAttributeRuleGetArgs>? AttributeRule { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("dimensionRule")]
        public Input<Inputs.ManagementZoneV2RulesRuleDimensionRuleGetArgs>? DimensionRule { get; set; }

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
        /// Possible Values: `DIMENSION`, `ME`, `SELECTOR`
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ManagementZoneV2RulesRuleGetArgs()
        {
        }
        public static new ManagementZoneV2RulesRuleGetArgs Empty => new ManagementZoneV2RulesRuleGetArgs();
    }
}
