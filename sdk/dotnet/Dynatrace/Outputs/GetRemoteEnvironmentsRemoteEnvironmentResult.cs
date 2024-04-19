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
    public sealed class GetRemoteEnvironmentsRemoteEnvironmentResult
    {
        public readonly string Name;
        public readonly string NetworkScope;
        public readonly string Token;
        public readonly string Uri;

        [OutputConstructor]
        private GetRemoteEnvironmentsRemoteEnvironmentResult(
            string name,

            string networkScope,

            string token,

            string uri)
        {
            Name = name;
            NetworkScope = networkScope;
            Token = token;
            Uri = uri;
        }
    }
}