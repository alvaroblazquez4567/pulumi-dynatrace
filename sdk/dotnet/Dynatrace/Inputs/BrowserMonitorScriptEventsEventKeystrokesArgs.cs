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

    public sealed class BrowserMonitorScriptEventsEventKeystrokesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Credentials for this event
        /// </summary>
        [Input("credential")]
        public Input<Inputs.BrowserMonitorScriptEventsEventKeystrokesCredentialArgs>? Credential { get; set; }

        /// <summary>
        /// Indicates whether the `textValue` is encrypted (`true`) or not (`false`). Must not be specified if `credentials` from the vault are being used
        /// </summary>
        [Input("masked")]
        public Input<bool>? Masked { get; set; }

        /// <summary>
        /// Defines whether to blur the text field when it loses focus.
        /// Set to `true` to trigger the blur the `textValue`
        /// </summary>
        [Input("simulateBlurEvent")]
        public Input<bool>? SimulateBlurEvent { get; set; }

        /// <summary>
        /// Simulates pressing the 'Return' key after simulating other keystrokes. For example, to submit a form or trigger a login.
        /// </summary>
        [Input("simulateReturnKey")]
        public Input<bool>? SimulateReturnKey { get; set; }

        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        [Input("target")]
        public Input<Inputs.BrowserMonitorScriptEventsEventKeystrokesTargetArgs>? Target { get; set; }

        /// <summary>
        /// The text to enter. Must not be specified if `credentials` from the vault are being used
        /// </summary>
        [Input("text")]
        public Input<string>? Text { get; set; }

        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        [Input("validate")]
        public Input<Inputs.BrowserMonitorScriptEventsEventKeystrokesValidateArgs>? Validate { get; set; }

        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        [Input("wait")]
        public Input<Inputs.BrowserMonitorScriptEventsEventKeystrokesWaitArgs>? Wait { get; set; }

        public BrowserMonitorScriptEventsEventKeystrokesArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventKeystrokesArgs Empty => new BrowserMonitorScriptEventsEventKeystrokesArgs();
    }
}
