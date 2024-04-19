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

    public sealed class AlertingProfileEventTypeFilterGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("customEventFilters")]
        private InputList<Inputs.AlertingProfileEventTypeFilterCustomEventFilterGetArgs>? _customEventFilters;

        /// <summary>
        /// Configuration of a custom event filter. Filters custom events by title or description. If both specified, the AND logic applies
        /// </summary>
        public InputList<Inputs.AlertingProfileEventTypeFilterCustomEventFilterGetArgs> CustomEventFilters
        {
            get => _customEventFilters ?? (_customEventFilters = new InputList<Inputs.AlertingProfileEventTypeFilterCustomEventFilterGetArgs>());
            set => _customEventFilters = value;
        }

        [Input("predefinedEventFilters")]
        private InputList<Inputs.AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs>? _predefinedEventFilters;

        /// <summary>
        /// Configuration of a custom event filter. Filters custom events by title or description. If both specified, the AND logic applies
        /// </summary>
        public InputList<Inputs.AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs> PredefinedEventFilters
        {
            get => _predefinedEventFilters ?? (_predefinedEventFilters = new InputList<Inputs.AlertingProfileEventTypeFilterPredefinedEventFilterGetArgs>());
            set => _predefinedEventFilters = value;
        }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AlertingProfileEventTypeFilterGetArgs()
        {
        }
        public static new AlertingProfileEventTypeFilterGetArgs Empty => new AlertingProfileEventTypeFilterGetArgs();
    }
}
