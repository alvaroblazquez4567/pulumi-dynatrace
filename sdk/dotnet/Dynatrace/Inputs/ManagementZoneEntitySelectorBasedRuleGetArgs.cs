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

    public sealed class ManagementZoneEntitySelectorBasedRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("selector")]
        public Input<string>? Selector { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public ManagementZoneEntitySelectorBasedRuleGetArgs()
        {
        }
        public static new ManagementZoneEntitySelectorBasedRuleGetArgs Empty => new ManagementZoneEntitySelectorBasedRuleGetArgs();
    }
}
