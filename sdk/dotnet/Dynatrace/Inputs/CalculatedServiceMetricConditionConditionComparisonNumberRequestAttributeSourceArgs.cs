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

    public sealed class CalculatedServiceMetricConditionConditionComparisonNumberRequestAttributeSourceArgs : global::Pulumi.ResourceArgs
    {
        [Input("managementZone")]
        public Input<string>? ManagementZone { get; set; }

        [Input("serviceTag")]
        public Input<Inputs.CalculatedServiceMetricConditionConditionComparisonNumberRequestAttributeSourceServiceTagArgs>? ServiceTag { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        public CalculatedServiceMetricConditionConditionComparisonNumberRequestAttributeSourceArgs()
        {
        }
        public static new CalculatedServiceMetricConditionConditionComparisonNumberRequestAttributeSourceArgs Empty => new CalculatedServiceMetricConditionConditionComparisonNumberRequestAttributeSourceArgs();
    }
}
