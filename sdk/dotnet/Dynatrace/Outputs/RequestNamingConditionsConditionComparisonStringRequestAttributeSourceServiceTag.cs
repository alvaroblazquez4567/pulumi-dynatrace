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
    public sealed class RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTag
    {
        public readonly string? Context;
        public readonly string Key;
        public readonly Outputs.RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTagTagKey? TagKey;
        public readonly string? Value;

        [OutputConstructor]
        private RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTag(
            string? context,

            string key,

            Outputs.RequestNamingConditionsConditionComparisonStringRequestAttributeSourceServiceTagTagKey? tagKey,

            string? value)
        {
            Context = context;
            Key = key;
            TagKey = tagKey;
            Value = value;
        }
    }
}
