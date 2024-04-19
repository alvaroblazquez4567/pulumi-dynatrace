// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class BrowserMonitorScriptEventsEventTap
    {
        /// <summary>
        /// the mouse button to be used for the click
        /// </summary>
        public readonly int Button;
        /// <summary>
        /// The tab on which the page should open
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventTapTarget? Target;
        /// <summary>
        /// The validation rules for the event—helps you verify that your browser monitor loads the expected page content or page element
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventTapValidate? Validate;
        /// <summary>
        /// The wait condition for the event—defines how long Dynatrace should wait before the next action is executed
        /// </summary>
        public readonly Outputs.BrowserMonitorScriptEventsEventTapWait? Wait;

        [OutputConstructor]
        private BrowserMonitorScriptEventsEventTap(
            int button,

            Outputs.BrowserMonitorScriptEventsEventTapTarget? target,

            Outputs.BrowserMonitorScriptEventsEventTapValidate? validate,

            Outputs.BrowserMonitorScriptEventsEventTapWait? wait)
        {
            Button = button;
            Target = target;
            Validate = validate;
            Wait = wait;
        }
    }
}
