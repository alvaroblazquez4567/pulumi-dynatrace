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
    public sealed class IamPolicyBindingsV2Policy
    {
        /// <summary>
        /// The id of the policy
        /// </summary>
        public readonly string Id;
        public readonly ImmutableDictionary<string, string>? Metadata;
        public readonly ImmutableDictionary<string, string>? Parameters;

        [OutputConstructor]
        private IamPolicyBindingsV2Policy(
            string id,

            ImmutableDictionary<string, string>? metadata,

            ImmutableDictionary<string, string>? parameters)
        {
            Id = id;
            Metadata = metadata;
            Parameters = parameters;
        }
    }
}
