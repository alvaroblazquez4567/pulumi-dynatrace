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
    public sealed class ManagementZoneDimensionalRuleCondition
    {
        public readonly string Key;
        public readonly string Match;
        public readonly string Type;
        public readonly string? Unknowns;
        public readonly string? Value;

        [OutputConstructor]
        private ManagementZoneDimensionalRuleCondition(
            string key,

            string match,

            string type,

            string? unknowns,

            string? value)
        {
            Key = key;
            Match = match;
            Type = type;
            Unknowns = unknowns;
            Value = value;
        }
    }
}