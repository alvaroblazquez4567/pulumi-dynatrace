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

    public sealed class AutomationWorkflowTriggerEventConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Contains trigger configuration based on Davis Events. Either `davis_event`, `davis_problem`, `davis_event` or `config` need to set
        /// </summary>
        [Input("davisEvent")]
        public Input<Inputs.AutomationWorkflowTriggerEventConfigDavisEventGetArgs>? DavisEvent { get; set; }

        /// <summary>
        /// Contains trigger configuration based on Davis Problems. Either `davis_event`, `davis_problem`, `davis_event` or `config` need to set
        /// </summary>
        [Input("davisProblem")]
        public Input<Inputs.AutomationWorkflowTriggerEventConfigDavisProblemGetArgs>? DavisProblem { get; set; }

        /// <summary>
        /// If specified the workflow is getting triggered based on events
        /// </summary>
        [Input("event")]
        public Input<Inputs.AutomationWorkflowTriggerEventConfigEventGetArgs>? Event { get; set; }

        /// <summary>
        /// The type of the trigger configuration to expect within attribute `value`. Only required if `config` is set. Must not be set if `davis_event`, `davis_problem` or `event` are present
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Contains JSON encoded trigger configuration if the trigger type is neither `davis_event`, `davis_problem` or `event`. It requires the attribute `type` to be set in combination
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public AutomationWorkflowTriggerEventConfigGetArgs()
        {
        }
        public static new AutomationWorkflowTriggerEventConfigGetArgs Empty => new AutomationWorkflowTriggerEventConfigGetArgs();
    }
}
