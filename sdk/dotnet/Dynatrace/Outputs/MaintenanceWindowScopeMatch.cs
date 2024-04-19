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
    public sealed class MaintenanceWindowScopeMatch
    {
        /// <summary>
        /// The ID of a management zone to which the matched entities must belong
        /// </summary>
        public readonly string? MzId;
        /// <summary>
        /// The logic that applies when several tags are specified: AND/OR.  If not set, the OR logic is used
        /// </summary>
        public readonly string? TagCombination;
        /// <summary>
        /// The tag you want to use for matching.  You can use custom tags from the UI, AWS tags, Cloud Foundry tags, OpenShift/Kubernetes, and tags based on environment variables
        /// </summary>
        public readonly ImmutableArray<Outputs.MaintenanceWindowScopeMatchTag> Tags;
        /// <summary>
        /// The type of the Dynatrace entities (for example, hosts or services) you want to pick up by matching
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private MaintenanceWindowScopeMatch(
            string? mzId,

            string? tagCombination,

            ImmutableArray<Outputs.MaintenanceWindowScopeMatchTag> tags,

            string? type,

            string? unknowns)
        {
            MzId = mzId;
            TagCombination = tagCombination;
            Tags = tags;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
