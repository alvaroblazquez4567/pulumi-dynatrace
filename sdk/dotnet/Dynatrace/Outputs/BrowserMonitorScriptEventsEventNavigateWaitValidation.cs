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
    public sealed class BrowserMonitorScriptEventsEventNavigateWaitValidation
    {
        /// <summary>
        /// The condition of the validation. `false` means the validation succeeds if the specified content/element is found. `true` means the validation fails if the specified content/element is found
        /// </summary>
        public readonly bool? FailIfFound;
        /// <summary>
        /// The content to look for on the page.
        /// Regular expressions are allowed. In that case set `isRegex` as `true`. Required for `content_match`, optional for `element_match`.
        /// </summary>
        public readonly string? Match;
        /// <summary>
        /// Defines whether `match` is plain text (`false`) or a regular expression (`true`)
        /// </summary>
        public readonly bool? Regex;
        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventNavigateWaitValidationTarget? Target;
        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BrowserMonitorScriptEventsEventNavigateWaitValidation(
            bool? failIfFound,

            string? match,

            bool? regex,

            Outputs.BrowserMonitorScriptEventsEventNavigateWaitValidationTarget? target,

            string type)
        {
            FailIfFound = failIfFound;
            Match = match;
            Regex = regex;
            Target = target;
            Type = type;
        }
    }
}
