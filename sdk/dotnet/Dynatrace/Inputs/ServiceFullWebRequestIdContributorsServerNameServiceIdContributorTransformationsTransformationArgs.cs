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

    public sealed class ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// include hexadecimal numbers
        /// </summary>
        [Input("includeHexNumbers")]
        public Input<bool>? IncludeHexNumbers { get; set; }

        /// <summary>
        /// min digit count
        /// </summary>
        [Input("minDigitCount")]
        public Input<int>? MinDigitCount { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        /// <summary>
        /// replacement
        /// </summary>
        [Input("replacementValue")]
        public Input<string>? ReplacementValue { get; set; }

        /// <summary>
        /// How many segments should be taken.
        /// </summary>
        [Input("segmentCount")]
        public Input<int>? SegmentCount { get; set; }

        /// <summary>
        /// select index
        /// </summary>
        [Input("selectIndex")]
        public Input<int>? SelectIndex { get; set; }

        /// <summary>
        /// split by
        /// </summary>
        [Input("splitDelimiter")]
        public Input<string>? SplitDelimiter { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("suffix")]
        public Input<string>? Suffix { get; set; }

        /// <summary>
        /// take from end
        /// </summary>
        [Input("takeFromEnd")]
        public Input<bool>? TakeFromEnd { get; set; }

        /// <summary>
        /// Possible Values: `AFTER`, `BEFORE`, `BETWEEN`, `REMOVE_CREDIT_CARDS`, `REMOVE_IBANS`, `REMOVE_IPS`, `REMOVE_NUMBERS`, `REPLACE_BETWEEN`, `SPLIT_SELECT`, `TAKE_SEGMENTS`
        /// </summary>
        [Input("transformationType", required: true)]
        public Input<string> TransformationType { get; set; } = null!;

        public ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs()
        {
        }
        public static new ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs Empty => new ServiceFullWebRequestIdContributorsServerNameServiceIdContributorTransformationsTransformationArgs();
    }
}