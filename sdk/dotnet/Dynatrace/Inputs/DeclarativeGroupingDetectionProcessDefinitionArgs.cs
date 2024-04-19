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

    public sealed class DeclarativeGroupingDetectionProcessDefinitionArgs : global::Pulumi.ResourceArgs
    {
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        [Input("processGroupName", required: true)]
        public Input<string> ProcessGroupName { get; set; } = null!;

        [Input("report", required: true)]
        public Input<string> Report { get; set; } = null!;

        [Input("rules")]
        public Input<Inputs.DeclarativeGroupingDetectionProcessDefinitionRulesArgs>? Rules { get; set; }

        public DeclarativeGroupingDetectionProcessDefinitionArgs()
        {
        }
        public static new DeclarativeGroupingDetectionProcessDefinitionArgs Empty => new DeclarativeGroupingDetectionProcessDefinitionArgs();
    }
}
