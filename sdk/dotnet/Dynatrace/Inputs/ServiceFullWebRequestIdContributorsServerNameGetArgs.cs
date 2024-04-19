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

    public sealed class ServiceFullWebRequestIdContributorsServerNameGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Transform this value before letting it contribute to the Service Id
        /// </summary>
        [Input("enableIdContributor", required: true)]
        public Input<bool> EnableIdContributor { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("serviceIdContributor")]
        public Input<Inputs.ServiceFullWebRequestIdContributorsServerNameServiceIdContributorGetArgs>? ServiceIdContributor { get; set; }

        public ServiceFullWebRequestIdContributorsServerNameGetArgs()
        {
        }
        public static new ServiceFullWebRequestIdContributorsServerNameGetArgs Empty => new ServiceFullWebRequestIdContributorsServerNameGetArgs();
    }
}
