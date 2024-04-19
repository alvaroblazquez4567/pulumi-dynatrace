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

    public sealed class AutomationWorkflowTriggerEventConfigDavisProblemCategoryGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("availability")]
        public Input<bool>? Availability { get; set; }

        /// <summary>
        /// A custom condition that needs to be met for the current task to get executed
        /// </summary>
        [Input("custom")]
        public Input<bool>? Custom { get; set; }

        [Input("error")]
        public Input<bool>? Error { get; set; }

        [Input("info")]
        public Input<bool>? Info { get; set; }

        [Input("monitoringUnavailable")]
        public Input<bool>? MonitoringUnavailable { get; set; }

        [Input("resource")]
        public Input<bool>? Resource { get; set; }

        [Input("slowdown")]
        public Input<bool>? Slowdown { get; set; }

        public AutomationWorkflowTriggerEventConfigDavisProblemCategoryGetArgs()
        {
        }
        public static new AutomationWorkflowTriggerEventConfigDavisProblemCategoryGetArgs Empty => new AutomationWorkflowTriggerEventConfigDavisProblemCategoryGetArgs();
    }
}
