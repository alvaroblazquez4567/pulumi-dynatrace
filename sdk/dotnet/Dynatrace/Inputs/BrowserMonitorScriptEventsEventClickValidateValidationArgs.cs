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

    public sealed class BrowserMonitorScriptEventsEventClickValidateValidationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The condition of the validation. `false` means the validation succeeds if the specified content/element is found. `true` means the validation fails if the specified content/element is found
        /// </summary>
        [Input("failIfFound")]
        public Input<bool>? FailIfFound { get; set; }

        /// <summary>
        /// The content to look for on the page.
        /// Regular expressions are allowed. In that case set `isRegex` as `true`. Required for `content_match`, optional for `element_match`.
        /// </summary>
        [Input("match")]
        public Input<string>? Match { get; set; }

        /// <summary>
        /// Defines whether `match` is plain text (`false`) or a regular expression (`true`)
        /// </summary>
        [Input("regex")]
        public Input<bool>? Regex { get; set; }

        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        [Input("target")]
        public Input<Inputs.BrowserMonitorScriptEventsEventClickValidateValidationTargetArgs>? Target { get; set; }

        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public BrowserMonitorScriptEventsEventClickValidateValidationArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventClickValidateValidationArgs Empty => new BrowserMonitorScriptEventsEventClickValidateValidationArgs();
    }
}
