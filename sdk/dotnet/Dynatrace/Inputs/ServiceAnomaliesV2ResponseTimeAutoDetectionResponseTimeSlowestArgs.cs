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

    public sealed class ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowestArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        [Input("slowestDegradationMilliseconds", required: true)]
        public Input<double> SlowestDegradationMilliseconds { get; set; } = null!;

        /// <summary>
        /// Relative threshold
        /// </summary>
        [Input("slowestDegradationPercent", required: true)]
        public Input<double> SlowestDegradationPercent { get; set; } = null!;

        public ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowestArgs()
        {
        }
        public static new ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowestArgs Empty => new ServiceAnomaliesV2ResponseTimeAutoDetectionResponseTimeSlowestArgs();
    }
}
