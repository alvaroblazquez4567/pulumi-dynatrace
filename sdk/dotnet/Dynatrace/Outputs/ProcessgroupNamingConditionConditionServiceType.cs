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
    public sealed class ProcessgroupNamingConditionConditionServiceType
    {
        public readonly bool? Negate;
        public readonly string Operator;
        public readonly string? Unknowns;
        public readonly string? Value;

        [OutputConstructor]
        private ProcessgroupNamingConditionConditionServiceType(
            bool? negate,

            string @operator,

            string? unknowns,

            string? value)
        {
            Negate = negate;
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
