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

    public sealed class HostNamingConditionConditionCustomHostMetadataConditionKeyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("attribute", required: true)]
        public Input<string> Attribute { get; set; } = null!;

        [Input("dynamicKey", required: true)]
        public Input<Inputs.HostNamingConditionConditionCustomHostMetadataConditionKeyDynamicKeyGetArgs> DynamicKey { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public HostNamingConditionConditionCustomHostMetadataConditionKeyGetArgs()
        {
        }
        public static new HostNamingConditionConditionCustomHostMetadataConditionKeyGetArgs Empty => new HostNamingConditionConditionCustomHostMetadataConditionKeyGetArgs();
    }
}
