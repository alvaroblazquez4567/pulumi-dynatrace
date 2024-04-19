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

    public sealed class BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The value of the cookie. The following symbols are not allowed: `;`, `,`, `\` and `"`.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorGetArgs()
        {
        }
        public static new BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorGetArgs Empty => new BrowserMonitorScriptEventsEventSelectValidateValidationTargetLocatorLocatorGetArgs();
    }
}
