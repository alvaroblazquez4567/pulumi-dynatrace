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

    public sealed class CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTagTagKeyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("context")]
        public Input<string>? Context { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        public CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTagTagKeyGetArgs()
        {
        }
        public static new CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTagTagKeyGetArgs Empty => new CalculatedServiceMetricDimensionDefinitionPlaceholdersPlaceholderSourceServiceTagTagKeyGetArgs();
    }
}
