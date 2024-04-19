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

    public sealed class ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs : global::Pulumi.ResourceArgs
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
        /// no documentation available
        /// </summary>
        [Input("suffix")]
        public Input<string>? Suffix { get; set; }

        /// <summary>
        /// Possible Values: `AFTER`, `BEFORE`, `BETWEEN`, `REMOVE_CREDIT_CARDS`, `REMOVE_IBANS`, `REMOVE_IPS`, `REMOVE_NUMBERS`, `REPLACE_BETWEEN`, `SPLIT_SELECT`, `TAKE_SEGMENTS`
        /// </summary>
        [Input("transformationType", required: true)]
        public Input<string> TransformationType { get; set; } = null!;

        public ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs()
        {
        }
        public static new ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs Empty => new ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs();
    }
}
