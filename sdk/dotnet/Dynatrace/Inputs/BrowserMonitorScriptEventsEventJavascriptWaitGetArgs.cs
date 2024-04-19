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

    public sealed class BrowserMonitorScriptEventsEventJavascriptWaitGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time to wait, in millisencods. The maximum allowed value is `60000`. Required for the type `time`, not applicable otherwise.
        /// </summary>
        [Input("milliseconds")]
        public Input<int>? Milliseconds { get; set; }

        /// <summary>
        /// he maximum amount of time to wait for a certain element to appear, in milliseconds—if exceeded, the action is marked as failed.
        /// The maximum allowed value is 60000. Required for the type `validation`, not applicable otherwise..
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        /// <summary>
        /// The element to wait for. Required for the `validation` type, not applicable otherwise.
        /// </summary>
        [Input("validation")]
        public Input<Inputs.BrowserMonitorScriptEventsEventJavascriptWaitValidationGetArgs>? Validation { get; set; }

        /// <summary>
        /// The time to wait before the next event is triggered. Possible values are `page_complete` (wait for the page to load completely), `network` (wait for background network activity to complete), `next_action` (wait for the next action), `time` (wait for a specified periodof time) and `validation` (wait for a specific element to appear)
        /// </summary>
        [Input("waitFor", required: true)]
        public Input<string> WaitFor { get; set; } = null!;

        public BrowserMonitorScriptEventsEventJavascriptWaitGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventJavascriptWaitGetArgs Empty => new BrowserMonitorScriptEventsEventJavascriptWaitGetArgs();
    }
}
