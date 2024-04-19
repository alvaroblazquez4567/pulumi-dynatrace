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
    public sealed class VmwareAnomaliesSlowPhysicalStorageDetectionCustomThresholds
    {
        /// <summary>
        /// Read/write latency is higher than
        /// </summary>
        public readonly int AvgReadWriteLatency;
        /// <summary>
        /// Peak value for read/write latency is higher than
        /// </summary>
        public readonly int PeakReadWriteLatency;

        [OutputConstructor]
        private VmwareAnomaliesSlowPhysicalStorageDetectionCustomThresholds(
            int avgReadWriteLatency,

            int peakReadWriteLatency)
        {
            AvgReadWriteLatency = avgReadWriteLatency;
            PeakReadWriteLatency = peakReadWriteLatency;
        }
    }
}
