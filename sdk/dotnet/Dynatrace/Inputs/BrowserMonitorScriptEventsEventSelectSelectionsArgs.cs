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

    public sealed class BrowserMonitorScriptEventsEventSelectSelectionsArgs : global::Pulumi.ResourceArgs
    {
        [Input("options", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs>? _options;

        /// <summary>
        /// The option to be selected
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs> Options
        {
            get => _options ?? (_options = new InputList<Inputs.BrowserMonitorScriptEventsEventSelectSelectionsOptionArgs>());
            set => _options = value;
        }

        public BrowserMonitorScriptEventsEventSelectSelectionsArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventSelectSelectionsArgs Empty => new BrowserMonitorScriptEventsEventSelectSelectionsArgs();
    }
}