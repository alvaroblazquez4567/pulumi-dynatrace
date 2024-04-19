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
    public sealed class ServiceFullWebServiceIdContributorsWebServiceName
    {
        /// <summary>
        /// Transform this value before letting it contribute to the Service Id
        /// </summary>
        public readonly bool EnableIdContributor;
        /// <summary>
        /// no documentation available
        /// </summary>
        public readonly Outputs.ServiceFullWebServiceIdContributorsWebServiceNameServiceIdContributor? ServiceIdContributor;

        [OutputConstructor]
        private ServiceFullWebServiceIdContributorsWebServiceName(
            bool enableIdContributor,

            Outputs.ServiceFullWebServiceIdContributorsWebServiceNameServiceIdContributor? serviceIdContributor)
        {
            EnableIdContributor = enableIdContributor;
            ServiceIdContributor = serviceIdContributor;
        }
    }
}
