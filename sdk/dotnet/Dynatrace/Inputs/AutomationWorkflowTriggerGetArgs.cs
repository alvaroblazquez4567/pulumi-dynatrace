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

    public sealed class AutomationWorkflowTriggerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified the workflow is getting triggered based on events
        /// </summary>
        [Input("event")]
        public Input<Inputs.AutomationWorkflowTriggerEventGetArgs>? Event { get; set; }

        /// <summary>
        /// If specified the workflow is getting triggered based on a schedule
        /// </summary>
        [Input("schedule")]
        public Input<Inputs.AutomationWorkflowTriggerScheduleGetArgs>? Schedule { get; set; }

        public AutomationWorkflowTriggerGetArgs()
        {
        }
        public static new AutomationWorkflowTriggerGetArgs Empty => new AutomationWorkflowTriggerGetArgs();
    }
}
