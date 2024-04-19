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
    public sealed class AutomationWorkflowTriggerSchedule
    {
        /// <summary>
        /// Specifies whether a task should be skipped as a no operation or not
        /// </summary>
        public readonly bool? Active;
        /// <summary>
        /// Advanced restrictions for the schedule to trigger executions
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerScheduleFilterParameters? FilterParameters;
        /// <summary>
        /// Refers to a configured rule that determines at which days the schedule should be active. If not specified it implies that the schedule is valid every day
        /// </summary>
        public readonly string? Rule;
        /// <summary>
        /// A time zone the scheduled times to align with. If not specified it will be chosen automatically based on the location of the Dynatrace Server
        /// </summary>
        public readonly string? TimeZone;
        /// <summary>
        /// Detailed configuration about the timing constraints that trigger the execution
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerScheduleTrigger Trigger;

        [OutputConstructor]
        private AutomationWorkflowTriggerSchedule(
            bool? active,

            Outputs.AutomationWorkflowTriggerScheduleFilterParameters? filterParameters,

            string? rule,

            string? timeZone,

            Outputs.AutomationWorkflowTriggerScheduleTrigger trigger)
        {
            Active = active;
            FilterParameters = filterParameters;
            Rule = rule;
            TimeZone = timeZone;
            Trigger = trigger;
        }
    }
}
