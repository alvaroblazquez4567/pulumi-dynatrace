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
    public sealed class RequestAttributeDataSourceValueProcessing
    {
        /// <summary>
        /// Preprocess by extracting a substring from the original value
        /// </summary>
        public readonly Outputs.RequestAttributeDataSourceValueProcessingExtractSubstring? ExtractSubstring;
        /// <summary>
        /// Split (preprocessed) string values at this separator
        /// </summary>
        public readonly string? SplitAt;
        /// <summary>
        /// Prune Whitespaces. Defaults to false
        /// </summary>
        public readonly bool? Trim;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// IBM integration bus label node name condition for which the value is captured
        /// </summary>
        public readonly Outputs.RequestAttributeDataSourceValueProcessingValueCondition? ValueCondition;
        /// <summary>
        /// Extract value from captured data per regex
        /// </summary>
        public readonly string? ValueExtractorRegex;

        [OutputConstructor]
        private RequestAttributeDataSourceValueProcessing(
            Outputs.RequestAttributeDataSourceValueProcessingExtractSubstring? extractSubstring,

            string? splitAt,

            bool? trim,

            string? unknowns,

            Outputs.RequestAttributeDataSourceValueProcessingValueCondition? valueCondition,

            string? valueExtractorRegex)
        {
            ExtractSubstring = extractSubstring;
            SplitAt = splitAt;
            Trim = trim;
            Unknowns = unknowns;
            ValueCondition = valueCondition;
            ValueExtractorRegex = valueExtractorRegex;
        }
    }
}
