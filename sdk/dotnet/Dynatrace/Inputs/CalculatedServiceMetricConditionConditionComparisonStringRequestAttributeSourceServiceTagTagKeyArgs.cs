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

    public sealed class CalculatedServiceMetricConditionConditionComparisonStringRequestAttributeSourceServiceTagTagKeyArgs : global::Pulumi.ResourceArgs
    {
        [Input("context")]
        public Input<string>? Context { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        public CalculatedServiceMetricConditionConditionComparisonStringRequestAttributeSourceServiceTagTagKeyArgs()
        {
        }
        public static new CalculatedServiceMetricConditionConditionComparisonStringRequestAttributeSourceServiceTagTagKeyArgs Empty => new CalculatedServiceMetricConditionConditionComparisonStringRequestAttributeSourceServiceTagTagKeyArgs();
    }
}