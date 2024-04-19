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

    public sealed class AlertingProfileRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Send a notification if a problem remains open longer than *X* minutes
        /// </summary>
        [Input("delayInMinutes", required: true)]
        public Input<int> DelayInMinutes { get; set; } = null!;

        /// <summary>
        /// The severity level to trigger the alert. Possible values are `AVAILABILITY`,	`CUSTOM_ALERT`,	`ERROR`,`MONITORING_UNAVAILABLE`,`PERFORMANCE` and `RESOURCE_CONTENTION`.
        /// </summary>
        [Input("severityLevel", required: true)]
        public Input<string> SeverityLevel { get; set; } = null!;

        [Input("tagFilters", required: true)]
        private InputList<Inputs.AlertingProfileRuleTagFilterGetArgs>? _tagFilters;

        /// <summary>
        /// Configuration of the tag filtering of the alerting profile
        /// </summary>
        public InputList<Inputs.AlertingProfileRuleTagFilterGetArgs> TagFilters
        {
            get => _tagFilters ?? (_tagFilters = new InputList<Inputs.AlertingProfileRuleTagFilterGetArgs>());
            set => _tagFilters = value;
        }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public AlertingProfileRuleGetArgs()
        {
        }
        public static new AlertingProfileRuleGetArgs Empty => new AlertingProfileRuleGetArgs();
    }
}
