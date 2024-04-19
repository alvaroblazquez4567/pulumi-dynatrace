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
    public sealed class HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThreshold
    {
        /// <summary>
        /// Specify the event to which an ACTION threshold applies
        /// </summary>
        public readonly int? EventIndex;
        /// <summary>
        /// Specify the request to which an ACTION threshold applies
        /// </summary>
        public readonly int? RequestIndex;
        /// <summary>
        /// The type of the threshold: `TOTAL` (total loading time) or `ACTION` (action loading time)
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Notify if monitor takes longer than *X* milliseconds to load
        /// </summary>
        public readonly int ValueMs;

        [OutputConstructor]
        private HttpMonitorAnomalyDetectionLoadingTimeThresholdThresholdThreshold(
            int? eventIndex,

            int? requestIndex,

            string? type,

            int valueMs)
        {
            EventIndex = eventIndex;
            RequestIndex = requestIndex;
            Type = type;
            ValueMs = valueMs;
        }
    }
}