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
    public sealed class HostNamingConditionConditionIndexedTagComparisonValue
    {
        public readonly string Context;
        public readonly string Key;
        public readonly string? Unknowns;
        public readonly string? Value;

        [OutputConstructor]
        private HostNamingConditionConditionIndexedTagComparisonValue(
            string context,

            string key,

            string? unknowns,

            string? value)
        {
            Context = context;
            Key = key;
            Unknowns = unknowns;
            Value = value;
        }
    }
}
