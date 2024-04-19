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
    public sealed class FailureDetectionRulesConditionsConditionPredicate
    {
        /// <summary>
        /// Case sensitive
        /// </summary>
        public readonly bool? CaseSensitive;
        /// <summary>
        /// Management zones
        /// </summary>
        public readonly ImmutableArray<string> ManagementZones;
        /// <summary>
        /// Predicate type
        /// </summary>
        public readonly string PredicateType;
        /// <summary>
        /// Service types
        /// </summary>
        public readonly ImmutableArray<string> ServiceTypes;
        /// <summary>
        /// Tag keys
        /// </summary>
        public readonly ImmutableArray<string> TagKeys;
        /// <summary>
        /// Tags (exact match)
        /// </summary>
        public readonly ImmutableArray<string> Tags;
        /// <summary>
        /// Names
        /// </summary>
        public readonly ImmutableArray<string> TextValues;

        [OutputConstructor]
        private FailureDetectionRulesConditionsConditionPredicate(
            bool? caseSensitive,

            ImmutableArray<string> managementZones,

            string predicateType,

            ImmutableArray<string> serviceTypes,

            ImmutableArray<string> tagKeys,

            ImmutableArray<string> tags,

            ImmutableArray<string> textValues)
        {
            CaseSensitive = caseSensitive;
            ManagementZones = managementZones;
            PredicateType = predicateType;
            ServiceTypes = serviceTypes;
            TagKeys = tagKeys;
            Tags = tags;
            TextValues = textValues;
        }
    }
}
