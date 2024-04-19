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

    public sealed class ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Possible Values: `OriginalValue`, `OverrideValue`, `TransformValue`
        /// </summary>
        [Input("contributionType", required: true)]
        public Input<string> ContributionType { get; set; } = null!;

        /// <summary>
        /// Choose how to transform a value before it contributes to the Service Id. Note that all of the Transformations are always applied. Transformations are applied in the order they are specified, and the output of the previous transformation is the input for the next one. The resulting value contributes to the Service Id and can be found on the **Service overview page** under **Properties and tags**.
        /// </summary>
        [Input("transformations")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorTransformationsGetArgs>? Transformations { get; set; }

        /// <summary>
        /// The value to be used instead of the detected value.
        /// </summary>
        [Input("valueOverride")]
        public Input<Inputs.ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorValueOverrideGetArgs>? ValueOverride { get; set; }

        public ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorGetArgs()
        {
        }
        public static new ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorGetArgs Empty => new ServiceFullWebServiceIdContributorsApplicationIdServiceIdContributorGetArgs();
    }
}
