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
    public sealed class K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationConfiguration
    {
        /// <summary>
        /// within the last
        /// </summary>
        public readonly int ObservationPeriodInMinutes;
        /// <summary>
        /// of quota for at least
        /// </summary>
        public readonly int SamplePeriodInMinutes;
        /// <summary>
        /// amount of utilized namespace CPU is above
        /// </summary>
        public readonly int Threshold;

        [OutputConstructor]
        private K8sNamespaceAnomaliesMemoryLimitsQuotaSaturationConfiguration(
            int observationPeriodInMinutes,

            int samplePeriodInMinutes,

            int threshold)
        {
            ObservationPeriodInMinutes = observationPeriodInMinutes;
            SamplePeriodInMinutes = samplePeriodInMinutes;
            Threshold = threshold;
        }
    }
}
