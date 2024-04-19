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
    public sealed class BrowserMonitorAnomalyDetectionLoadingTimeThresholdThreshold
    {
        /// <summary>
        /// The list of performance threshold rules
        /// </summary>
        public readonly ImmutableArray<Outputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdThresholdThreshold> Thresholds;

        [OutputConstructor]
        private BrowserMonitorAnomalyDetectionLoadingTimeThresholdThreshold(ImmutableArray<Outputs.BrowserMonitorAnomalyDetectionLoadingTimeThresholdThresholdThreshold> thresholds)
        {
            Thresholds = thresholds;
        }
    }
}
