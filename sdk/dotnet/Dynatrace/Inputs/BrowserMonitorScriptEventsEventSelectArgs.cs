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

    public sealed class BrowserMonitorScriptEventsEventSelectArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The options to be selected
        /// </summary>
        [Input("selections", required: true)]
        public Input<Inputs.BrowserMonitorScriptEventsEventSelectSelectionsArgs> Selections { get; set; } = null!;

        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        [Input("target")]
        public Input<Inputs.BrowserMonitorScriptEventsEventSelectTargetArgs>? Target { get; set; }

        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        [Input("validate")]
        public Input<Inputs.BrowserMonitorScriptEventsEventSelectValidateArgs>? Validate { get; set; }

        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        [Input("wait")]
        public Input<Inputs.BrowserMonitorScriptEventsEventSelectWaitArgs>? Wait { get; set; }

        public BrowserMonitorScriptEventsEventSelectArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventSelectArgs Empty => new BrowserMonitorScriptEventsEventSelectArgs();
    }
}
