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

    public sealed class MaintenanceScheduleDailyRecurrenceRecurrenceRangeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end date of the recurrence range in YYYY-MM-DD format
        /// </summary>
        [Input("endDate", required: true)]
        public Input<string> EndDate { get; set; } = null!;

        /// <summary>
        /// The start date of the recurrence range in YYYY-MM-DD format
        /// </summary>
        [Input("startDate", required: true)]
        public Input<string> StartDate { get; set; } = null!;

        public MaintenanceScheduleDailyRecurrenceRecurrenceRangeGetArgs()
        {
        }
        public static new MaintenanceScheduleDailyRecurrenceRecurrenceRangeGetArgs Empty => new MaintenanceScheduleDailyRecurrenceRecurrenceRangeGetArgs();
    }
}