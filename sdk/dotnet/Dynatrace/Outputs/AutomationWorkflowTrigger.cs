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
    public sealed class AutomationWorkflowTrigger
    {
        /// <summary>
        /// If specified the workflow is getting triggered based on events
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerEvent? Event;
        /// <summary>
        /// If specified the workflow is getting triggered based on a schedule
        /// </summary>
        public readonly Outputs.AutomationWorkflowTriggerSchedule? Schedule;

        [OutputConstructor]
        private AutomationWorkflowTrigger(
            Outputs.AutomationWorkflowTriggerEvent? @event,

            Outputs.AutomationWorkflowTriggerSchedule? schedule)
        {
            Event = @event;
            Schedule = schedule;
        }
    }
}
