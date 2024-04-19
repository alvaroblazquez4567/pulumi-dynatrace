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
    public sealed class AutomationWorkflowTriggerScheduleTrigger
    {
        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame - specifying the end time on any valid day in 24h format (e.g. 14:22:44). Conflicts with `cron` and `time`. Required with `interval_minutes` and `between_start`
        /// </summary>
        public readonly string? BetweenEnd;
        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame - specifying the start time on any valid day in 24h format (e.g. 13:22:44). Conflicts with `cron` and `time`. Required with `interval_minutes` and `between_end`
        /// </summary>
        public readonly string? BetweenStart;
        /// <summary>
        /// Configures using cron syntax. Conflicts with `time`, `interval_minutes`, `between_start` and `between_end`
        /// </summary>
        public readonly string? Cron;
        /// <summary>
        /// Triggers the schedule every n minutes within a given time frame. Minimum: 1, Maximum: 720. Required with `between_start` and `between_end`. Conflicts with `cron` and `time`
        /// </summary>
        public readonly int? IntervalMinutes;
        /// <summary>
        /// Specifies a fixed time the schedule will trigger at in 24h format (e.g. `14:23:59`). Conflicts with `cron`, `interval_minutes`, `between_start` and `between_end`
        /// </summary>
        public readonly string? Time;

        [OutputConstructor]
        private AutomationWorkflowTriggerScheduleTrigger(
            string? betweenEnd,

            string? betweenStart,

            string? cron,

            int? intervalMinutes,

            string? time)
        {
            BetweenEnd = betweenEnd;
            BetweenStart = betweenStart;
            Cron = cron;
            IntervalMinutes = intervalMinutes;
            Time = time;
        }
    }
}
