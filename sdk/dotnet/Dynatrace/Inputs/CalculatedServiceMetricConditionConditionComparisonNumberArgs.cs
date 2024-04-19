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

    public sealed class CalculatedServiceMetricConditionConditionComparisonNumberArgs : global::Pulumi.ResourceArgs
    {
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        [Input("value")]
        public Input<double>? Value { get; set; }

        [Input("values")]
        private InputList<double>? _values;
        public InputList<double> Values
        {
            get => _values ?? (_values = new InputList<double>());
            set => _values = value;
        }

        public CalculatedServiceMetricConditionConditionComparisonNumberArgs()
        {
        }
        public static new CalculatedServiceMetricConditionConditionComparisonNumberArgs Empty => new CalculatedServiceMetricConditionConditionComparisonNumberArgs();
    }
}
