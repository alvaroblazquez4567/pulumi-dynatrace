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

    public sealed class WebApplicationMonitoringSettingsContentCaptureTimeoutSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines how deep temporary actions may cascade. 0 disables temporary actions completely. Recommended value if enabled is 3
        /// </summary>
        [Input("temporaryActionLimit", required: true)]
        public Input<int> TemporaryActionLimit { get; set; } = null!;

        /// <summary>
        /// The total timeout of all cascaded timeouts that should still be able to create a temporary action
        /// </summary>
        [Input("temporaryActionTotalTimeout", required: true)]
        public Input<int> TemporaryActionTotalTimeout { get; set; } = null!;

        /// <summary>
        /// Timed action support enabled/disabled.
        /// </summary>
        [Input("timedActionSupport")]
        public Input<bool>? TimedActionSupport { get; set; }

        public WebApplicationMonitoringSettingsContentCaptureTimeoutSettingsArgs()
        {
        }
        public static new WebApplicationMonitoringSettingsContentCaptureTimeoutSettingsArgs Empty => new WebApplicationMonitoringSettingsContentCaptureTimeoutSettingsArgs();
    }
}
