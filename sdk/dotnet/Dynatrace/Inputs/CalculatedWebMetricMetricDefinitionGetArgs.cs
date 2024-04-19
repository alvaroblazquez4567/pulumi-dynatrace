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

    public sealed class CalculatedWebMetricMetricDefinitionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The metric to be captured. Possible values are `Apdex`, `ApplicationCache`, `Callback`, `CumulativeLayoutShift`, `DNSLookup`, `DOMComplete`, `DOMContentLoaded`, `DOMInteractive`, `DoubleProperty`, `ErrorCount`, `FirstContentfulPaint`, `FirstInputDelay`, `FirstInputStart`, `FirstPaint`, `HTMLDownloaded`, `LargestContentfulPaint`, `LoadEventEnd`, `LoadEventStart`, `LongProperty`, `LongTasksTime`, `NavigationStart`, `OnDOMContentLoaded`, `OnLoad`, `Processing`, `RedirectTime`, `Request`, `RequestStart`, `Response`, `SecureConnect`, `SpeedIndex`, `TCPConnect`, `TimeToFirstByte`, `UserActionDuration`, `VisuallyComplete`
        /// </summary>
        [Input("metric", required: true)]
        public Input<string> Metric { get; set; } = null!;

        /// <summary>
        /// The key of the user action property. Only applicable for DoubleProperty and LongProperty metrics.
        /// </summary>
        [Input("propertyKey")]
        public Input<string>? PropertyKey { get; set; }

        public CalculatedWebMetricMetricDefinitionGetArgs()
        {
        }
        public static new CalculatedWebMetricMetricDefinitionGetArgs Empty => new CalculatedWebMetricMetricDefinitionGetArgs();
    }
}