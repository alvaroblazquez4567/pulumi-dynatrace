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
    public sealed class DatabaseAnomaliesV2ResponseTimeFixedDetectionResponseTimeAll
    {
        /// <summary>
        /// Absolute threshold
        /// </summary>
        public readonly double DegradationMilliseconds;

        [OutputConstructor]
        private DatabaseAnomaliesV2ResponseTimeFixedDetectionResponseTimeAll(double degradationMilliseconds)
        {
            DegradationMilliseconds = degradationMilliseconds;
        }
    }
}