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
    public sealed class CalculatedServiceMetricDimensionDefinition
    {
        public readonly string Dimension;
        public readonly string Name;
        public readonly Outputs.CalculatedServiceMetricDimensionDefinitionPlaceholders? Placeholders;
        public readonly int TopX;
        public readonly string TopXAggregation;
        public readonly string TopXDirection;
        public readonly string? Unknowns;

        [OutputConstructor]
        private CalculatedServiceMetricDimensionDefinition(
            string dimension,

            string name,

            Outputs.CalculatedServiceMetricDimensionDefinitionPlaceholders? placeholders,

            int topX,

            string topXAggregation,

            string topXDirection,

            string? unknowns)
        {
            Dimension = dimension;
            Name = name;
            Placeholders = placeholders;
            TopX = topX;
            TopXAggregation = topXAggregation;
            TopXDirection = topXDirection;
            Unknowns = unknowns;
        }
    }
}
