// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class ServiceFullWebRequestIdContributorsContextRootServiceIdContributorValueOverrideGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ServiceFullWebRequestIdContributorsContextRootServiceIdContributorValueOverrideGetArgs()
        {
        }
        public static new ServiceFullWebRequestIdContributorsContextRootServiceIdContributorValueOverrideGetArgs Empty => new ServiceFullWebRequestIdContributorsContextRootServiceIdContributorValueOverrideGetArgs();
    }
}
