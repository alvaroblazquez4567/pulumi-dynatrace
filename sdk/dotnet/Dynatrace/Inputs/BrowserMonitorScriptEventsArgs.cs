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

    public sealed class BrowserMonitorScriptEventsArgs : global::Pulumi.ResourceArgs
    {
        [Input("events")]
        private InputList<Inputs.BrowserMonitorScriptEventsEventArgs>? _events;

        /// <summary>
        /// An event
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventArgs> Events
        {
            get => _events ?? (_events = new InputList<Inputs.BrowserMonitorScriptEventsEventArgs>());
            set => _events = value;
        }

        public BrowserMonitorScriptEventsArgs()
        {
        }
        public static new BrowserMonitorScriptEventsArgs Empty => new BrowserMonitorScriptEventsArgs();
    }
}
