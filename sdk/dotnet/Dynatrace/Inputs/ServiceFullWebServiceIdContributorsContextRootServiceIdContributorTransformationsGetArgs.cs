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

    public sealed class ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("transformations", required: true)]
        private InputList<Inputs.ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs>? _transformations;
        public InputList<Inputs.ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs> Transformations
        {
            get => _transformations ?? (_transformations = new InputList<Inputs.ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsTransformationGetArgs>());
            set => _transformations = value;
        }

        public ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsGetArgs()
        {
        }
        public static new ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsGetArgs Empty => new ServiceFullWebServiceIdContributorsContextRootServiceIdContributorTransformationsGetArgs();
    }
}
