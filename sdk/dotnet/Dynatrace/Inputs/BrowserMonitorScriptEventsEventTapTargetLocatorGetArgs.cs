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

    public sealed class BrowserMonitorScriptEventsEventTapTargetLocatorGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventTapTargetLocatorLocatorGetArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventTapTargetLocatorLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventTapTargetLocatorLocatorGetArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventTapTargetLocatorGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventTapTargetLocatorGetArgs Empty => new BrowserMonitorScriptEventsEventTapTargetLocatorGetArgs();
    }
}
