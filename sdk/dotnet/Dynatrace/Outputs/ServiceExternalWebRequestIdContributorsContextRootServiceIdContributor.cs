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
    public sealed class ServiceExternalWebRequestIdContributorsContextRootServiceIdContributor
    {
        /// <summary>
        /// Possible Values: `OriginalValue`, `OverrideValue`, `TransformValue`
        /// </summary>
        public readonly string ContributionType;
        /// <summary>
        /// How many segments should be taken.
        /// </summary>
        public readonly int? SegmentCount;
        /// <summary>
        /// Choose how to transform a value before it contributes to the Service Id. Note that all of the Transformations are always applied. Transformations are applied in the order they are specified, and the output of the previous transformation is the input for the next one. The resulting value contributes to the Service Id and can be found on the **Service overview page** under **Properties and tags**.
        /// </summary>
        public readonly Outputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformations? Transformations;
        /// <summary>
        /// The value to be used instead of the detected value.
        /// </summary>
        public readonly Outputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorValueOverride? ValueOverride;

        [OutputConstructor]
        private ServiceExternalWebRequestIdContributorsContextRootServiceIdContributor(
            string contributionType,

            int? segmentCount,

            Outputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorTransformations? transformations,

            Outputs.ServiceExternalWebRequestIdContributorsContextRootServiceIdContributorValueOverride? valueOverride)
        {
            ContributionType = contributionType;
            SegmentCount = segmentCount;
            Transformations = transformations;
            ValueOverride = valueOverride;
        }
    }
}
