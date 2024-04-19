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

    public sealed class UserSessionMetricsFiltersFilterGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field name
        /// </summary>
        [Input("fieldName", required: true)]
        public Input<string> FieldName { get; set; } = null!;

        /// <summary>
        /// Possible Values: `EQUALS`, `GREATER_THAN`, `GREATER_THAN_OR_EQUAL_TO`, `IN`, `IS_NOT_NULL`, `IS_NULL`, `LESS_THAN`, `LESS_THAN_OR_EQUAL_TO`, `LIKE`, `NOT_EQUAL`, `NOT_LIKE`, `STARTS_WITH`
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("valueIns")]
        private InputList<string>? _valueIns;

        /// <summary>
        /// Values
        /// </summary>
        public InputList<string> ValueIns
        {
            get => _valueIns ?? (_valueIns = new InputList<string>());
            set => _valueIns = value;
        }

        public UserSessionMetricsFiltersFilterGetArgs()
        {
        }
        public static new UserSessionMetricsFiltersFilterGetArgs Empty => new UserSessionMetricsFiltersFilterGetArgs();
    }
}
