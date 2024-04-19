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
    public sealed class ServiceNamingConditionConditionString
    {
        public readonly bool? CaseSensitive;
        public readonly bool? Negate;
        public readonly string Operator;
        public readonly string? Unknowns;
        public readonly string? Value;

        [OutputConstructor]
        private ServiceNamingConditionConditionString(
            bool? caseSensitive,

            bool? negate,

            string @operator,

            string? unknowns,

            string? value)
        {
            CaseSensitive = caseSensitive;
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
