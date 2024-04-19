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
    public sealed class ApplicationErrorRulesHttpErrorsRule
    {
        /// <summary>
        /// Capture (`true`) or ignore (`false`) the error
        /// </summary>
        public readonly bool? Capture;
        /// <summary>
        /// If `true`, match by errors that have CSP Rule violations
        /// </summary>
        public readonly bool? ConsiderBlockedRequests;
        /// <summary>
        /// Include (`true`) or exclude (`false`) the error in Davis AI [problem detection and analysis](https://dt-url.net/a963kd2)
        /// </summary>
        public readonly bool? ConsiderForAi;
        /// <summary>
        /// If `true`, match by errors that have unknown HTTP status code
        /// </summary>
        public readonly bool? ConsiderUnknownErrorCode;
        /// <summary>
        /// The HTTP status code or status code range to match by.
        /// </summary>
        public readonly string? ErrorCodes;
        public readonly string? Filter;
        public readonly bool? FilterByUrl;
        /// <summary>
        /// Include (`true`) or exclude (`false`) the error in Apdex calculation
        /// </summary>
        public readonly bool? ImpactApdex;
        public readonly string? Url;

        [OutputConstructor]
        private ApplicationErrorRulesHttpErrorsRule(
            bool? capture,

            bool? considerBlockedRequests,

            bool? considerForAi,

            bool? considerUnknownErrorCode,

            string? errorCodes,

            string? filter,

            bool? filterByUrl,

            bool? impactApdex,

            string? url)
        {
            Capture = capture;
            ConsiderBlockedRequests = considerBlockedRequests;
            ConsiderForAi = considerForAi;
            ConsiderUnknownErrorCode = considerUnknownErrorCode;
            ErrorCodes = errorCodes;
            Filter = filter;
            FilterByUrl = filterByUrl;
            ImpactApdex = impactApdex;
            Url = url;
        }
    }
}
