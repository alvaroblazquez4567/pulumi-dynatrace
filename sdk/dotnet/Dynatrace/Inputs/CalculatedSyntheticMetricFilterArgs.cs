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

    public sealed class CalculatedSyntheticMetricFilterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Only user actions of the specified type are included in the metric calculation
        /// </summary>
        [Input("actionType")]
        public Input<string>? ActionType { get; set; }

        /// <summary>
        /// Only executions finished with the specified error code are included in the metric calculation.
        /// </summary>
        [Input("errorCode")]
        public Input<int>? ErrorCode { get; set; }

        /// <summary>
        /// Only the specified browser clickpath event is included in the metric calculation. Specify the Dynatrace entity ID of the event here.
        /// </summary>
        [Input("event")]
        public Input<string>? Event { get; set; }

        /// <summary>
        /// The execution status of the monitors to be included in the metric calculation: `true` or `false`
        /// </summary>
        [Input("hasError")]
        public Input<bool>? HasError { get; set; }

        /// <summary>
        /// Only executions from the specified location are included in the metric calculation. Specify the Dynatrace entity ID of the location here.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        public CalculatedSyntheticMetricFilterArgs()
        {
        }
        public static new CalculatedSyntheticMetricFilterArgs Empty => new CalculatedSyntheticMetricFilterArgs();
    }
}
