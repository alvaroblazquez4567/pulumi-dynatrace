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
    public sealed class AlertingProfileEventTypeFilter
    {
        /// <summary>
        /// Configuration of a custom event filter. Filters custom events by title or description. If both specified, the AND logic applies
        /// </summary>
        public readonly ImmutableArray<Outputs.AlertingProfileEventTypeFilterCustomEventFilter> CustomEventFilters;
        /// <summary>
        /// Configuration of a custom event filter. Filters custom events by title or description. If both specified, the AND logic applies
        /// </summary>
        public readonly ImmutableArray<Outputs.AlertingProfileEventTypeFilterPredefinedEventFilter> PredefinedEventFilters;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private AlertingProfileEventTypeFilter(
            ImmutableArray<Outputs.AlertingProfileEventTypeFilterCustomEventFilter> customEventFilters,

            ImmutableArray<Outputs.AlertingProfileEventTypeFilterPredefinedEventFilter> predefinedEventFilters,

            string? unknowns)
        {
            CustomEventFilters = customEventFilters;
            PredefinedEventFilters = predefinedEventFilters;
            Unknowns = unknowns;
        }
    }
}
