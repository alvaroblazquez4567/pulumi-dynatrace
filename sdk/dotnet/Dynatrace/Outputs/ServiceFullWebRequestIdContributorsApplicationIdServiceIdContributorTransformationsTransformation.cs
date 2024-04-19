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
    public sealed class ServiceFullWebRequestIdContributorsApplicationIdServiceIdContributorTransformationsTransformation
    {
        /// <summary>
        /// include hexadecimal numbers
        /// </summary>
        public readonly bool? IncludeHexNumbers;
        /// <summary>
        /// min digit count
        /// </summary>
        public readonly int? MinDigitCount;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string? Prefix;
        /// <summary>
        /// replacement
        /// </summary>
        public readonly string? ReplacementValue;
        /// <summary>
        /// How many segments should be taken.
        /// </summary>
        public readonly int? SegmentCount;
        /// <summary>
        /// select index
        /// </summary>
        public readonly int? SelectIndex;
        /// <summary>
        /// split by
        /// </summary>
        public readonly string? SplitDelimiter;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly string? Suffix;
        /// <summary>
        /// take from end
        /// </summary>
        public readonly bool? TakeFromEnd;
        /// <summary>
        /// Possible Values: `AFTER`, `BEFORE`, `BETWEEN`, `REMOVE_CREDIT_CARDS`, `REMOVE_IBANS`, `REMOVE_IPS`, `REMOVE_NUMBERS`, `REPLACE_BETWEEN`, `SPLIT_SELECT`, `TAKE_SEGMENTS`
        /// </summary>
        public readonly string TransformationType;

        [OutputConstructor]
        private ServiceFullWebRequestIdContributorsApplicationIdServiceIdContributorTransformationsTransformation(
            bool? includeHexNumbers,

            int? minDigitCount,

            string? prefix,

            string? replacementValue,

            int? segmentCount,

            int? selectIndex,

            string? splitDelimiter,

            string? suffix,

            bool? takeFromEnd,

            string transformationType)
        {
            IncludeHexNumbers = includeHexNumbers;
            MinDigitCount = minDigitCount;
            Prefix = prefix;
            ReplacementValue = replacementValue;
            SegmentCount = segmentCount;
            SelectIndex = selectIndex;
            SplitDelimiter = splitDelimiter;
            Suffix = suffix;
            TakeFromEnd = takeFromEnd;
            TransformationType = transformationType;
        }
    }
}
