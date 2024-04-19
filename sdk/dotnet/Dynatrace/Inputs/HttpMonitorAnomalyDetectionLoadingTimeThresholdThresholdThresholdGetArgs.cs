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

    public sealed class HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify the event to which an ACTION threshold applies
        /// </summary>
        [Input("eventIndex")]
        public Input<int>? EventIndex { get; set; }

        /// <summary>
        /// Specify the request to which an ACTION threshold applies
        /// </summary>
        [Input("requestIndex")]
        public Input<int>? RequestIndex { get; set; }

        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Notify if monitor takes longer than *X* milliseconds to load
        /// </summary>
        [Input("valueMs", required: true)]
        public Input<int> ValueMs { get; set; } = null!;

        public HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdGetArgs()
        {
        }
        public static new HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdGetArgs Empty => new HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThresholdGetArgs();
    }
}
