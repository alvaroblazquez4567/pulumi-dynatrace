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

    public sealed class BrowserMonitorScriptEventsEventClickArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the mouse button to be used for the click
        /// </summary>
        [Input("button", required: true)]
        public Input<int> Button { get; set; } = null!;

        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        [Input("target")]
        public Input<Inputs.BrowserMonitorScriptEventsEventClickTargetArgs>? Target { get; set; }

        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        [Input("validate")]
        public Input<Inputs.BrowserMonitorScriptEventsEventClickValidateArgs>? Validate { get; set; }

        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        [Input("wait")]
        public Input<Inputs.BrowserMonitorScriptEventsEventClickWaitArgs>? Wait { get; set; }

        public BrowserMonitorScriptEventsEventClickArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventClickArgs Empty => new BrowserMonitorScriptEventsEventClickArgs();
    }
}