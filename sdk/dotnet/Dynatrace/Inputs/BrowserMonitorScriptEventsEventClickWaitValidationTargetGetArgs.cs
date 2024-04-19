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

    public sealed class BrowserMonitorScriptEventsEventClickWaitValidationTargetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators")]
        private InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorGetArgs>? _locators;

        /// <summary>
        /// The list of locators identifying the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventClickWaitValidationTargetLocatorGetArgs>());
            set => _locators = value;
        }

        /// <summary>
        /// The tab of the target
        /// </summary>
        [Input("window")]
        public Input<string>? Window { get; set; }

        public BrowserMonitorScriptEventsEventClickWaitValidationTargetGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventClickWaitValidationTargetGetArgs Empty => new BrowserMonitorScriptEventsEventClickWaitValidationTargetGetArgs();
    }
}
