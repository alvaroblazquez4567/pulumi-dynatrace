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

    public sealed class CloudappWorkloaddetectionKubernetesFiltersFilterArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("inclusionToggles", required: true)]
        public Input<Inputs.CloudappWorkloaddetectionKubernetesFiltersFilterInclusionTogglesArgs> InclusionToggles { get; set; } = null!;

        [Input("matchFilter", required: true)]
        public Input<Inputs.CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilterArgs> MatchFilter { get; set; } = null!;

        public CloudappWorkloaddetectionKubernetesFiltersFilterArgs()
        {
        }
        public static new CloudappWorkloaddetectionKubernetesFiltersFilterArgs Empty => new CloudappWorkloaddetectionKubernetesFiltersFilterArgs();
    }
}
