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
    public sealed class ManagementZoneRule
    {
        public readonly ImmutableArray<Outputs.ManagementZoneRuleCondition> Conditions;
        public readonly bool? Enabled;
        public readonly ImmutableArray<string> PropagationTypes;
        public readonly string Type;
        public readonly string? Unknowns;

        [OutputConstructor]
        private ManagementZoneRule(
            ImmutableArray<Outputs.ManagementZoneRuleCondition> conditions,

            bool? enabled,

            ImmutableArray<string> propagationTypes,

            string type,

            string? unknowns)
        {
            Conditions = conditions;
            Enabled = enabled;
            PropagationTypes = propagationTypes;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
