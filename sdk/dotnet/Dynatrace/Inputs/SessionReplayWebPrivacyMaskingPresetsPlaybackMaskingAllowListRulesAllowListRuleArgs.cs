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

    public sealed class SessionReplayWebPrivacyMaskingPresetsPlaybackMaskingAllowListRulesAllowListRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attribute masking can be applied to web applications that store data within attributes, typically data-NAME attributes in HTML5. When you define attributes, their values are masked while recording but not removed.
        /// </summary>
        [Input("attributeExpression")]
        public Input<string>? AttributeExpression { get; set; }

        /// <summary>
        /// Content masking can be applied to webpages where personal data is displayed. When content masking is applied to parent elements, all child elements are masked by default.
        /// </summary>
        [Input("cssExpression")]
        public Input<string>? CssExpression { get; set; }

        /// <summary>
        /// Possible Values: `ATTRIBUTE`, `ELEMENT`
        /// </summary>
        [Input("target", required: true)]
        public Input<string> Target { get; set; } = null!;

        public SessionReplayWebPrivacyMaskingPresetsPlaybackMaskingAllowListRulesAllowListRuleArgs()
        {
        }
        public static new SessionReplayWebPrivacyMaskingPresetsPlaybackMaskingAllowListRulesAllowListRuleArgs Empty => new SessionReplayWebPrivacyMaskingPresetsPlaybackMaskingAllowListRulesAllowListRuleArgs();
    }
}