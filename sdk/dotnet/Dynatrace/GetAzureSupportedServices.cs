// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace
{
    public static class GetAzureSupportedServices
    {
        /// <summary>
        /// The Azure supported service data source queries for a full list of all supported services.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// 
        /// For an example of this data source, please refer to the Resource Example Usage of the dynatrace.AzureService resource.
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAzureSupportedServicesResult> InvokeAsync(GetAzureSupportedServicesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAzureSupportedServicesResult>("dynatrace:index/getAzureSupportedServices:getAzureSupportedServices", args ?? new GetAzureSupportedServicesArgs(), options.WithDefaults());

        /// <summary>
        /// The Azure supported service data source queries for a full list of all supported services.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// 
        /// For an example of this data source, please refer to the Resource Example Usage of the dynatrace.AzureService resource.
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAzureSupportedServicesResult> Invoke(GetAzureSupportedServicesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAzureSupportedServicesResult>("dynatrace:index/getAzureSupportedServices:getAzureSupportedServices", args ?? new GetAzureSupportedServicesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAzureSupportedServicesArgs : global::Pulumi.InvokeArgs
    {
        [Input("excepts")]
        private List<string>? _excepts;

        /// <summary>
        /// Services with the given names won't be included in the results
        /// </summary>
        public List<string> Excepts
        {
            get => _excepts ?? (_excepts = new List<string>());
            set => _excepts = value;
        }

        public GetAzureSupportedServicesArgs()
        {
        }
        public static new GetAzureSupportedServicesArgs Empty => new GetAzureSupportedServicesArgs();
    }

    public sealed class GetAzureSupportedServicesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("excepts")]
        private InputList<string>? _excepts;

        /// <summary>
        /// Services with the given names won't be included in the results
        /// </summary>
        public InputList<string> Excepts
        {
            get => _excepts ?? (_excepts = new InputList<string>());
            set => _excepts = value;
        }

        public GetAzureSupportedServicesInvokeArgs()
        {
        }
        public static new GetAzureSupportedServicesInvokeArgs Empty => new GetAzureSupportedServicesInvokeArgs();
    }


    [OutputType]
    public sealed class GetAzureSupportedServicesResult
    {
        /// <summary>
        /// Services with the given names won't be included in the results
        /// </summary>
        public readonly ImmutableArray<string> Excepts;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The keys are the names of the supported services. The values provide information whether that service is built in or not.
        /// </summary>
        public readonly ImmutableDictionary<string, bool> Services;

        [OutputConstructor]
        private GetAzureSupportedServicesResult(
            ImmutableArray<string> excepts,

            string id,

            ImmutableDictionary<string, bool> services)
        {
            Excepts = excepts;
            Id = id;
            Services = services;
        }
    }
}