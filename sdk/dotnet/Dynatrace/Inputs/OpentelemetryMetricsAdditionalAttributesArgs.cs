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

    public sealed class OpentelemetryMetricsAdditionalAttributesArgs : global::Pulumi.ResourceArgs
    {
        [Input("additionalAttributes", required: true)]
        private InputList<Inputs.OpentelemetryMetricsAdditionalAttributesAdditionalAttributeArgs>? _additionalAttributes;
        public InputList<Inputs.OpentelemetryMetricsAdditionalAttributesAdditionalAttributeArgs> AdditionalAttributes
        {
            get => _additionalAttributes ?? (_additionalAttributes = new InputList<Inputs.OpentelemetryMetricsAdditionalAttributesAdditionalAttributeArgs>());
            set => _additionalAttributes = value;
        }

        public OpentelemetryMetricsAdditionalAttributesArgs()
        {
        }
        public static new OpentelemetryMetricsAdditionalAttributesArgs Empty => new OpentelemetryMetricsAdditionalAttributesArgs();
    }
}
