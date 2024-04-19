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

    public sealed class CalculatedServiceMetricConditionConditionComparisonFlawStateGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("values")]
        private InputList<string>? _values;
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public CalculatedServiceMetricConditionConditionComparisonFlawStateGetArgs()
        {
        }
        public static new CalculatedServiceMetricConditionConditionComparisonFlawStateGetArgs Empty => new CalculatedServiceMetricConditionConditionComparisonFlawStateGetArgs();
    }
}
