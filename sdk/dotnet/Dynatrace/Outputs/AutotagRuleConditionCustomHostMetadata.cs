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
    public sealed class AutotagRuleConditionCustomHostMetadata
    {
        public readonly string Attribute;
        public readonly Outputs.AutotagRuleConditionCustomHostMetadataDynamicKey DynamicKey;
        public readonly string? Unknowns;

        [OutputConstructor]
        private AutotagRuleConditionCustomHostMetadata(
            string attribute,

            Outputs.AutotagRuleConditionCustomHostMetadataDynamicKey dynamicKey,

            string? unknowns)
        {
            Attribute = attribute;
            DynamicKey = dynamicKey;
            Unknowns = unknowns;
        }
    }
}
