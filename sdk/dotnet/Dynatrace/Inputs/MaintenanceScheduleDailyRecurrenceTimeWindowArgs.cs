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

    public sealed class MaintenanceScheduleDailyRecurrenceTimeWindowArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end time of the maintenance window validity period in hh:mm:ss format
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        /// <summary>
        /// The start time of the maintenance window validity period in hh:mm:ss format
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        /// <summary>
        /// The time zone of the start and end time. Default time zone is UTC. You can use either UTC offset `UTC+01:00` format or the IANA Time Zone Database format (for example, `Europe/Vienna`)
        /// </summary>
        [Input("timeZone", required: true)]
        public Input<string> TimeZone { get; set; } = null!;

        public MaintenanceScheduleDailyRecurrenceTimeWindowArgs()
        {
        }
        public static new MaintenanceScheduleDailyRecurrenceTimeWindowArgs Empty => new MaintenanceScheduleDailyRecurrenceTimeWindowArgs();
    }
}
