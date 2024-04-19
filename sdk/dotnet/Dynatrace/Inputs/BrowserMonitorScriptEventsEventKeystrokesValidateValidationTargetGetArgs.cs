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

    public sealed class BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("locators")]
        private InputList<Inputs.BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetLocatorGetArgs>? _locators;

        /// <summary>
        /// The list of locators identifying the desired element
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetLocatorGetArgs> Locators
        {
            get => _locators ?? (_locators = new InputList<Inputs.BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetLocatorGetArgs>());
            set => _locators = value;
        }

        /// <summary>
        /// The tab of the target
        /// </summary>
        [Input("window")]
        public Input<string>? Window { get; set; }

        public BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetGetArgs Empty => new BrowserMonitorScriptEventsEventKeystrokesValidateValidationTargetGetArgs();
    }
}
