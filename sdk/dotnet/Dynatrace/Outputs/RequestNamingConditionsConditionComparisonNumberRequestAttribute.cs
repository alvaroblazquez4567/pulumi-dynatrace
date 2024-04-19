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
    public sealed class RequestNamingConditionsConditionComparisonNumberRequestAttribute
    {
        public readonly bool? MatchOnChildCalls;
        public readonly string? Operator;
        public readonly string RequestAttribute;
        public readonly Outputs.RequestNamingConditionsConditionComparisonNumberRequestAttributeSource? Source;
        public readonly string? Unknowns;
        public readonly double? Value;
        public readonly ImmutableArray<double> Values;

        [OutputConstructor]
        private RequestNamingConditionsConditionComparisonNumberRequestAttribute(
            bool? matchOnChildCalls,

            string? @operator,

            string requestAttribute,

            Outputs.RequestNamingConditionsConditionComparisonNumberRequestAttributeSource? source,

            string? unknowns,

            double? value,

            ImmutableArray<double> values)
        {
            MatchOnChildCalls = matchOnChildCalls;
            Operator = @operator;
            RequestAttribute = requestAttribute;
            Source = source;
            Unknowns = unknowns;
            Value = value;
            Values = values;
        }
    }
}
