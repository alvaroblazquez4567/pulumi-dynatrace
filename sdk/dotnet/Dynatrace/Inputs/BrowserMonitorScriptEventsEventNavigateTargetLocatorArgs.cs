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

    public sealed class BrowserMonitorScriptEventsEventNavigateTargetLocatorArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators", required: true)]
        private InputList<Inputs.BrowserMonitorScriptEventsEventNavigateTargetLocatorLocatorArgs>? _locators;

        /// <summary>
        /// A locator dentifyies the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventNavigateTargetLocatorLocatorArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventNavigateTargetLocatorLocatorArgs>());
            set => _locators = value;
        }

        public BrowserMonitorScriptEventsEventNavigateTargetLocatorArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventNavigateTargetLocatorArgs Empty => new BrowserMonitorScriptEventsEventNavigateTargetLocatorArgs();
    }
}
