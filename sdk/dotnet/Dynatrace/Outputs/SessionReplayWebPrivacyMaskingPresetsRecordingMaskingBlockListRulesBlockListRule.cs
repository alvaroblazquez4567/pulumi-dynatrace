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
    public sealed class SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesBlockListRule
    {
        /// <summary>
        /// Attribute masking can be applied to web applications that store data within attributes, typically data-NAME attributes in HTML5. When you define attributes, their values are masked while recording but not removed.
        /// </summary>
        public readonly string? AttributeExpression;
        /// <summary>
        /// Content masking can be applied to webpages where personal data is displayed. When content masking is applied to parent elements, all child elements are masked by default.
        /// </summary>
        public readonly string? CssExpression;
        /// <summary>
        /// Hide user interactions with these elements, including clicks that expand elements, highlighting that results from hovering a cursor over an option, and selection of specific form options.
        /// </summary>
        public readonly bool? HideUserInteraction;
        /// <summary>
        /// Possible Values: `ATTRIBUTE`, `ELEMENT`
        /// </summary>
        public readonly string Target;

        [OutputConstructor]
        private SessionReplayWebPrivacyMaskingPresetsRecordingMaskingBlockListRulesBlockListRule(
            string? attributeExpression,

            string? cssExpression,

            bool? hideUserInteraction,

            string target)
        {
            AttributeExpression = attributeExpression;
            CssExpression = cssExpression;
            HideUserInteraction = hideUserInteraction;
            Target = target;
        }
    }
}