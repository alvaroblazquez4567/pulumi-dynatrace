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

    public sealed class ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsArgs : global::Pulumi.ResourceArgs
    {
        [Input("transformations", required: true)]
        private InputList<Inputs.ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsTransformationArgs>? _transformations;
        public InputList<Inputs.ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsTransformationArgs> Transformations
        {
            get => _transformations ?? (_transformations = new InputList<Inputs.ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsTransformationArgs>());
            set => _transformations = value;
        }

        public ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsArgs()
        {
        }
        public static new ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsArgs Empty => new ServiceFullWebServiceIdContributorsWebServiceNamespaceServiceIdContributorTransformationsArgs();
    }
}
