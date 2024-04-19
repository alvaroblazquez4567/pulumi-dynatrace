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
    public sealed class ManagementZoneRuleConditionProcessMetadataConditionKey
    {
        public readonly string Attribute;
        public readonly string DynamicKey;
        public readonly string? Type;
        public readonly string? Unknowns;

        [OutputConstructor]
        private ManagementZoneRuleConditionProcessMetadataConditionKey(
            string attribute,

            string dynamicKey,

            string? type,

            string? unknowns)
        {
            Attribute = attribute;
            DynamicKey = dynamicKey;
            Type = type;
            Unknowns = unknowns;
        }
    }
}
