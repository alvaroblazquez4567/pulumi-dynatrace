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

    public sealed class HostNamingConditionConditionTechValueArgs : global::Pulumi.ResourceArgs
    {
        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        [Input("verbatimType")]
        public Input<string>? VerbatimType { get; set; }

        public HostNamingConditionConditionTechValueArgs()
        {
        }
        public static new HostNamingConditionConditionTechValueArgs Empty => new HostNamingConditionConditionTechValueArgs();
    }
}
