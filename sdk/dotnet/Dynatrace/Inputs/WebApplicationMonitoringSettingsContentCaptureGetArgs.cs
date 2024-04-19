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

    public sealed class WebApplicationMonitoringSettingsContentCaptureGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// JavaScript errors monitoring enabled/disabled
        /// </summary>
        [Input("javascriptErrors")]
        public Input<bool>? JavascriptErrors { get; set; }

        /// <summary>
        /// Settings for resource timings capture
        /// </summary>
        [Input("resourceTimingSettings")]
        public Input<Inputs.WebApplicationMonitoringSettingsContentCaptureResourceTimingSettingsGetArgs>? ResourceTimingSettings { get; set; }

        /// <summary>
        /// Settings for timed action capture
        /// </summary>
        [Input("timeoutSettings")]
        public Input<Inputs.WebApplicationMonitoringSettingsContentCaptureTimeoutSettingsGetArgs>? TimeoutSettings { get; set; }

        /// <summary>
        /// Visually complete and Speed index support enabled/disabled
        /// </summary>
        [Input("visuallyCompleteAndSpeedIndex")]
        public Input<bool>? VisuallyCompleteAndSpeedIndex { get; set; }

        /// <summary>
        /// Settings for VisuallyComplete
        /// </summary>
        [Input("visuallyCompleteSettings")]
        public Input<Inputs.WebApplicationMonitoringSettingsContentCaptureVisuallyCompleteSettingsGetArgs>? VisuallyCompleteSettings { get; set; }

        public WebApplicationMonitoringSettingsContentCaptureGetArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsContentCaptureGetArgs Empty => new WebApplicationMonitoringSettingsContentCaptureGetArgs();
    }
}
