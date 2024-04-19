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

    public sealed class MaintenanceScheduleWeeklyRecurrenceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The day of the week for weekly maintenance, possible values: `FRIDAY`, `MONDAY`, `SATURDAY`, `SUNDAY`, `THURSDAY`, `TUESDAY`, `WEDNESDAY`
        /// </summary>
        [Input("dayOfWeek", required: true)]
        public Input<string> DayOfWeek { get; set; } = null!;

        /// <summary>
        /// The recurrence date range of the maintenance window
        /// </summary>
        [Input("recurrenceRange", required: true)]
        public Input<Inputs.MaintenanceScheduleWeeklyRecurrenceRecurrenceRangeGetArgs> RecurrenceRange { get; set; } = null!;

        /// <summary>
        /// The time window of the maintenance window
        /// </summary>
        [Input("timeWindow", required: true)]
        public Input<Inputs.MaintenanceScheduleWeeklyRecurrenceTimeWindowGetArgs> TimeWindow { get; set; } = null!;

        public MaintenanceScheduleWeeklyRecurrenceGetArgs()
        {
        }
        public static new MaintenanceScheduleWeeklyRecurrenceGetArgs Empty => new MaintenanceScheduleWeeklyRecurrenceGetArgs();
    }
}