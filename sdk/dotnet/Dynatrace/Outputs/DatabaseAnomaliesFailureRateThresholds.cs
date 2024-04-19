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
    public sealed class DatabaseAnomaliesFailureRateThresholds
    {
        /// <summary>
        /// Sensitivity of the threshold.  With `low` sensitivity, high statistical confidence is used. Brief violations (for example, due to a surge in load) won't trigger alerts.  With `high` sensitivity, no statistical confidence is used. Each violation triggers alert
        /// </summary>
        public readonly string Sensitivity;
        /// <summary>
        /// Failure rate during any 5-minute period to trigger an alert, %
        /// </summary>
        public readonly int Threshold;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DatabaseAnomaliesFailureRateThresholds(
            string sensitivity,

            int threshold,

            string? unknowns)
        {
            Sensitivity = sensitivity;
            Threshold = threshold;
            Unknowns = unknowns;
        }
    }
}
