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

    public sealed class RequestNamingConditionsConditionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("attribute", required: true)]
        public Input<string> Attribute { get; set; } = null!;

        [Input("comparison", required: true)]
        public Input<Inputs.RequestNamingConditionsConditionComparisonGetArgs> Comparison { get; set; } = null!;

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public RequestNamingConditionsConditionGetArgs()
        {
        }
        public static new RequestNamingConditionsConditionGetArgs Empty => new RequestNamingConditionsConditionGetArgs();
    }
}
