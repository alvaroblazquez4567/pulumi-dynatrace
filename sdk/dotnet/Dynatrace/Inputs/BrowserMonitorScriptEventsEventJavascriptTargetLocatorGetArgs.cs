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

    public sealed class BrowserMonitorScriptEventsEventJavascriptTargetLocatorGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptTargetLocatorLocatorGetArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptTargetLocatorLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventJavascriptTargetLocatorLocatorGetArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventJavascriptTargetLocatorGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventJavascriptTargetLocatorGetArgs Empty => new BrowserMonitorScriptEventsEventJavascriptTargetLocatorGetArgs();
    }
}
