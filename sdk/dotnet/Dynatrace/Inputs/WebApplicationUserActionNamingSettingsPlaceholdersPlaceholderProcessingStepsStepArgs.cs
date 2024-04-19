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

    public sealed class WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If set to `true`: Returns the input if `patternBefore` or `patternAfter` cannot be found and the `type` is `SUBSTRING`. Returns the input if `regularExpression` doesn't match and `type` is `EXTRACT_BY_REGULAR_EXPRESSION`.
        /// </summary>
        [Input("fallbackToInput")]
        public Input<bool>? FallbackToInput { get; set; }

        [Input("patternAfter")]
        public Input<string>? PatternAfter { get; set; }

        [Input("patternAfterSearchType")]
        public Input<string>? PatternAfterSearchType { get; set; }

        [Input("patternBefore")]
        public Input<string>? PatternBefore { get; set; }

        [Input("patternBeforeSearchType")]
        public Input<string>? PatternBeforeSearchType { get; set; }

        [Input("patternToReplace")]
        public Input<string>? PatternToReplace { get; set; }

        [Input("regularExpression")]
        public Input<string>? RegularExpression { get; set; }

        [Input("replacement")]
        public Input<string>? Replacement { get; set; }

        /// <summary>
        /// The type of the action. Possible values are `Custom`, `Load` and `Xhr`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepArgs()
        {
        }
        public static new WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepArgs Empty => new WebApplicationUserActionNamingSettingsPlaceholdersPlaceholderProcessingStepsStepArgs();
    }
}
