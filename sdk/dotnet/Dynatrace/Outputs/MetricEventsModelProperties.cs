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
    public sealed class MetricEventsModelProperties
    {
        /// <summary>
        /// Possible Values: `ABOVE`, `BELOW`, `OUTSIDE`
        /// </summary>
        public readonly string AlertCondition;
        /// <summary>
        /// The ability to set an alert on missing data in a metric. When enabled, missing data samples will contribute as violating samples defined in advanced model properties. We recommend to not alert on missing data for sparse timeseries as this leads to alert spam.
        /// </summary>
        public readonly bool AlertOnNoData;
        /// <summary>
        /// The number of one-minute samples within the evaluation window that must go back to normal to close the event.
        /// </summary>
        public readonly int DealertingSamples;
        /// <summary>
        /// The number of one-minute samples that form the sliding evaluation window.
        /// </summary>
        public readonly int Samples;
        /// <summary>
        /// Controls how many times the signal fluctuation is added to the baseline to produce the actual threshold for alerting
        /// </summary>
        public readonly double? SignalFluctuation;
        /// <summary>
        /// Raise an event if this value is violated
        /// </summary>
        public readonly double? Threshold;
        /// <summary>
        /// Controls the width of the confidence band and larger values lead to a less sensitive model
        /// </summary>
        public readonly double? Tolerance;
        /// <summary>
        /// Possible Values: `AUTO_ADAPTIVE_THRESHOLD`, `SEASONAL_BASELINE`, `STATIC_THRESHOLD`
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The number of one-minute samples within the evaluation window that must violate to trigger an event.
        /// </summary>
        public readonly int ViolatingSamples;

        [OutputConstructor]
        private MetricEventsModelProperties(
            string alertCondition,

            bool alertOnNoData,

            int dealertingSamples,

            int samples,

            double? signalFluctuation,

            double? threshold,

            double? tolerance,

            string type,

            int violatingSamples)
        {
            AlertCondition = alertCondition;
            AlertOnNoData = alertOnNoData;
            DealertingSamples = dealertingSamples;
            Samples = samples;
            SignalFluctuation = signalFluctuation;
            Threshold = threshold;
            Tolerance = tolerance;
            Type = type;
            ViolatingSamples = violatingSamples;
        }
    }
}
