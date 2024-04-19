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
    public sealed class ServiceNamingConditionConditionInteger
    {
        public readonly bool? Negate;
        public readonly string Operator;
        public readonly string? Unknowns;
        public readonly int? Value;

        [OutputConstructor]
        private ServiceNamingConditionConditionInteger(
            bool? negate,

            string @operator,

            string? unknowns,

            int? value)
        {
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
