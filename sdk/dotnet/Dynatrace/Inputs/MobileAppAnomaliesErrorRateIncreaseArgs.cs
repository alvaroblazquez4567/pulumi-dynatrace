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

    public sealed class MobileAppAnomaliesErrorRateIncreaseArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `Auto`, `Fixed`
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// Alert if the percentage of user actions affected by reported errors exceeds **both** the absolute threshold and the relative threshold
        /// </summary>
        [Input("errorRateIncreaseAuto")]
        public Input<Inputs.MobileAppAnomaliesErrorRateIncreaseErrorRateIncreaseAutoArgs>? ErrorRateIncreaseAuto { get; set; }

        /// <summary>
        /// Alert if the custom reported error rate threshold is exceeded during any 5-minute period
        /// </summary>
        [Input("errorRateIncreaseFixed")]
        public Input<Inputs.MobileAppAnomaliesErrorRateIncreaseErrorRateIncreaseFixedArgs>? ErrorRateIncreaseFixed { get; set; }

        public MobileAppAnomaliesErrorRateIncreaseArgs()
        {
        }
        public static new MobileAppAnomaliesErrorRateIncreaseArgs Empty => new MobileAppAnomaliesErrorRateIncreaseArgs();
    }
}
