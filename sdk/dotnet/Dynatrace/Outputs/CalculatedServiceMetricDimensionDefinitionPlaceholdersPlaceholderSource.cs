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
    public sealed class CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSource
    {
        public readonly string? ManagementZone;
        public readonly Outputs.CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTag? ServiceTag;
        public readonly string? Unknowns;

        [OutputConstructor]
        private CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSource(
            string? managementZone,

            Outputs.CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTag? serviceTag,

            string? unknowns)
        {
            ManagementZone = managementZone;
            ServiceTag = serviceTag;
            Unknowns = unknowns;
        }
    }
}