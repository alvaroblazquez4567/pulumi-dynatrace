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

    public sealed class BrowserMonitorScriptEventsEventGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Properties specified for a click event
        /// </summary>
        [Input("click")]
        public Input<Inputs.BrowserMonitorScriptEventsEventClickGetArgs>? Click { get; set; }

        /// <summary>
        /// A request cookie
        /// </summary>
        [Input("cookie")]
        public Input<Inputs.BrowserMonitorScriptEventsEventCookieGetArgs>? Cookie { get; set; }

        /// <summary>
        /// A short description of the event to appear in the UI
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Properties specified for a javascript event
        /// </summary>
        [Input("javascript")]
        public Input<Inputs.BrowserMonitorScriptEventsEventJavascriptGetArgs>? Javascript { get; set; }

        /// <summary>
        /// Properties specified for a key strokes event
        /// </summary>
        [Input("keystrokes")]
        public Input<Inputs.BrowserMonitorScriptEventsEventKeystrokesGetArgs>? Keystrokes { get; set; }

        /// <summary>
        /// Properties specified for a navigation event
        /// </summary>
        [Input("navigate")]
        public Input<Inputs.BrowserMonitorScriptEventsEventNavigateGetArgs>? Navigate { get; set; }

        /// <summary>
        /// Properties specified for a key strokes event.
        /// </summary>
        [Input("select")]
        public Input<Inputs.BrowserMonitorScriptEventsEventSelectGetArgs>? Select { get; set; }

        /// <summary>
        /// Properties specified for a tap event
        /// </summary>
        [Input("tap")]
        public Input<Inputs.BrowserMonitorScriptEventsEventTapGetArgs>? Tap { get; set; }

        public BrowserMonitorScriptEventsEventGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventGetArgs Empty => new BrowserMonitorScriptEventsEventGetArgs();
    }
}
