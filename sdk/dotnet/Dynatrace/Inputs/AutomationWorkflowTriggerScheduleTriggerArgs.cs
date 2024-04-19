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

    public sealed class AutomationWorkflowTriggerScheduleTriggerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame - specifying the end time on any valid day in 24h format (e.g. 14:22:44). Conflicts with `cron` and `time`. Required with `interval_minutes` and `between_start`
        /// </summary>
        [Input("betweenEnd")]
        public Input<string>? BetweenEnd { get; set; }

        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame - specifying the start time on any valid day in 24h format (e.g. 13:22:44). Conflicts with `cron` and `time`. Required with `interval_minutes` and `between_end`
        /// </summary>
        [Input("betweenStart")]
        public Input<string>? BetweenStart { get; set; }

        /// <summary>
        /// Configures using cron syntax. Conflicts with `time`, `interval_minutes`, `between_start` and `between_end`
        /// </summary>
        [Input("cron")]
        public Input<string>? Cron { get; set; }

        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame. Minimum: 1, Maximum: 720. Required with `between_start` and `between_end`. Conflicts with `cron` and `time`
        /// </summary>
        [Input("intervalMinutes")]
        public Input<int>? IntervalMinutes { get; set; }

        /// <summary>
        /// Specifies a fixed time the schedule will trigger at in 24h format (e.g. `14:23:59`). Conflicts with `cron`, `interval_minutes`, `between_start` and `between_end`
        /// </summary>
        [Input("time")]
        public Input<string>? Time { get; set; }

        public AutomationWorkflowTriggerScheduleTriggerArgs()
        {
        }
        public static new AutomationWorkflowTriggerScheduleTriggerArgs Empty => new AutomationWorkflowTriggerScheduleTriggerArgs();
    }
}
